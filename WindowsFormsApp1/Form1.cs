using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace RSACipher
{
    public partial class RSA : Form
    {
        UnicodeEncoding ByteConverter = new UnicodeEncoding();
        RSACryptoServiceProvider RSA1 = new RSACryptoServiceProvider();
        byte[] plaintext;
        byte[] encryptedtext;

        public RSA()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void RSA_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            plaintext = ByteConverter.GetBytes(listBox1.Text);
            encryptedtext = RSACipher.Encryption(plaintext, RSA1.ExportParameters(false), false);
            listBox1.Text = ByteConverter.GetString(encryptedtext);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            byte[] decryptedtex = RSACipher.Decryption(encryptedtext,RSA1.ExportParameters(true), false);
            listBox2.Text = ByteConverter.GetString(decryptedtex);
        }
    }
}
