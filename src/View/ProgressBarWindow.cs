using System;
using System.Windows.Forms;

namespace Raytracer
{
   public partial class ProgressBarWindow : Form
   {
      public ProgressBarWindow()
      {
         InitializeComponent();
      }

      private void CancelButton_Click(object sender, EventArgs e)
      {
         DialogResult = DialogResult.Cancel;
         Close();
      }

      public void UpdateProgress(int progress)
      {
         progressBar.Value = progress;
         Invalidate();
      }
   }
}
