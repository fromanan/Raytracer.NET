namespace Raytracer
{
   partial class ProgressBarWindow
   {
      /// <summary>
      /// Required designer variable.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary>
      /// Clean up any resources being used.
      /// </summary>
      /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
      protected override void Dispose(bool disposing)
      {
         if (disposing && (components != null))
         {
            components.Dispose();
         }
         base.Dispose(disposing);
      }

      #region Windows Form Designer generated code

      /// <summary>
      /// Required method for Designer support - do not modify
      /// the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent()
      {
         splitContainer1 = new System.Windows.Forms.SplitContainer();
         label = new System.Windows.Forms.Label();
         cancelButton = new System.Windows.Forms.Button();
         progressBar = new System.Windows.Forms.ProgressBar();
         ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
         splitContainer1.Panel1.SuspendLayout();
         splitContainer1.Panel2.SuspendLayout();
         splitContainer1.SuspendLayout();
         SuspendLayout();
         // 
         // splitContainer1
         // 
         splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
         splitContainer1.Location = new System.Drawing.Point(0, 0);
         splitContainer1.Name = "splitContainer1";
         splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
         // 
         // splitContainer1.Panel1
         // 
         splitContainer1.Panel1.Controls.Add(label);
         splitContainer1.Panel1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
         splitContainer1.Panel1.Padding = new System.Windows.Forms.Padding(25, 25, 25, 10);
         splitContainer1.Panel1.UseWaitCursor = true;
         // 
         // splitContainer1.Panel2
         // 
         splitContainer1.Panel2.Controls.Add(cancelButton);
         splitContainer1.Panel2.Controls.Add(progressBar);
         splitContainer1.Panel2.Padding = new System.Windows.Forms.Padding(25, 10, 25, 40);
         splitContainer1.Panel2.UseWaitCursor = true;
         splitContainer1.Size = new System.Drawing.Size(434, 150);
         splitContainer1.SplitterDistance = 74;
         splitContainer1.SplitterWidth = 1;
         splitContainer1.TabIndex = 2;
         splitContainer1.UseWaitCursor = true;
         // 
         // label
         // 
         label.Dock = System.Windows.Forms.DockStyle.Fill;
         label.Location = new System.Drawing.Point(25, 25);
         label.Name = "label";
         label.Size = new System.Drawing.Size(384, 39);
         label.TabIndex = 0;
         label.Text = "Render In Progress";
         label.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
         label.UseWaitCursor = true;
         // 
         // cancelButton
         // 
         cancelButton.Location = new System.Drawing.Point(284, 38);
         cancelButton.Name = "cancelButton";
         cancelButton.Size = new System.Drawing.Size(125, 25);
         cancelButton.TabIndex = 1;
         cancelButton.Text = "Cancel";
         cancelButton.UseVisualStyleBackColor = true;
         cancelButton.UseWaitCursor = true;
         cancelButton.Click += CancelButton_Click;
         // 
         // progressBar
         // 
         progressBar.Dock = System.Windows.Forms.DockStyle.Fill;
         progressBar.Location = new System.Drawing.Point(25, 10);
         progressBar.Margin = new System.Windows.Forms.Padding(0);
         progressBar.Name = "progressBar";
         progressBar.Size = new System.Drawing.Size(384, 25);
         progressBar.TabIndex = 0;
         progressBar.UseWaitCursor = true;
         // 
         // ProgressBarWindow
         // 
         AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
         AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         CancelButton = cancelButton;
         ClientSize = new System.Drawing.Size(434, 150);
         Controls.Add(splitContainer1);
         FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
         Name = "ProgressBarWindow";
         ShowIcon = false;
         StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
         Text = "Rendering";
         TopMost = true;
         UseWaitCursor = true;
         splitContainer1.Panel1.ResumeLayout(false);
         splitContainer1.Panel2.ResumeLayout(false);
         ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
         splitContainer1.ResumeLayout(false);
         ResumeLayout(false);
      }

      #endregion

      private System.Windows.Forms.SplitContainer splitContainer1;
      private System.Windows.Forms.Label label;
      private System.Windows.Forms.ProgressBar progressBar;
      private System.Windows.Forms.Button cancelButton;
   }
}