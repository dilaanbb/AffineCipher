using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AffineCipher
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSifrele_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(txtA.Text);
            int b = Convert.ToInt32(txtB.Text);

            string kMetin = txtSifrelenecek.Text.ToLower();
            txtKckSifrelenecek.Text = kMetin;

            for (int i = 0; i < txtKckSifrelenecek.TextLength; i++)
            {
                int asciiDegeri = txtKckSifrelenecek.Text[i] - 96;
                int y = (a * asciiDegeri) + b;

                while (y > 26)
                {
                    y = y % 26;
                }

                char sifrelenmisHarf = (char)(y + 96);
                txtSifrelenmis.Text += sifrelenmisHarf;





            }


        }

        private void btnDeSifrele_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(txtA.Text);
            int b = Convert.ToInt32(txtB.Text);

            string kMetin = txtSifrelenecek.Text.ToLower();
            txtKckSifrelenecek.Text = kMetin;

            for( int t=0; t < txtSifrelenmis.TextLength; t++)
            {
                int y = txtSifrelenmis.Text[t] - 96;
                int x = (y - b);

                while (x%a != 0)
                {
                    x = x + 26;
                }

                x = x / a;

                char sifreliHarf = (char)(x + 96);
                txtDeSifrelenmis.Text += sifreliHarf;
            }



        }
    }
}
