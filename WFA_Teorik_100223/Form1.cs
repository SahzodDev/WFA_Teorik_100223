namespace WFA_Teorik_100223
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // File Stream

        // FileStream sýnýfý ile diskte bulunan bir dosyaya ulaþým saðlayabiliriz. StreamWriter ve StreamReader ile açuýlan bir dosya üzerinde yazma ve okuma iþlemleri de yapýlabilir.

        // Dosya üzerinde metin tabanlý ya da byte table tabanlý iþlemler yapýlabilir. 

        // Read() ya da ReadByte() metodlarý byte düzeyinde veri okumamýzý saðlayan metodlardýr.

        // ReadByte() okuma yapamaz ise -1 döndürür.

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnFileSelect_Click(object sender, EventArgs e)
        {
            DialogResult result = ofdFile.ShowDialog();
            if (result == DialogResult.OK)
            {
                txtFilePath.Text = ofdFile.FileName;
            }

        }

        private void btnReadFile_Click(object sender, EventArgs e)
        {
            StreamReader strRead = new StreamReader(txtFilePath.Text);

            string str = strRead.ReadToEnd();

            rtxFileContent.Text = str;

            strRead.Close();

        }

        private void btnWriteFile_Click(object sender, EventArgs e)
        {
            StreamWriter strWrite = new StreamWriter(txtFilePath.Text);

            strWrite.Write(rtxFileContent.Text);

            strWrite.Close();

            rtxFileContent.Clear();
        }
    }
}