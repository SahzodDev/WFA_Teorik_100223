namespace WFA_Teorik_100223
{
    partial class Form2
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
            btnDriveInfo = new Button();
            btnDirectory = new Button();
            btnKlasorIslemleri = new Button();
            btnDirectories = new Button();
            btnFiles = new Button();
            lstDirectories = new ListBox();
            lstFiles = new ListBox();
            btnDosyaKopyala = new Button();
            btnKlasorKopyala = new Button();
            SuspendLayout();
            // 
            // btnDriveInfo
            // 
            btnDriveInfo.Location = new Point(12, 12);
            btnDriveInfo.Name = "btnDriveInfo";
            btnDriveInfo.Size = new Size(146, 29);
            btnDriveInfo.TabIndex = 0;
            btnDriveInfo.Text = "Sürücü Bilgileri";
            btnDriveInfo.UseVisualStyleBackColor = true;
            btnDriveInfo.Click += btnDriveInfo_Click;
            // 
            // btnDirectory
            // 
            btnDirectory.Location = new Point(164, 12);
            btnDirectory.Name = "btnDirectory";
            btnDirectory.Size = new Size(146, 29);
            btnDirectory.TabIndex = 1;
            btnDirectory.Text = "Klasör Bilgileri";
            btnDirectory.UseVisualStyleBackColor = true;
            btnDirectory.Click += btnDirectory_Click;
            // 
            // btnKlasorIslemleri
            // 
            btnKlasorIslemleri.Location = new Point(316, 12);
            btnKlasorIslemleri.Name = "btnKlasorIslemleri";
            btnKlasorIslemleri.Size = new Size(146, 29);
            btnKlasorIslemleri.TabIndex = 2;
            btnKlasorIslemleri.Text = "Klasör İşlemleri";
            btnKlasorIslemleri.UseVisualStyleBackColor = true;
            btnKlasorIslemleri.Click += btnKlasorIslemleri_Click;
            // 
            // btnDirectories
            // 
            btnDirectories.Location = new Point(86, 109);
            btnDirectories.Name = "btnDirectories";
            btnDirectories.Size = new Size(146, 29);
            btnDirectories.TabIndex = 3;
            btnDirectories.Text = "Klasör Listesi";
            btnDirectories.UseVisualStyleBackColor = true;
            btnDirectories.Click += btnDirectories_Click;
            // 
            // btnFiles
            // 
            btnFiles.Location = new Point(345, 109);
            btnFiles.Name = "btnFiles";
            btnFiles.Size = new Size(146, 29);
            btnFiles.TabIndex = 4;
            btnFiles.Text = "Dosya Listesi";
            btnFiles.UseVisualStyleBackColor = true;
            btnFiles.Click += btnFiles_Click;
            // 
            // lstDirectories
            // 
            lstDirectories.FormattingEnabled = true;
            lstDirectories.ItemHeight = 20;
            lstDirectories.Location = new Point(72, 161);
            lstDirectories.Name = "lstDirectories";
            lstDirectories.Size = new Size(216, 284);
            lstDirectories.TabIndex = 5;
            // 
            // lstFiles
            // 
            lstFiles.FormattingEnabled = true;
            lstFiles.ItemHeight = 20;
            lstFiles.Location = new Point(316, 161);
            lstFiles.Name = "lstFiles";
            lstFiles.Size = new Size(216, 284);
            lstFiles.TabIndex = 6;
            // 
            // btnDosyaKopyala
            // 
            btnDosyaKopyala.Location = new Point(593, 109);
            btnDosyaKopyala.Name = "btnDosyaKopyala";
            btnDosyaKopyala.Size = new Size(146, 29);
            btnDosyaKopyala.TabIndex = 7;
            btnDosyaKopyala.Text = "Dosya Kopyala";
            btnDosyaKopyala.UseVisualStyleBackColor = true;
            btnDosyaKopyala.Click += btnDosyaKopyala_Click;
            // 
            // btnKlasorKopyala
            // 
            btnKlasorKopyala.Location = new Point(593, 173);
            btnKlasorKopyala.Name = "btnKlasorKopyala";
            btnKlasorKopyala.Size = new Size(146, 29);
            btnKlasorKopyala.TabIndex = 8;
            btnKlasorKopyala.Text = "Klasör Kopyalar";
            btnKlasorKopyala.UseVisualStyleBackColor = true;
            btnKlasorKopyala.Click += btnKlasorKopyala_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnKlasorKopyala);
            Controls.Add(btnDosyaKopyala);
            Controls.Add(lstFiles);
            Controls.Add(lstDirectories);
            Controls.Add(btnFiles);
            Controls.Add(btnDirectories);
            Controls.Add(btnKlasorIslemleri);
            Controls.Add(btnDirectory);
            Controls.Add(btnDriveInfo);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnDriveInfo;
        private Button btnDirectory;
        private Button btnKlasorIslemleri;
        private Button btnDirectories;
        private Button btnFiles;
        private ListBox lstDirectories;
        private ListBox lstFiles;
        private Button btnDosyaKopyala;
        private Button btnKlasorKopyala;
    }
}