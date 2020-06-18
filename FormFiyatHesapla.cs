using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace sinema_otomasyonu
{
    public partial class FormFiyatHesapla : Form
    {
        public FormFiyatHesapla()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "0" || textBox2.Text != "0")
            {
                int tambilet = int.Parse(textBox1.Text);
                int ogrencibilet = int.Parse(textBox2.Text);
                int toplamtutar = 0;
                tambilet = tambilet * 10;
                if (ogrencibilet >= 5)
                {
                    ogrencibilet = (ogrencibilet - (ogrencibilet / 5)) * 8;
                }
                else
                {
                    ogrencibilet = ogrencibilet * 8;
                }
                toplamtutar = tambilet + ogrencibilet;
                label5.Text = "Toplam Tutar : " + toplamtutar.ToString() + " TL";
            }
            else
            {
                MessageBox.Show("Bilet sayısı girmediniz !", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.SelectAll();
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            textBox2.SelectAll();
        }
    }
}
