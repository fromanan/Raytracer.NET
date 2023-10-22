using System.Windows.Forms;

namespace Raytracer
{
   partial class RendererForm
   {
      /// <summary>
      ///  Required designer variable.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary>
      ///  Clean up any resources being used.
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
      ///  Required method for Designer support - do not modify
      ///  the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent()
      {
         mainMenu = new MenuStrip();
         renderToolStripMenuItem = new ToolStripMenuItem();
         startToolStripMenuItem = new ToolStripMenuItem();
         saveToolStripMenuItem = new ToolStripMenuItem();
         optionsToolStripMenuItem = new ToolStripMenuItem();
         mainPanel = new Panel();
         drawPanel = new RenderPanel();
         mainMenu.SuspendLayout();
         mainPanel.SuspendLayout();
         SuspendLayout();
         // 
         // mainMenu
         // 
         mainMenu.BackColor = System.Drawing.SystemColors.MenuBar;
         mainMenu.BackgroundImageLayout = ImageLayout.None;
         mainMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
         mainMenu.Items.AddRange(new ToolStripItem[] { renderToolStripMenuItem });
         mainMenu.Location = new System.Drawing.Point(0, 0);
         mainMenu.Name = "mainMenu";
         mainMenu.Padding = new Padding(10, 5, 10, 5);
         mainMenu.Size = new System.Drawing.Size(1463, 34);
         mainMenu.TabIndex = 0;
         mainMenu.Text = "mainMenuStrip";
         // 
         // renderToolStripMenuItem
         // 
         renderToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { startToolStripMenuItem, saveToolStripMenuItem, optionsToolStripMenuItem });
         renderToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
         renderToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
         renderToolStripMenuItem.Name = "renderToolStripMenuItem";
         renderToolStripMenuItem.Size = new System.Drawing.Size(72, 24);
         renderToolStripMenuItem.Text = "Render";
         // 
         // startToolStripMenuItem
         // 
         startToolStripMenuItem.Name = "startToolStripMenuItem";
         startToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
         startToolStripMenuItem.Text = "Start";
         startToolStripMenuItem.Click += StartToolStripMenuItem_Click;
         // 
         // saveToolStripMenuItem
         // 
         saveToolStripMenuItem.Name = "saveToolStripMenuItem";
         saveToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
         saveToolStripMenuItem.Text = "Save";
         saveToolStripMenuItem.Click += SaveToolStripMenuItem_Click;
         // 
         // optionsToolStripMenuItem
         // 
         optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
         optionsToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
         optionsToolStripMenuItem.Text = "Options";
         optionsToolStripMenuItem.Click += OptionsToolStripMenuItem_Click;
         // 
         // mainPanel
         // 
         mainPanel.BackColor = System.Drawing.SystemColors.ControlLight;
         mainPanel.Controls.Add(drawPanel);
         mainPanel.Dock = DockStyle.Fill;
         mainPanel.Location = new System.Drawing.Point(0, 34);
         mainPanel.Margin = new Padding(0);
         mainPanel.Name = "mainPanel";
         mainPanel.Padding = new Padding(10);
         mainPanel.Size = new System.Drawing.Size(1463, 926);
         mainPanel.TabIndex = 1;
         // 
         // drawPanel
         // 
         drawPanel.BackColor = System.Drawing.SystemColors.ControlDark;
         drawPanel.Dock = DockStyle.Fill;
         drawPanel.Location = new System.Drawing.Point(10, 10);
         drawPanel.Margin = new Padding(0);
         drawPanel.Name = "drawPanel";
         drawPanel.Size = new System.Drawing.Size(1443, 906);
         drawPanel.TabIndex = 0;
         // 
         // RendererForm
         // 
         AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
         AutoScaleMode = AutoScaleMode.Dpi;
         BackColor = System.Drawing.SystemColors.ControlDarkDark;
         ClientSize = new System.Drawing.Size(1463, 960);
         Controls.Add(mainPanel);
         Controls.Add(mainMenu);
         DoubleBuffered = true;
         MainMenuStrip = mainMenu;
         Margin = new Padding(3, 4, 3, 4);
         Name = "RendererForm";
         ShowIcon = false;
         StartPosition = FormStartPosition.CenterScreen;
         Text = "Raytracer";
         //Paint += RendererForm_Paint;
         mainMenu.ResumeLayout(false);
         mainMenu.PerformLayout();
         mainPanel.ResumeLayout(false);
         ResumeLayout(false);
         PerformLayout();
      }

      #endregion

      private MenuStrip mainMenu;
      private ToolStripMenuItem renderToolStripMenuItem;
      private ToolStripMenuItem startToolStripMenuItem;
      private ToolStripMenuItem saveToolStripMenuItem;
      private ToolStripMenuItem optionsToolStripMenuItem;
      private Panel mainPanel;
      private RenderPanel drawPanel;
   }
}