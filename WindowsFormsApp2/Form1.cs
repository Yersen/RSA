using System;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        UnicodeEncoding ByteConverter = new UnicodeEncoding();
        RSACryptoServiceProvider RSA1 = new RSACryptoServiceProvider();
        byte[] plaintext;
        byte[] encryptedtext;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            plaintext = ByteConverter.GetBytes(textBox1.Text);
            encryptedtext = RSACip.Encryption(plaintext, RSA1.ExportParameters(false), false);
            textBox2.Text = ByteConverter.GetString(encryptedtext);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            byte[] decryptedtex = RSACip.Decryption(encryptedtext, RSA1.ExportParameters(true), false);
            textBox3.Text = ByteConverter.GetString(decryptedtex);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
