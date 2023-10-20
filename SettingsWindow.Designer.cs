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
         tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
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
         cancelButton = new System.Windows.Forms.Button();
         bitDepthDropdown = new System.Windows.Forms.ComboBox();
         tableLayoutPanel.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)renderWidthValue).BeginInit();
         ((System.ComponentModel.ISupportInitialize)maxReflectionsValue).BeginInit();
         ((System.ComponentModel.ISupportInitialize)samplesPerPixelValue).BeginInit();
         SuspendLayout();
         // 
         // tableLayoutPanel
         // 
         tableLayoutPanel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
         tableLayoutPanel.ColumnCount = 2;
         tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
         tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
         tableLayoutPanel.Controls.Add(confirmButton, 0, 5);
         tableLayoutPanel.Controls.Add(settingLabel, 0, 0);
         tableLayoutPanel.Controls.Add(renderWidthValue, 1, 1);
         tableLayoutPanel.Controls.Add(maxReflectionsValue, 1, 3);
         tableLayoutPanel.Controls.Add(samplesPerPixelValue, 1, 2);
         tableLayoutPanel.Controls.Add(valueLabel, 1, 0);
         tableLayoutPanel.Controls.Add(renderWidthLabel, 0, 1);
         tableLayoutPanel.Controls.Add(samplesPerPixelLabel, 0, 2);
         tableLayoutPanel.Controls.Add(maxReflectionsLabel, 0, 3);
         tableLayoutPanel.Controls.Add(bitDepthLabel, 0, 4);
         tableLayoutPanel.Controls.Add(cancelButton, 1, 5);
         tableLayoutPanel.Controls.Add(bitDepthDropdown, 1, 4);
         tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
         tableLayoutPanel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
         tableLayoutPanel.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
         tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
         tableLayoutPanel.Name = "tableLayoutPanel";
         tableLayoutPanel.Padding = new System.Windows.Forms.Padding(25);
         tableLayoutPanel.RowCount = 6;
         tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
         tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
         tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
         tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
         tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
         tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
         tableLayoutPanel.Size = new System.Drawing.Size(423, 231);
         tableLayoutPanel.TabIndex = 0;
         // 
         // confirmButton
         // 
         confirmButton.DialogResult = System.Windows.Forms.DialogResult.OK;
         confirmButton.Dock = System.Windows.Forms.DockStyle.Fill;
         confirmButton.Location = new System.Drawing.Point(36, 166);
         confirmButton.Margin = new System.Windows.Forms.Padding(10);
         confirmButton.Name = "confirmButton";
         confirmButton.Size = new System.Drawing.Size(165, 29);
         confirmButton.TabIndex = 18;
         confirmButton.Text = "Confirm";
         confirmButton.UseVisualStyleBackColor = true;
         // 
         // settingLabel
         // 
         settingLabel.BackColor = System.Drawing.SystemColors.ControlLight;
         settingLabel.Dock = System.Windows.Forms.DockStyle.Fill;
         settingLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
         settingLabel.Location = new System.Drawing.Point(26, 26);
         settingLabel.Margin = new System.Windows.Forms.Padding(0);
         settingLabel.Name = "settingLabel";
         settingLabel.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
         settingLabel.Size = new System.Drawing.Size(185, 25);
         settingLabel.TabIndex = 1;
         settingLabel.Text = "Setting";
         settingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
         // 
         // renderWidthValue
         // 
         renderWidthValue.BackColor = System.Drawing.SystemColors.Control;
         renderWidthValue.BorderStyle = System.Windows.Forms.BorderStyle.None;
         renderWidthValue.Dock = System.Windows.Forms.DockStyle.Fill;
         renderWidthValue.Location = new System.Drawing.Point(222, 54);
         renderWidthValue.Margin = new System.Windows.Forms.Padding(10, 2, 5, 0);
         renderWidthValue.Name = "renderWidthValue";
         renderWidthValue.Size = new System.Drawing.Size(170, 21);
         renderWidthValue.TabIndex = 16;
         // 
         // maxReflectionsValue
         // 
         maxReflectionsValue.BackColor = System.Drawing.SystemColors.Control;
         maxReflectionsValue.BorderStyle = System.Windows.Forms.BorderStyle.None;
         maxReflectionsValue.Dock = System.Windows.Forms.DockStyle.Fill;
         maxReflectionsValue.Location = new System.Drawing.Point(222, 106);
         maxReflectionsValue.Margin = new System.Windows.Forms.Padding(10, 2, 5, 0);
         maxReflectionsValue.Name = "maxReflectionsValue";
         maxReflectionsValue.Size = new System.Drawing.Size(170, 21);
         maxReflectionsValue.TabIndex = 14;
         // 
         // samplesPerPixelValue
         // 
         samplesPerPixelValue.BackColor = System.Drawing.SystemColors.Control;
         samplesPerPixelValue.BorderStyle = System.Windows.Forms.BorderStyle.None;
         samplesPerPixelValue.Dock = System.Windows.Forms.DockStyle.Fill;
         samplesPerPixelValue.Location = new System.Drawing.Point(222, 80);
         samplesPerPixelValue.Margin = new System.Windows.Forms.Padding(10, 2, 5, 0);
         samplesPerPixelValue.Name = "samplesPerPixelValue";
         samplesPerPixelValue.Size = new System.Drawing.Size(170, 21);
         samplesPerPixelValue.TabIndex = 13;
         // 
         // valueLabel
         // 
         valueLabel.BackColor = System.Drawing.SystemColors.ControlLight;
         valueLabel.Dock = System.Windows.Forms.DockStyle.Fill;
         valueLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
         valueLabel.Location = new System.Drawing.Point(212, 26);
         valueLabel.Margin = new System.Windows.Forms.Padding(0);
         valueLabel.Name = "valueLabel";
         valueLabel.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
         valueLabel.Size = new System.Drawing.Size(185, 25);
         valueLabel.TabIndex = 2;
         valueLabel.Text = "Value";
         valueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
         // 
         // renderWidthLabel
         // 
         renderWidthLabel.BackColor = System.Drawing.SystemColors.Control;
         renderWidthLabel.Dock = System.Windows.Forms.DockStyle.Fill;
         renderWidthLabel.Location = new System.Drawing.Point(26, 52);
         renderWidthLabel.Margin = new System.Windows.Forms.Padding(0);
         renderWidthLabel.Name = "renderWidthLabel";
         renderWidthLabel.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
         renderWidthLabel.Size = new System.Drawing.Size(185, 25);
         renderWidthLabel.TabIndex = 3;
         renderWidthLabel.Text = "Render Width";
         renderWidthLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
         // 
         // samplesPerPixelLabel
         // 
         samplesPerPixelLabel.BackColor = System.Drawing.SystemColors.Control;
         samplesPerPixelLabel.Dock = System.Windows.Forms.DockStyle.Fill;
         samplesPerPixelLabel.Location = new System.Drawing.Point(26, 78);
         samplesPerPixelLabel.Margin = new System.Windows.Forms.Padding(0);
         samplesPerPixelLabel.Name = "samplesPerPixelLabel";
         samplesPerPixelLabel.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
         samplesPerPixelLabel.Size = new System.Drawing.Size(185, 25);
         samplesPerPixelLabel.TabIndex = 5;
         samplesPerPixelLabel.Text = "Samples Per Pixel";
         samplesPerPixelLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
         // 
         // maxReflectionsLabel
         // 
         maxReflectionsLabel.BackColor = System.Drawing.SystemColors.Control;
         maxReflectionsLabel.Dock = System.Windows.Forms.DockStyle.Fill;
         maxReflectionsLabel.Location = new System.Drawing.Point(26, 104);
         maxReflectionsLabel.Margin = new System.Windows.Forms.Padding(0);
         maxReflectionsLabel.Name = "maxReflectionsLabel";
         maxReflectionsLabel.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
         maxReflectionsLabel.Size = new System.Drawing.Size(185, 25);
         maxReflectionsLabel.TabIndex = 7;
         maxReflectionsLabel.Text = "Max Reflections";
         maxReflectionsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
         // 
         // bitDepthLabel
         // 
         bitDepthLabel.BackColor = System.Drawing.SystemColors.Control;
         bitDepthLabel.Dock = System.Windows.Forms.DockStyle.Fill;
         bitDepthLabel.Location = new System.Drawing.Point(26, 130);
         bitDepthLabel.Margin = new System.Windows.Forms.Padding(0);
         bitDepthLabel.Name = "bitDepthLabel";
         bitDepthLabel.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
         bitDepthLabel.Size = new System.Drawing.Size(185, 25);
         bitDepthLabel.TabIndex = 9;
         bitDepthLabel.Text = "Bit Depth";
         bitDepthLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
         // 
         // cancelButton
         // 
         cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
         cancelButton.Dock = System.Windows.Forms.DockStyle.Fill;
         cancelButton.Location = new System.Drawing.Point(222, 166);
         cancelButton.Margin = new System.Windows.Forms.Padding(10);
         cancelButton.Name = "cancelButton";
         cancelButton.Size = new System.Drawing.Size(165, 29);
         cancelButton.TabIndex = 17;
         cancelButton.Text = "Cancel";
         cancelButton.UseVisualStyleBackColor = true;
         // 
         // bitDepthDropdown
         // 
         bitDepthDropdown.BackColor = System.Drawing.SystemColors.Control;
         bitDepthDropdown.Dock = System.Windows.Forms.DockStyle.Fill;
         bitDepthDropdown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         bitDepthDropdown.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
         bitDepthDropdown.FormattingEnabled = true;
         bitDepthDropdown.IntegralHeight = false;
         bitDepthDropdown.ItemHeight = 15;
         bitDepthDropdown.Location = new System.Drawing.Point(219, 130);
         bitDepthDropdown.Margin = new System.Windows.Forms.Padding(7, 0, 5, 0);
         bitDepthDropdown.Name = "bitDepthDropdown";
         bitDepthDropdown.Size = new System.Drawing.Size(173, 23);
         bitDepthDropdown.TabIndex = 19;
         // 
         // SettingsWindow
         // 
         AcceptButton = confirmButton;
         AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
         AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         CancelButton = cancelButton;
         ClientSize = new System.Drawing.Size(423, 231);
         Controls.Add(tableLayoutPanel);
         Name = "SettingsWindow";
         ShowIcon = false;
         StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
         Text = "Settings";
         tableLayoutPanel.ResumeLayout(false);
         ((System.ComponentModel.ISupportInitialize)renderWidthValue).EndInit();
         ((System.ComponentModel.ISupportInitialize)maxReflectionsValue).EndInit();
         ((System.ComponentModel.ISupportInitialize)samplesPerPixelValue).EndInit();
         ResumeLayout(false);
      }

      #endregion

      private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
      private System.Windows.Forms.Label settingLabel;
      private System.Windows.Forms.Label valueLabel;
      private System.Windows.Forms.Label renderWidthLabel;
      private System.Windows.Forms.Label samplesPerPixelLabel;
      private System.Windows.Forms.Label maxReflectionsLabel;
      private System.Windows.Forms.Label bitDepthLabel;
      private System.Windows.Forms.NumericUpDown renderWidthValue;
      private System.Windows.Forms.NumericUpDown maxReflectionsValue;
      private System.Windows.Forms.NumericUpDown samplesPerPixelValue;
      private System.Windows.Forms.Button confirmButton;
      private System.Windows.Forms.Button cancelButton;
      private System.Windows.Forms.ComboBox bitDepthDropdown;
   }
}