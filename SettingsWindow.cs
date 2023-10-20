using System;
using System.ComponentModel;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace Raytracer
{
   public partial class SettingsWindow : Form
   {
      private static UserSettings Settings => RendererForm.UserSettings;

      public SettingsWindow()
      {
         InitializeComponent();

         renderWidthValue.Maximum = 4096;
         renderWidthValue.Minimum = 1;

         samplesPerPixelValue.Maximum = 128;
         samplesPerPixelValue.Minimum = 1;

         maxReflectionsValue.Maximum = 32;
         maxReflectionsValue.Minimum = 1;

         samplesPerPixelValue.Maximum = 64;
         samplesPerPixelValue.Minimum = 1;

         bitDepthDropdown.Items.AddRange(new object[]
         {
            PixelFormat.Format24bppRgb,
            PixelFormat.Format32bppRgb,
            PixelFormat.Format48bppRgb
         });

         Shown += OnShown;
         Closing += OnClosing;
      }

      private void OnClosing(object sender, CancelEventArgs e)
      {
         if (DialogResult is not DialogResult.OK)
            return;
         RendererForm.UserSettings.RenderWidth = (int)renderWidthValue.Value;
         RendererForm.UserSettings.SamplesPerPixel = (int)samplesPerPixelValue.Value;
         RendererForm.UserSettings.MaxReflections = (int)maxReflectionsValue.Value;
         RendererForm.UserSettings.PixelFormat = (PixelFormat)bitDepthDropdown.SelectedItem;
      }

      private void OnShown(object? sender, EventArgs e)
      {
         renderWidthValue.Value = Settings.RenderWidth;
         samplesPerPixelValue.Value = Settings.SamplesPerPixel;
         maxReflectionsValue.Value = Settings.MaxReflections;
         bitDepthDropdown.SelectedIndex = bitDepthDropdown.Items.IndexOf(Settings.PixelFormat);
      }
   }
}
