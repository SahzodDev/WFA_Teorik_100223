namespace WFA_Teorik_100223
{
    partial class Form1
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
            txtFilePath = new TextBox();
            btnFileSelect = new Button();
            ofdFile = new OpenFileDialog();
            btnWriteFile = new Button();
            btnReadFile = new Button();
            rtxFileContent = new RichTextBox();
            SuspendLayout();
            // 
            // txtFilePath
            // 
            txtFilePath.Location = new Point(12, 12);
            txtFilePath.Name = "txtFilePath";
            txtFilePath.Size = new Size(527, 27);
            txtFilePath.TabIndex = 0;
            // 
            // btnFileSelect
            // 
            btnFileSelect.Location = new Point(554, 10);
            btnFileSelect.Name = "btnFileSelect";
            btnFileSelect.Size = new Size(94, 29);
            btnFileSelect.TabIndex = 1;
            btnFileSelect.Text = "...";
            btnFileSelect.UseVisualStyleBackColor = true;
            btnFileSelect.Click += btnFileSelect_Click;
            // 
            // ofdFile
            // 
            ofdFile.FileName = "openFileDialog1";
            ofdFile.Filter = "Text Dosyası(*.txt)|*.txt|Winrar Dosyaları(*.rar)|*.rar|Tüm Dosyalar(*.*)|*.*";
            // 
            // btnWriteFile
            // 
            btnWriteFile.Location = new Point(155, 81);
            btnWriteFile.Name = "btnWriteFile";
            btnWriteFile.Size = new Size(132, 29);
            btnWriteFile.TabIndex = 2;
            btnWriteFile.Text = "Dosyaya Yaz";
            btnWriteFile.UseVisualStyleBackColor = true;
            btnWriteFile.Click += btnWriteFile_Click;
            // 
            // btnReadFile
            // 
            btnReadFile.Location = new Point(328, 81);
            btnReadFile.Name = "btnReadFile";
            btnReadFile.Size = new Size(134, 29);
            btnReadFile.TabIndex = 3;
            btnReadFile.Text = "Dosyadan Oku";
            btnReadFile.UseVisualStyleBackColor = true;
            btnReadFile.Click += btnReadFile_Click;
            // 
            // rtxFileContent
            // 
            rtxFileContent.Location = new Point(12, 121);
            rtxFileContent.Name = "rtxFileContent";
            rtxFileContent.Size = new Size(639, 317);
            rtxFileContent.TabIndex = 4;
            rtxFileContent.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(663, 450);
            Controls.Add(rtxFileContent);
            Controls.Add(btnReadFile);
            Controls.Add(btnWriteFile);
            Controls.Add(btnFileSelect);
            Controls.Add(txtFilePath);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtFilePath;
        private Button btnFileSelect;
        private OpenFileDialog ofdFile;
        private Button btnWriteFile;
        private Button btnReadFile;
        private RichTextBox rtxFileContent;
    }
}