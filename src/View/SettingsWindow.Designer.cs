namespace Raytracer
{
   partial class SettingsWindow
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
         panel1 = new System.Windows.Forms.Panel();
         tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
         focalDistanceValue = new System.Windows.Forms.NumericUpDown();
         focalDistanceLabel = new System.Windows.Forms.Label();
         apertureValue = new System.Windows.Forms.NumericUpDown();
         fieldOfViewValue = new System.Windows.Forms.NumericUpDown();
         confirmButton = new System.Windows.Forms.Button();
         settingLabel = new System.Windows.Forms.Label();
         renderWidthValue = new System.Windows.Forms.NumericUpDown();
         maxReflectionsValue = new System.Windows.Forms.NumericUpDown();
         samplesPerPixelValue = new System.Windows.Forms.NumericUpDown();
         valueLabel = new System.Windows.Forms.Label();
         renderWidthLabel = new System.Windows.Forms.Label();
         samplesPerPixelLabel = new System.Windows.Forms.Label();
         maxReflectionsLabel = new System.Windows.Forms.Label();
         bitDepthLabel = new System.Windows.Forms.Label();
         fieldOfViewLabel = new System.Windows.Forms.Label();
         apertureLabel = new System.Windows.Forms.Label();
         cancelButton = new System.Windows.Forms.Button();
         bitDepthDropdown = new System.Windows.Forms.ComboBox();
         panel1.SuspendLayout();
         tableLayoutPanel.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)focalDistanceValue).BeginInit();
         ((System.ComponentModel.ISupportInitialize)apertureValue).BeginInit();
         ((System.ComponentModel.ISupportInitialize)fieldOfViewValue).BeginInit();
         ((System.ComponentModel.ISupportInitialize)renderWidthValue).BeginInit();
         ((System.ComponentModel.ISupportInitialize)maxReflectionsValue).BeginInit();
         ((System.ComponentModel.ISupportInitialize)samplesPerPixelValue).BeginInit();
         SuspendLayout();
         // 
         // panel1
         // 
         panel1.BackColor = System.Drawing.SystemColors.ControlDark;
         panel1.Controls.Add(tableLayoutPanel);
         panel1.Dock = System.Windows.Forms.DockStyle.Fill;
         panel1.Location = new System.Drawing.Point(0, 0);
         panel1.Name = "panel1";
         panel1.Padding = new System.Windows.Forms.Padding(10);
         panel1.Size = new System.Drawing.Size(483, 404);
         panel1.TabIndex = 1;
         // 
         // tableLayoutPanel
         // 
         tableLayoutPanel.BackColor = System.Drawing.SystemColors.Control;
         tableLayoutPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
         tableLayoutPanel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
         tableLayoutPanel.ColumnCount = 2;
         tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
         tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
         tableLayoutPanel.Controls.Add(focalDistanceValue, 1, 7);
         tableLayoutPanel.Controls.Add(focalDistanceLabel, 0, 7);
         tableLayoutPanel.Controls.Add(apertureValue, 1, 6);
         tableLayoutPanel.Controls.Add(fieldOfViewValue, 1, 5);
         tableLayoutPanel.Controls.Add(confirmButton, 0, 8);
         tableLayoutPanel.Controls.Add(settingLabel, 0, 0);
         tableLayoutPanel.Controls.Add(renderWidthValue, 1, 1);
         tableLayoutPanel.Controls.Add(maxReflectionsValue, 1, 3);
         tableLayoutPanel.Controls.Add(samplesPerPixelValue, 1, 2);
         tableLayoutPanel.Controls.Add(valueLabel, 1, 0);
         tableLayoutPanel.Controls.Add(renderWidthLabel, 0, 1);
         tableLayoutPanel.Controls.Add(samplesPerPixelLabel, 0, 2);
         tableLayoutPanel.Controls.Add(maxReflectionsLabel, 0, 3);
         tableLayoutPanel.Controls.Add(bitDepthLabel, 0, 4);
         tableLayoutPanel.Controls.Add(fieldOfViewLabel, 0, 5);
         tableLayoutPanel.Controls.Add(apertureLabel, 0, 6);
         tableLayoutPanel.Controls.Add(cancelButton, 1, 8);
         tableLayoutPanel.Controls.Add(bitDepthDropdown, 1, 4);
         tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
         tableLayoutPanel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
         tableLayoutPanel.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
         tableLayoutPanel.Location = new System.Drawing.Point(10, 10);
         tableLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
         tableLayoutPanel.Name = "tableLayoutPanel";
         tableLayoutPanel.Padding = new System.Windows.Forms.Padding(25);
         tableLayoutPanel.RowCount = 9;
         tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
         tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
         tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
         tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
         tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
         tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
         tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
         tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
         tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
         tableLayoutPanel.Size = new System.Drawing.Size(463, 384);
         tableLayoutPanel.TabIndex = 1;
         // 
         // focalDistanceValue
         // 
         focalDistanceValue.BackColor = System.Drawing.SystemColors.Control;
         focalDistanceValue.BorderStyle = System.Windows.Forms.BorderStyle.None;
         focalDistanceValue.DecimalPlaces = 3;
         focalDistanceValue.Dock = System.Windows.Forms.DockStyle.Fill;
         focalDistanceValue.Location = new System.Drawing.Point(243, 267);
         focalDistanceValue.Margin = new System.Windows.Forms.Padding(11, 3, 6, 0);
         focalDistanceValue.Name = "focalDistanceValue";
         focalDistanceValue.Size = new System.Drawing.Size(188, 25);
         focalDistanceValue.TabIndex = 25;
         // 
         // focalDistanceLabel
         // 
         focalDistanceLabel.BackColor = System.Drawing.SystemColors.Control;
         focalDistanceLabel.Dock = System.Windows.Forms.DockStyle.Fill;
         focalDistanceLabel.Location = new System.Drawing.Point(26, 264);
         focalDistanceLabel.Margin = new System.Windows.Forms.Padding(0);
         focalDistanceLabel.Name = "focalDistanceLabel";
         focalDistanceLabel.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
         focalDistanceLabel.Size = new System.Drawing.Size(205, 33);
         focalDistanceLabel.TabIndex = 24;
         focalDistanceLabel.Text = "Focal Distance";
         focalDistanceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
         // 
         // apertureValue
         // 
         apertureValue.BackColor = System.Drawing.SystemColors.Control;
         apertureValue.BorderStyle = System.Windows.Forms.BorderStyle.None;
         apertureValue.DecimalPlaces = 3;
         apertureValue.Dock = System.Windows.Forms.DockStyle.Fill;
         apertureValue.Location = new System.Drawing.Point(243, 233);
         apertureValue.Margin = new System.Windows.Forms.Padding(11, 3, 6, 0);
         apertureValue.Name = "apertureValue";
         apertureValue.Size = new System.Drawing.Size(188, 25);
         apertureValue.TabIndex = 23;
         // 
         // fieldOfViewValue
         // 
         fieldOfViewValue.BackColor = System.Drawing.SystemColors.Control;
         fieldOfViewValue.BorderStyle = System.Windows.Forms.BorderStyle.None;
         fieldOfViewValue.Dock = System.Windows.Forms.DockStyle.Fill;
         fieldOfViewValue.Location = new System.Drawing.Point(243, 199);
         fieldOfViewValue.Margin = new System.Windows.Forms.Padding(11, 3, 6, 0);
         fieldOfViewValue.Name = "fieldOfViewValue";
         fieldOfViewValue.Size = new System.Drawing.Size(188, 25);
         fieldOfViewValue.TabIndex = 21;
         // 
         // confirmButton
         // 
         confirmButton.BackColor = System.Drawing.SystemColors.Control;
         confirmButton.DialogResult = System.Windows.Forms.DialogResult.OK;
         confirmButton.Dock = System.Windows.Forms.DockStyle.Fill;
         confirmButton.Location = new System.Drawing.Point(36, 308);
         confirmButton.Margin = new System.Windows.Forms.Padding(10);
         confirmButton.Name = "confirmButton";
         confirmButton.Size = new System.Drawing.Size(185, 40);
         confirmButton.TabIndex = 18;
         confirmButton.Text = "Save";
         confirmButton.UseVisualStyleBackColor = false;
         // 
         // settingLabel
         // 
         settingLabel.BackColor = System.Drawing.SystemColors.ControlLight;
         settingLabel.Dock = System.Windows.Forms.DockStyle.Fill;
         settingLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
         settingLabel.Location = new System.Drawing.Point(26, 26);
         settingLabel.Margin = new System.Windows.Forms.Padding(0);
         settingLabel.Name = "settingLabel";
         settingLabel.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
         settingLabel.Size = new System.Drawing.Size(205, 33);
         settingLabel.TabIndex = 1;
         settingLabel.Text = "Setting";
         settingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
         // 
         // renderWidthValue
         // 
         renderWidthValue.BackColor = System.Drawing.SystemColors.Control;
         renderWidthValue.BorderStyle = System.Windows.Forms.BorderStyle.None;
         renderWidthValue.Dock = System.Windows.Forms.DockStyle.Fill;
         renderWidthValue.Increment = new decimal(new int[] { 10, 0, 0, 0 });
         renderWidthValue.Location = new System.Drawing.Point(243, 63);
         renderWidthValue.Margin = new System.Windows.Forms.Padding(11, 3, 6, 0);
         renderWidthValue.Name = "renderWidthValue";
         renderWidthValue.Size = new System.Drawing.Size(188, 25);
         renderWidthValue.TabIndex = 16;
         // 
         // maxReflectionsValue
         // 
         maxReflectionsValue.BackColor = System.Drawing.SystemColors.Control;
         maxReflectionsValue.BorderStyle = System.Windows.Forms.BorderStyle.None;
         maxReflectionsValue.Dock = System.Windows.Forms.DockStyle.Fill;
         maxReflectionsValue.Location = new System.Drawing.Point(243, 131);
         maxReflectionsValue.Margin = new System.Windows.Forms.Padding(11, 3, 6, 0);
         maxReflectionsValue.Name = "maxReflectionsValue";
         maxReflectionsValue.Size = new System.Drawing.Size(188, 25);
         maxReflectionsValue.TabIndex = 14;
         // 
         // samplesPerPixelValue
         // 
         samplesPerPixelValue.BackColor = System.Drawing.SystemColors.Control;
         samplesPerPixelValue.BorderStyle = System.Windows.Forms.BorderStyle.None;
         samplesPerPixelValue.Dock = System.Windows.Forms.DockStyle.Fill;
         samplesPerPixelValue.Location = new System.Drawing.Point(243, 97);
         samplesPerPixelValue.Margin = new System.Windows.Forms.Padding(11, 3, 6, 0);
         samplesPerPixelValue.Name = "samplesPerPixelValue";
         samplesPerPixelValue.Size = new System.Drawing.Size(188, 25);
         samplesPerPixelValue.TabIndex = 13;
         // 
         // valueLabel
         // 
         valueLabel.BackColor = System.Drawing.SystemColors.ControlLight;
         valueLabel.Dock = System.Windows.Forms.DockStyle.Fill;
         valueLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
         valueLabel.Location = new System.Drawing.Point(232, 26);
         valueLabel.Margin = new System.Windows.Forms.Padding(0);
         valueLabel.Name = "valueLabel";
         valueLabel.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
         valueLabel.Size = new System.Drawing.Size(205, 33);
         valueLabel.TabIndex = 2;
         valueLabel.Text = "Value";
         valueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
         // 
         // renderWidthLabel
         // 
         renderWidthLabel.BackColor = System.Drawing.SystemColors.Control;
         renderWidthLabel.Dock = System.Windows.Forms.DockStyle.Fill;
         renderWidthLabel.Location = new System.Drawing.Point(26, 60);
         renderWidthLabel.Margin = new System.Windows.Forms.Padding(0);
         renderWidthLabel.Name = "renderWidthLabel";
         renderWidthLabel.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
         renderWidthLabel.Size = new System.Drawing.Size(205, 33);
         renderWidthLabel.TabIndex = 3;
         renderWidthLabel.Text = "Render Width";
         renderWidthLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
         // 
         // samplesPerPixelLabel
         // 
         samplesPerPixelLabel.BackColor = System.Drawing.SystemColors.Control;
         samplesPerPixelLabel.Dock = System.Windows.Forms.DockStyle.Fill;
         samplesPerPixelLabel.Location = new System.Drawing.Point(26, 94);
         samplesPerPixelLabel.Margin = new System.Windows.Forms.Padding(0);
         samplesPerPixelLabel.Name = "samplesPerPixelLabel";
         samplesPerPixelLabel.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
         samplesPerPixelLabel.Size = new System.Drawing.Size(205, 33);
         samplesPerPixelLabel.TabIndex = 5;
         samplesPerPixelLabel.Text = "Samples Per Pixel";
         samplesPerPixelLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
         // 
         // maxReflectionsLabel
         // 
         maxReflectionsLabel.BackColor = System.Drawing.SystemColors.Control;
         maxReflectionsLabel.Dock = System.Windows.Forms.DockStyle.Fill;
         maxReflectionsLabel.Location = new System.Drawing.Point(26, 128);
         maxReflectionsLabel.Margin = new System.Windows.Forms.Padding(0);
         maxReflectionsLabel.Name = "maxReflectionsLabel";
         maxReflectionsLabel.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
         maxReflectionsLabel.Size = new System.Drawing.Size(205, 33);
         maxReflectionsLabel.TabIndex = 7;
         maxReflectionsLabel.Text = "Max Reflections";
         maxReflectionsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
         // 
         // bitDepthLabel
         // 
         bitDepthLabel.BackColor = System.Drawing.SystemColors.Control;
         bitDepthLabel.Dock = System.Windows.Forms.DockStyle.Fill;
         bitDepthLabel.Location = new System.Drawing.Point(26, 162);
         bitDepthLabel.Margin = new System.Windows.Forms.Padding(0);
         bitDepthLabel.Name = "bitDepthLabel";
         bitDepthLabel.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
         bitDepthLabel.Size = new System.Drawing.Size(205, 33);
         bitDepthLabel.TabIndex = 9;
         bitDepthLabel.Text = "Bit Depth";
         bitDepthLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
         // 
         // fieldOfViewLabel
         // 
         fieldOfViewLabel.BackColor = System.Drawing.SystemColors.Control;
         fieldOfViewLabel.Dock = System.Windows.Forms.DockStyle.Fill;
         fieldOfViewLabel.Location = new System.Drawing.Point(26, 196);
         fieldOfViewLabel.Margin = new System.Windows.Forms.Padding(0);
         fieldOfViewLabel.Name = "fieldOfViewLabel";
         fieldOfViewLabel.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
         fieldOfViewLabel.Size = new System.Drawing.Size(205, 33);
         fieldOfViewLabel.TabIndex = 20;
         fieldOfViewLabel.Text = "Field of View";
         fieldOfViewLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
         // 
         // apertureLabel
         // 
         apertureLabel.BackColor = System.Drawing.SystemColors.Control;
         apertureLabel.Dock = System.Windows.Forms.DockStyle.Fill;
         apertureLabel.Location = new System.Drawing.Point(26, 230);
         apertureLabel.Margin = new System.Windows.Forms.Padding(0);
         apertureLabel.Name = "apertureLabel";
         apertureLabel.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
         apertureLabel.Size = new System.Drawing.Size(205, 33);
         apertureLabel.TabIndex = 22;
         apertureLabel.Text = "Aperture";
         apertureLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
         // 
         // cancelButton
         // 
         cancelButton.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
         cancelButton.BackColor = System.Drawing.SystemColors.Control;
         cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
         cancelButton.Location = new System.Drawing.Point(242, 308);
         cancelButton.Margin = new System.Windows.Forms.Padding(10);
         cancelButton.Name = "cancelButton";
         cancelButton.Size = new System.Drawing.Size(185, 40);
         cancelButton.TabIndex = 17;
         cancelButton.Text = "Cancel";
         cancelButton.UseVisualStyleBackColor = false;
         // 
         // bitDepthDropdown
         // 
         bitDepthDropdown.BackColor = System.Drawing.SystemColors.Control;
         bitDepthDropdown.Dock = System.Windows.Forms.DockStyle.Fill;
         bitDepthDropdown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         bitDepthDropdown.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
         bitDepthDropdown.FormattingEnabled = true;
         bitDepthDropdown.IntegralHeight = false;
         bitDepthDropdown.ItemHeight = 20;
         bitDepthDropdown.Location = new System.Drawing.Point(240, 162);
         bitDepthDropdown.Margin = new System.Windows.Forms.Padding(8, 0, 6, 0);
         bitDepthDropdown.Name = "bitDepthDropdown";
         bitDepthDropdown.Size = new System.Drawing.Size(191, 28);
         bitDepthDropdown.TabIndex = 19;
         // 
         // SettingsWindow
         // 
         AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
         AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
         ClientSize = new System.Drawing.Size(483, 404);
         Controls.Add(panel1);
         FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
         Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
         Name = "SettingsWindow";
         ShowIcon = false;
         SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
         StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
         Text = "Settings";
         panel1.ResumeLayout(false);
         tableLayoutPanel.ResumeLayout(false);
         ((System.ComponentModel.ISupportInitialize)focalDistanceValue).EndInit();
         ((System.ComponentModel.ISupportInitialize)apertureValue).EndInit();
         ((System.ComponentModel.ISupportInitialize)fieldOfViewValue).EndInit();
         ((System.ComponentModel.ISupportInitialize)renderWidthValue).EndInit();
         ((System.ComponentModel.ISupportInitialize)maxReflectionsValue).EndInit();
         ((System.ComponentModel.ISupportInitialize)samplesPerPixelValue).EndInit();
         ResumeLayout(false);
      }

      #endregion
      private System.Windows.Forms.Panel panel1;
      private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
      private System.Windows.Forms.NumericUpDown focalDistanceValue;
      private System.Windows.Forms.Label focalDistanceLabel;
      private System.Windows.Forms.NumericUpDown apertureValue;
      private System.Windows.Forms.NumericUpDown fieldOfViewValue;
      private System.Windows.Forms.Button confirmButton;
      private System.Windows.Forms.Label settingLabel;
      private System.Windows.Forms.NumericUpDown renderWidthValue;
      private System.Windows.Forms.NumericUpDown maxReflectionsValue;
      private System.Windows.Forms.NumericUpDown samplesPerPixelValue;
      private System.Windows.Forms.Label valueLabel;
      private System.Windows.Forms.Label renderWidthLabel;
      private System.Windows.Forms.Label samplesPerPixelLabel;
      private System.Windows.Forms.Label maxReflectionsLabel;
      private System.Windows.Forms.Label bitDepthLabel;
      private System.Windows.Forms.Label fieldOfViewLabel;
      private System.Windows.Forms.Label apertureLabel;
      private System.Windows.Forms.Button cancelButton;
      private System.Windows.Forms.ComboBox bitDepthDropdown;
   }
}