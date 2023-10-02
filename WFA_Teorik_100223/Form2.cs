using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace WFA_Teorik_100223
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btnDriveInfo_Click(object sender, EventArgs e)
        {
            // DriveInfo di = new DriveInfo(@"C:\");
            DriveInfo di = new DriveInfo("C:\\");

            string driveInfo = string.Empty;
            driveInfo = $"Sürücü Adı : {di.Name}\n" + $"Sürücü Ön Adı : {di.VolumeLabel}\n" + $"Toplam Boyut : {di.TotalSize}\n" + $"Kullanılabilir Boş Alan : {di.AvailableFreeSpace}";

            MessageBox.Show(driveInfo);
        }

        private void btnDirectory_Click(object sender, EventArgs e)
        {
            DirectoryInfo dirInfo = new DirectoryInfo("C:\\Users\\Shohzod\\Desktop\\Throttlestop");

            string directoryInfo = string.Empty;

            directoryInfo = $"Klasörün Yolu : {dirInfo.FullName}\n" + $"Klasör Adı : {dirInfo.Name}\n" + $"Bir Üstündeki Klasör Adı : {dirInfo.Parent}\n" + $"Dosya Türü : {dirInfo.Attributes}\n" + $"Son Deüiştirilme Tarihi : {dirInfo.LastWriteTime}\n";

            MessageBox.Show(directoryInfo);
        }

        private void btnKlasorIslemleri_Click(object sender, EventArgs e)
        {
            if (Directory.Exists("C:\\Users\\Shohzod\\Desktop\\FileStream"))
            {
                Directory.Delete("C:\\Users\\Shohzod\\Desktop\\FileStream");
            }
            Directory.CreateDirectory("C:\\Users\\Shohzod\\Desktop\\FileStream");
        }

        private void btnDirectories_Click(object sender, EventArgs e)
        {
            string[] directories = Directory.GetDirectories("D:\\Diablo IV");
            foreach (string directory in directories)
            {
                lstDirectories.Items.Add(directory);
            }
        }

        private void btnFiles_Click(object sender, EventArgs e)
        {
            string[] files = Directory.GetFiles("D:\\Diablo IV");
            lstFiles.Items.Clear();
            foreach (string file in files)
            {
                string fileInfo = string.Empty;

                FileInfo fi = new FileInfo(file);

                fileInfo = $"{fi.FullName} - {fi.Name} - {fi.Length} Byte - {fi.CreationTime}";

                lstFiles.Items.Add(fileInfo);
            }
        }

        private void btnDosyaKopyala_Click(object sender, EventArgs e)
        {
            string sourceFile = "C:\\Users\\Shohzod\\Desktop\\Harvard CS50\\lecture0.pdf";
            string desinationFile = "C:\\Users\\Shohzod\\Desktop\\Bilge Adam Eğitim\\New Sample Text Document.txt";
            File.Move(sourceFile, desinationFile);
        }

        private void btnKlasorKopyala_Click(object sender, EventArgs e)
        {
            string sourceDir = "C:\\Users\\Shohzod\\Desktop\\Throttlestop";
            string destinationDir = "C:\\Users\\Shohzod\\Desktop\\FileStream\\New Folder";

            Directory.Move(sourceDir, destinationDir);
        }
    }
}
