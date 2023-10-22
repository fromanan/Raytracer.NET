using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Raytracer.Rendering;

namespace Raytracer
{
   public partial class RendererForm : Form
   {
      // [x] Image resolution; higher gives better quality but slower render time
      // There's no point to it being bigger than the window's resolution 
      private float AspectRatio => (float)Width / Height;

      private int RenderHeight => Convert.ToInt32(UserSettings.RenderWidth / AspectRatio);

      private Rectangle ViewingRect => new(0, 0, UserSettings.RenderWidth, RenderHeight);

      public readonly RenderWorker RenderWorker = new();

      public Bitmap? LastRender;

      private readonly ProgressBarWindow _progressBarWindow = new();

      public static UserSettings UserSettings = new()
      {
         RenderWidth = 400,
         SamplesPerPixel = 25,
         MaxReflections = 8,
         PixelFormat = PixelFormat.Format24bppRgb,
         InterpolationMode = InterpolationMode.NearestNeighbor,
         FieldOfView = 30f,
         Aperture = 0.01f,
         FocalDistance = 10f
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

         Bitmap resized = new(frame, ViewingRect.Width, ViewingRect.Height);
         args.Graphics.InterpolationMode = UserSettings.InterpolationMode;
         args.Graphics.DrawImage(resized, ViewingRect, 0, 0, resized.Width, resized.Height, GraphicsUnit.Pixel);
      }

      private Camera CreateCamera()
      {
         return new Camera
         (
             lookFrom: new Vector3(x: 13f, y: 2f, z: 3f),   // Camera origin
             lookAt: Vector3.Zero,                          // Where the camera is looking
             up: Vector3.UnitY,                             // The camera's up (default = global up)
             verticalFov: UserSettings.FieldOfView,         // Field of view
             aspectRatio: drawPanel.AspectRatio,            // Aspect ratio
             aperture: UserSettings.Aperture,               // The radius of the camera's aperture (smaller -> less distance blur)
             focalDistance: UserSettings.FocalDistance      // The distance at which the camera is in focus
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
            message = succeeded ? Messages.FileSaved : Messages.FileSaveFailed;
         }
         catch (ExternalException)
         {
            message = Messages.FileSaveFailed_Extension;
         }
         catch (Exception exception)
         {
            message = string.Format(Messages.FileSaveFailed_Generic, exception.Message);
         }

         MessageBox.Show(message, succeeded ? Messages.Title_SaveSuccessful : Messages.Title_SaveFailed,
             MessageBoxButtons.OK, succeeded ? MessageBoxIcon.Information : MessageBoxIcon.Error);
      }

      private static string? SaveFileToDisk()
      {
         SaveFileDialog dialog = new();
         dialog.Filter = Messages.SaveFileFilter;
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