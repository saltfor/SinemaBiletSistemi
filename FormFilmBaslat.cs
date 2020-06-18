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
    public partial class FormFilmBaslat : Form
    {
        public FormFilmBaslat()
        {
            InitializeComponent();
        }
        string filmadi;
        string izlemetarihi;
        string seans;
        bool baslatma = false;

        private void button1_Click(object sender, EventArgs e)
        {
            FormBilet frmbilet = new FormBilet();
            FormPerde frmperde = new FormPerde();
            Form1 frmanaekran = new Form1();
            
            if (baslatma==true)
            {
                filmadi = comboBox1.Text;
                izlemetarihi = comboBox2.Text;
                seans = comboBox3.Text;
                frmperde.filmadi = filmadi;
                frmperde.izlemetarihi = izlemetarihi;
                frmperde.seans = seans;
                frmanaekran.adaptor = new OleDbDataAdapter("select * from filmler where filmadi='" + filmadi + "'", frmanaekran.baglanti);
                frmanaekran.adaptor.Fill(frmanaekran.ds, "filmler");
                frmperde.pictureBox1.ImageLocation = (frmanaekran.ds.Tables["filmler"].Rows[0]["afis"].ToString());
                frmanaekran.Hide();
                this.Hide();
                frmperde.ShowDialog();
            }
            else
            {
                MessageBox.Show("Seans başlatılamıyor.Lütfen girdiğiniz bilgileri kontrol ediniz !","HATA",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            
        }

        private void FormFilmBaslat_Load(object sender, EventArgs e)
        {
            Form1 frmanaekran = new Form1();
            frmanaekran.baglanti.Open();
            frmanaekran.adaptor = new OleDbDataAdapter("select filmadi from filmler", frmanaekran.baglanti);
            frmanaekran.adaptor.Fill(frmanaekran.ds, "filmler");
            for (int i = 0; i < frmanaekran.ds.Tables["filmler"].Rows.Count; i++)
            {
                comboBox1.Items.Add(frmanaekran.ds.Tables["filmler"].Rows[i]["filmadi"].ToString());
            }
            frmanaekran.adaptor.Dispose();
            frmanaekran.baglanti.Close();
            filmadi = "";
            izlemetarihi = "";
            seans = "";
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            comboBox3.Items.Clear();
            Form1 frmanaekran = new Form1();
            frmanaekran.baglanti.Open();
            frmanaekran.ds.Clear();
            string filmadi = comboBox1.Text;
            frmanaekran.adaptor = new OleDbDataAdapter("select * from filmler where filmadi='" + filmadi + "'", frmanaekran.baglanti);
            frmanaekran.adaptor.Fill(frmanaekran.ds, "filmler");
            comboBox2.Items.Clear();
            DateTime vizyontarihi = Convert.ToDateTime(frmanaekran.ds.Tables["filmler"].Rows[0]["vizyontarihi"].ToString());
            DateTime bitistarihi = vizyontarihi.AddDays(14);
            if (vizyontarihi>DateTime.Today)
            {
                MessageBox.Show("Bu film henüz vizyona girmemiştir...","UYARI",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                comboBox2.Items.Clear();
                comboBox3.Items.Clear();
                comboBox2.Items.Add("Henüz vizyonda değil !");
                comboBox3.Items.Add("Henüz vizyonda değil !");
                comboBox2.SelectedIndex = 0;
                comboBox3.SelectedIndex = 0;
                baslatma = false;
            }
            else
            {
                TimeSpan kalangun = bitistarihi - DateTime.Today;
                for (int i = 0; i < kalangun.TotalDays; i++)
                {
                    comboBox2.Items.Add(DateTime.Today.AddDays(i).ToLongDateString());
                }
                comboBox3.Items.Clear();
                comboBox3.Items.Add(frmanaekran.ds.Tables["filmler"].Rows[0]["seans1"].ToString());
                comboBox3.Items.Add(frmanaekran.ds.Tables["filmler"].Rows[0]["seans2"].ToString());
                comboBox3.Items.Add(frmanaekran.ds.Tables["filmler"].Rows[0]["seans3"].ToString());
                comboBox3.Items.Add(frmanaekran.ds.Tables["filmler"].Rows[0]["seans4"].ToString());
                frmanaekran.baglanti.Close();
                baslatma = true;
            }
            
        }
    }
}
