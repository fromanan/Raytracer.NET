using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Raytracer
{
   public partial class RendererForm : Form
   {
      // [x] Image resolution; higher gives better quality but slower render time
      // There's no point to it being bigger than the window's resolution 
      private double AspectRatio => (double)Width / Height;

      private int RenderHeight => Convert.ToInt32(UserSettings.RenderWidth / AspectRatio);

      private Rectangle ViewingRect => new(0, 0, Width, Height);

      public readonly RenderWorker RenderWorker = new();

      public Bitmap? LastRender;

      private readonly ProgressBarWindow _progressBarWindow = new();

      public static UserSettings UserSettings = new()
      {
         RenderWidth = 400,
         SamplesPerPixel = 25,
         MaxReflections = 8,
         PixelFormat = PixelFormat.Format24bppRgb,
         InterpolationMode = InterpolationMode.NearestNeighbor
      };

      public RendererForm()
      {
         InitializeComponent();
         RenderWorker.InitializeWorker();
         RenderWorker.ProgressChanged += OnUpdateProgressBar;
         RenderWorker.RunWorkerCompleted += OnRenderCompleted;
         SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
      }

      private void RendererForm_Paint(object sender, PaintEventArgs args)
      {
         if ((RenderWorker.IsBusy ? RenderWorker.CurrentRender : LastRender) is not { } frame)
            return;

         args.Graphics.InterpolationMode = UserSettings.InterpolationMode;
         args.Graphics.DrawImage(frame, ViewingRect, 0, 0, frame.Width, frame.Height, GraphicsUnit.Pixel);
      }

      private Camera CreateCamera()
      {
         return new Camera
         (
            lookFrom: new Vector3(13d, 2d, 3d), // Camera origin
            lookAt: Vector3.Zero,                     // Where the camera is looking
            vup: Vector3.Up,                          // The camera's up (default = global up)
            verticalFov: 20d,                         // Field of view
            aspectRatio: AspectRatio,                 // Aspect ratio
            aperture: 0.01d,                          // The radius of the camera's aperture (smaller -> less distance blur)
            focalDistance: 10d                        // The distance at which the camera is in focus
         );
      }

      private void StartToolStripMenuItem_Click(object sender, EventArgs args)
      {
         if (RenderWorker.IsBusy)
            return;

         RenderWorker.RunWorkerAsync(new RenderArgs(ViewingRect, CreateCamera()));

         if (_progressBarWindow.ShowDialog() is DialogResult.Cancel or DialogResult.Abort)
         {
            RenderWorker.CancelAsync();
         }
      }

      private void SaveToolStripMenuItem_Click(object sender, EventArgs args)
      {
         if (LastRender is null)
            return;

         if (SaveFileToDisk() is not { } filename)
            return;

         string message;
         bool succeeded = false;
         try
         {
            LastRender.Save(filename);
            succeeded = File.Exists(filename);
            message = succeeded ? "File saved successfully!" : "File failed to save to disk!";
         }
         catch (ExternalException)
         {
            message = "File could not be saved as specified extension!";
         }
         catch (Exception exception)
         {
            message = $"File failed to save to disk! ({exception.Message})";
         }

         MessageBox.Show(message, succeeded ? "Save successful" : "Save failed", MessageBoxButtons.OK,
            succeeded ? MessageBoxIcon.Information : MessageBoxIcon.Error);
      }

      private static string? SaveFileToDisk()
      {
         SaveFileDialog dialog = new();
         dialog.Filter = "Bitmap Image (.bmp)|*.bmp|Gif Image (.gif)|*.gif |JPEG Image (.jpeg)|*.jpeg |Png Image (.png)|*.png |Tiff Image (.tiff)|*.tiff |Wmf Image (.wmf)|*.wmf";
         dialog.DefaultExt = "bmp";
         dialog.ValidateNames = true;
         return dialog.ShowDialog() is DialogResult.OK or DialogResult.Yes ? dialog.FileName : default;
      }

      private void OptionsToolStripMenuItem_Click(object sender, EventArgs args)
      {
         new SettingsWindow().ShowDialog();
      }

      private void OnUpdateProgressBar(object? sender, ProgressChangedEventArgs args)
      {
         _progressBarWindow.UpdateProgress(args.ProgressPercentage);
         Refresh();
      }

      private void OnRenderCompleted(object? sender, RunWorkerCompletedEventArgs args)
      {
         if (args.Cancelled || args.Result is not Bitmap frame)
            return;
         if (_progressBarWindow.Visible)
            _progressBarWindow.Close();
         LastRender = frame;
         Refresh();
      }
   }
}