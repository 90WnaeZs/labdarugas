
namespace Labdarugas
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.csapatHozzáadásaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.csapatMódosításaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.csapatTörléseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eredményRögzítésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kilistázásToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.csapatHozzáadásaToolStripMenuItem,
            this.csapatMódosításaToolStripMenuItem,
            this.csapatTörléseToolStripMenuItem,
            this.eredményRögzítésToolStripMenuItem,
            this.kilistázásToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // csapatHozzáadásaToolStripMenuItem
            // 
            this.csapatHozzáadásaToolStripMenuItem.Name = "csapatHozzáadásaToolStripMenuItem";
            this.csapatHozzáadásaToolStripMenuItem.Size = new System.Drawing.Size(118, 20);
            this.csapatHozzáadásaToolStripMenuItem.Text = "Csapat hozzáadása";
            this.csapatHozzáadásaToolStripMenuItem.Click += new System.EventHandler(this.csapatHozzáadásaToolStripMenuItem_Click);
            // 
            // csapatMódosításaToolStripMenuItem
            // 
            this.csapatMódosításaToolStripMenuItem.Name = "csapatMódosításaToolStripMenuItem";
            this.csapatMódosításaToolStripMenuItem.Size = new System.Drawing.Size(119, 20);
            this.csapatMódosításaToolStripMenuItem.Text = "Csapat módosítása";
            this.csapatMódosításaToolStripMenuItem.Click += new System.EventHandler(this.csapatMódosításaToolStripMenuItem_Click);
            // 
            // csapatTörléseToolStripMenuItem
            // 
            this.csapatTörléseToolStripMenuItem.Name = "csapatTörléseToolStripMenuItem";
            this.csapatTörléseToolStripMenuItem.Size = new System.Drawing.Size(93, 20);
            this.csapatTörléseToolStripMenuItem.Text = "Csapat törlése";
            this.csapatTörléseToolStripMenuItem.Click += new System.EventHandler(this.csapatTörléseToolStripMenuItem_Click);
            // 
            // eredményRögzítésToolStripMenuItem
            // 
            this.eredményRögzítésToolStripMenuItem.Name = "eredményRögzítésToolStripMenuItem";
            this.eredményRögzítésToolStripMenuItem.Size = new System.Drawing.Size(116, 20);
            this.eredményRögzítésToolStripMenuItem.Text = "Eredmény rögzítés";
            this.eredményRögzítésToolStripMenuItem.Click += new System.EventHandler(this.eredményRögzítésToolStripMenuItem_Click);
            // 
            // kilistázásToolStripMenuItem
            // 
            this.kilistázásToolStripMenuItem.Name = "kilistázásToolStripMenuItem";
            this.kilistázásToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.kilistázásToolStripMenuItem.Text = "Kilistázás";
            this.kilistázásToolStripMenuItem.Click += new System.EventHandler(this.kilistázásToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Nyilvántartás";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem csapatHozzáadásaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem csapatMódosításaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem csapatTörléseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eredményRögzítésToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kilistázásToolStripMenuItem;
    }
}

