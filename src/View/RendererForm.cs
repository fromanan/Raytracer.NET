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
      public static RendererForm Instance { get; private set; }
      
      private int RenderHeight => Convert.ToInt32(UserSettings.RenderWidth / drawPanel.AspectRatio);

      private Rectangle RenderRect => new(0, 0, UserSettings.RenderWidth, RenderHeight);

      public Bitmap? CurrentFrame => RenderWorker.IsBusy ? RenderWorker.CurrentRender : LastRender;

      public readonly RenderWorker RenderWorker = new();

      private Bitmap? LastRender { get; set; }

      private readonly ProgressBarWindow _progressBarWindow = new();

      public static UserSettings UserSettings = new()
      {
         RenderWidth = 1280,
         SamplesPerPixel = 32,
         MaxReflections = 8,
         PixelFormat = PixelFormat.Format24bppRgb,
         InterpolationMode = InterpolationMode.NearestNeighbor,
         FieldOfView = 30f,
         Aperture = 0.01f,
         FocalDistance = 10f
      };

      public RendererForm()
      {
         Instance = this;
         InitializeComponent();
         RenderWorker.InitializeWorker();
         RenderWorker.ProgressChanged += OnUpdateProgressBar;
         RenderWorker.RunWorkerCompleted += OnRenderCompleted;
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

         RenderWorker.RunWorkerAsync(new RenderArgs(RenderRect, CreateCamera()));

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
         return dialog.ShowDialog() is DialogResult.OK ? dialog.FileName : default;
      }

      private void OptionsToolStripMenuItem_Click(object sender, EventArgs args)
      {
         new SettingsWindow().ShowDialog();
      }

      private void OnUpdateProgressBar(object? sender, ProgressChangedEventArgs args)
      {
         _progressBarWindow.UpdateProgress(args.ProgressPercentage);
         drawPanel.Invalidate();
      }

      private void OnRenderCompleted(object? sender, RunWorkerCompletedEventArgs args)
      {
         if (args.Cancelled || args.Result is not Bitmap frame)
            return;
         if (_progressBarWindow.Visible)
            _progressBarWindow.Close();
         LastRender = frame;
         drawPanel.Invalidate();
      }
   }
}