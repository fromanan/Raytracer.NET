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
         menuStrip1 = new MenuStrip();
         renderToolStripMenuItem = new ToolStripMenuItem();
         startToolStripMenuItem = new ToolStripMenuItem();
         saveToolStripMenuItem = new ToolStripMenuItem();
         optionsToolStripMenuItem1 = new ToolStripMenuItem();
         menuStrip1.SuspendLayout();
         SuspendLayout();
         // 
         // menuStrip1
         // 
         menuStrip1.BackColor = System.Drawing.SystemColors.ControlLight;
         menuStrip1.Items.AddRange(new ToolStripItem[] { renderToolStripMenuItem });
         menuStrip1.Location = new System.Drawing.Point(0, 0);
         menuStrip1.Name = "menuStrip1";
         menuStrip1.Size = new System.Drawing.Size(1280, 24);
         menuStrip1.TabIndex = 0;
         menuStrip1.Text = "mainMenuStrip";
         // 
         // renderToolStripMenuItem
         // 
         renderToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { startToolStripMenuItem, saveToolStripMenuItem, optionsToolStripMenuItem1 });
         renderToolStripMenuItem.Name = "renderToolStripMenuItem";
         renderToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
         renderToolStripMenuItem.Text = "Render";
         // 
         // startToolStripMenuItem
         // 
         startToolStripMenuItem.Name = "startToolStripMenuItem";
         startToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
         startToolStripMenuItem.Text = "Start";
         startToolStripMenuItem.Click += StartToolStripMenuItem_Click;
         // 
         // saveToolStripMenuItem
         // 
         saveToolStripMenuItem.Name = "saveToolStripMenuItem";
         saveToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
         saveToolStripMenuItem.Text = "Save";
         saveToolStripMenuItem.Click += SaveToolStripMenuItem_Click;
         // 
         // optionsToolStripMenuItem1
         // 
         optionsToolStripMenuItem1.Name = "optionsToolStripMenuItem1";
         optionsToolStripMenuItem1.Size = new System.Drawing.Size(116, 22);
         optionsToolStripMenuItem1.Text = "Options";
         optionsToolStripMenuItem1.Click += OptionsToolStripMenuItem_Click;
         // 
         // RendererForm
         // 
         AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
         AutoScaleMode = AutoScaleMode.Font;
         ClientSize = new System.Drawing.Size(1280, 720);
         Controls.Add(menuStrip1);
         DoubleBuffered = true;
         MainMenuStrip = menuStrip1;
         Name = "RendererForm";
         ShowIcon = false;
         StartPosition = FormStartPosition.CenterScreen;
         Text = "Raytracer";
         Paint += RendererForm_Paint;
         menuStrip1.ResumeLayout(false);
         menuStrip1.PerformLayout();
         ResumeLayout(false);
         PerformLayout();
      }

      #endregion

      private MenuStrip menuStrip1;
      private ToolStripMenuItem renderToolStripMenuItem;
      private ToolStripMenuItem startToolStripMenuItem;
      private ToolStripMenuItem saveToolStripMenuItem;
      private ToolStripMenuItem optionsToolStripMenuItem1;
   }
}