namespace WFA_Teorik_100223
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // File Stream

        // FileStream s�n�f� ile diskte bulunan bir dosyaya ula��m sa�layabiliriz. StreamWriter ve StreamReader ile a�u�lan bir dosya �zerinde yazma ve okuma i�lemleri de yap�labilir.

        // Dosya �zerinde metin tabanl� ya da byte table tabanl� i�lemler yap�labilir. 

        // Read() ya da ReadByte() metodlar� byte d�zeyinde veri okumam�z� sa�layan metodlard�r.

        // ReadByte() okuma yapamaz ise -1 d�nd�r�r.

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