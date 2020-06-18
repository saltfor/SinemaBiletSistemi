using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace sinema_otomasyonu
{
    public partial class FormPerde : Form
    {
        public FormPerde()
        {
            InitializeComponent();
        }
        public string filmadi;
        public string izlemetarihi;
        public string seans;
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            FormBilet frmbilet = new FormBilet();
            frmbilet.filmadi = filmadi;
            frmbilet.izlemetarihi = izlemetarihi;
            frmbilet.seans = seans;
            frmbilet.basılı = "kisibilet";
            frmbilet.ShowDialog();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            FormFiyatHesapla frmfiyathesapla = new FormFiyatHesapla();
            frmfiyathesapla.ShowDialog();
        }

        private void Koltuk_Butonları_Kisi_Bilet(object sender, EventArgs e)
        {
            if ((sender as Button).BackColor==Color.LightGreen)
            {
                FormBilet frmbilet = new FormBilet();
                frmbilet.filmadi = filmadi;
                frmbilet.izlemetarihi = izlemetarihi;
                frmbilet.seans = seans;
                frmbilet.txtadsoyad.Text = (sender as Button).Text;
                frmbilet.combosira.SelectedItem = (sender as Button).Text.Substring(0, 1);
                frmbilet.combokoltuk.SelectedItem = (sender as Button).Text.Substring(1);
                frmbilet.basılı = "koltukbutonu";
                frmbilet.ShowDialog();
            }
            else
            {
                MessageBox.Show("Seçtiğiniz yer doludur !!!","UYARI",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            DialogResult cevap = new DialogResult();
            cevap = MessageBox.Show("Perde Kapatılacak.Onaylıyor musunuz ?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cevap == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void FormPerde_Load(object sender, EventArgs e)
        {
            DialogResult cevap = new DialogResult();
            cevap = MessageBox.Show("Film Adı : "+filmadi+"\nİzleme Tarihi : "+izlemetarihi+"\nSeans : "+seans+"\n\nSeans başlatılıyor.Seans bilgilerini onaylıyor musunuz ?","Seans Bilgileri",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (cevap == DialogResult.No)
            {
                this.Close();
                FormFilmBaslat frmfilmbaslat = new FormFilmBaslat();
                frmfilmbaslat.ShowDialog();
            }
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            FormFilmEkle frmfilmekle = new FormFilmEkle();
            frmfilmekle.ShowDialog();
        }
        

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            DialogResult cevap = new DialogResult();
            cevap = MessageBox.Show("Program kapatılacak.Onaylıyor musunuz ?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cevap == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        private void Menu_Iconları_Ustune_Gelme(object sender, EventArgs e)
        {
            (sender as PictureBox).Padding = new Padding(5,5,5,5);
        }
        private void Menu_Iconları_Ustunden_Cekilme(object sender, EventArgs e)
        {

        }
    }
}
