using System;
using System.Data.OleDb;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace sinema_otomasyonu
{
    public partial class FormBilet : Form
    {
        public FormBilet()
        {
            InitializeComponent();
        }
        public string adsoyad;
        public string sira;
        public string koltuk;
        public string sirakoltuk;
        public string filmadi;
        public string izlemetarihi;
        public string seans;
        public string basılı;
        int toplamtutar;
        public bool komut;

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form1 frmanaekran = new Form1();
            FormPerde frmperde=new FormPerde();
            if (txtadsoyad.Text != "" && combosira.Text != "" && combokoltuk.Text != "" && (radioButton1.Checked==true || radioButton2.Checked==true))
            {
                komut = true;
                adsoyad = txtadsoyad.Text;
                sira = combosira.Text;
                koltuk = combokoltuk.Text;
                sirakoltuk = string.Concat(sira, koltuk);
                if (sirakoltuk==adsoyad)
                {
                    MessageBox.Show("Ad Soyad bölümü doğru olmalıdır !!!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else
                {
                    Koltuklar bul = new Koltuklar();
                    bul.İslemler(adsoyad, sirakoltuk);
                    komut = bul.komut;
                    if (komut == true)
                    {
                        frmanaekran.baglanti.Open();
                        frmanaekran.komut = new OleDbCommand("insert into kayitbilgi(adsoyad,koltuk,tarih,film,izlemetarihi,seans) values('" + adsoyad + "','" + sirakoltuk + "','" + DateTime.Now.ToLongDateString() + "  " + DateTime.Now.ToLongTimeString() + "','" + filmadi + "','" + izlemetarihi + "','" + seans + "')", frmanaekran.baglanti);
                        frmanaekran.komut.ExecuteNonQuery();
                        frmanaekran.komut.Dispose();
                        if (radioButton1.Checked==true)
                        {
                            toplamtutar += 10;
                        }
                        if (radioButton2.Checked==true)
                        {
                            toplamtutar += 8;
                        }
                        frmanaekran.adaptor.Dispose();
                        frmanaekran.adaptor = new OleDbDataAdapter("select * from gise", frmanaekran.baglanti);
                        frmanaekran.adaptor.Fill(frmanaekran.ds, "gise_tablo");
                        frmanaekran.komut = new OleDbCommand("update gise set izlenmesayisi='" + (Convert.ToInt32(frmanaekran.ds.Tables["gise_tablo"].Rows[0]["izlenmesayisi"]) + 1) + "',toplamkazanc='" + (Convert.ToInt32(frmanaekran.ds.Tables["gise_tablo"].Rows[0]["toplamkazanc"]) + toplamtutar) + "' where filmadi='" + filmadi + "'", frmanaekran.baglanti);
                        frmanaekran.komut.ExecuteNonQuery();
                        frmanaekran.baglanti.Close();
                    }
                    else
                    {
                        MessageBox.Show("Seçtiğiniz yer doludur.Lütfen farklı bir yer seçiniz !!!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    if (basılı == "koltukbutonu")
                    {
                        this.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("Lütfen istenen bilgileri doldurunuz !!!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        void sıralama()
        {
            Koltuk_No combokoltuk = new Koltuk_No();
            string gonderilecek = combosira.SelectedItem.ToString();
            combokoltuk.Koltuk_Combo_Ekle(gonderilecek);
        }

        private void combosira_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (basılı == "kisibilet")
            {
                sıralama(); 
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtadsoyad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) == false && e.KeyChar != (char)08)
            {
                e.Handled = true;
            }
        }

        private void FormBilet_Load(object sender, EventArgs e)
        {
            FormFilmBaslat frmfilmbaslat = new FormFilmBaslat();
            Form1 frmanaekran = new Form1();
            if (basılı=="kisibilet")
            {
                combokoltuk.Items.Clear();
            }
            if (basılı=="koltukbutonu")
            {
                combosira.Enabled = false;
                combokoltuk.Enabled = false;
            }
            if (frmfilmbaslat.comboBox3.SelectedIndex == 0)
            {
                seans = (frmanaekran.ds.Tables["filmler"].Rows[0]["seans1"].ToString());
            }
            else if (frmfilmbaslat.comboBox3.SelectedIndex == 1)
            {
                seans = (frmanaekran.ds.Tables["filmler"].Rows[0]["seans2"].ToString());
            }
            else if (frmfilmbaslat.comboBox3.SelectedIndex == 2)
            {
                seans = (frmanaekran.ds.Tables["filmler"].Rows[0]["seans3"].ToString());
            }
            else if (frmfilmbaslat.comboBox3.SelectedIndex == 3)
            {
                seans = (frmanaekran.ds.Tables["filmler"].Rows[0]["seans4"].ToString());
            }
        }
    }
}
