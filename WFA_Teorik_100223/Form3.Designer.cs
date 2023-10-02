namespace WFA_Teorik_100223
{
    partial class Form3
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
            menuStrip1 = new MenuStrip();
            öğrenciEkleToolStripMenuItem = new ToolStripMenuItem();
            yeniEkleToolStripMenuItem = new ToolStripMenuItem();
            hepsiniKapatToolStripMenuItem = new ToolStripMenuItem();
            çıkışToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { öğrenciEkleToolStripMenuItem, hepsiniKapatToolStripMenuItem, çıkışToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // öğrenciEkleToolStripMenuItem
            // 
            öğrenciEkleToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { yeniEkleToolStripMenuItem });
            öğrenciEkleToolStripMenuItem.Name = "öğrenciEkleToolStripMenuItem";
            öğrenciEkleToolStripMenuItem.Size = new Size(106, 24);
            öğrenciEkleToolStripMenuItem.Text = "Öğrenci Ekle";
            öğrenciEkleToolStripMenuItem.Click += öğrenciEkleToolStripMenuItem_Click;
            // 
            // yeniEkleToolStripMenuItem
            // 
            yeniEkleToolStripMenuItem.Name = "yeniEkleToolStripMenuItem";
            yeniEkleToolStripMenuItem.Size = new Size(150, 26);
            yeniEkleToolStripMenuItem.Text = "Yeni Ekle";
            yeniEkleToolStripMenuItem.Click += yeniEkleToolStripMenuItem_Click;
            // 
            // hepsiniKapatToolStripMenuItem
            // 
            hepsiniKapatToolStripMenuItem.Name = "hepsiniKapatToolStripMenuItem";
            hepsiniKapatToolStripMenuItem.Size = new Size(116, 24);
            hepsiniKapatToolStripMenuItem.Text = "Hepsini Kapat";
            hepsiniKapatToolStripMenuItem.Click += hepsiniKapatToolStripMenuItem_Click;
            // 
            // çıkışToolStripMenuItem
            // 
            çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            çıkışToolStripMenuItem.Size = new Size(53, 24);
            çıkışToolStripMenuItem.Text = "Çıkış";
            çıkışToolStripMenuItem.Click += çıkışToolStripMenuItem_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "Form3";
            Text = "Form3";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem öğrenciEkleToolStripMenuItem;
        private ToolStripMenuItem yeniEkleToolStripMenuItem;
        private ToolStripMenuItem hepsiniKapatToolStripMenuItem;
        private ToolStripMenuItem çıkışToolStripMenuItem;
    }
}