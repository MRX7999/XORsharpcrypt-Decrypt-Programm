using System;
using System.Windows.Forms;


namespace RubanovSigXORCRY
{
    public partial class Form1 : Form
    {
        public Form1()
        {
   
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            Encrypt.Text = Cipher(text.Text, textBox2.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Encrypt.Text = Cipher(Encrypt.Text, textBox2.Text);
        }



        private string GetRepeatKey(string s, int n)
        {
            var r = s;
            while (r.Length < n)
            {
                r += r;
            }

            return r.Substring(0, n);
        }
        private string GetRandomKey(int k, int len)
        {
            var gamma = string.Empty;
            var rnd = new Random(k);
            for (var i = 0; i < len; i++)
            {
                gamma += ((char)rnd.Next(35, 126)).ToString();
            }

            return gamma;
        }

        private string Cipher(string text, string secretKey)
        {
            var res = string.Empty;
            for (var i = 0; i < text.Length; i++)
            {
                res += ((char)(text[i] ^ GetRepeatKey(secretKey, text.Length)[i])).ToString();
            }

            return res;
        }
             private void text_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Encrypt_TextChanged(object sender, EventArgs e)
        {

        }
    }



    }

