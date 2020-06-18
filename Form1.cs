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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public OleDbConnection baglanti = new OleDbConnection("provider=microsoft.ace.oledb.12.0;data source=veritabani.accdb");
        public OleDbDataAdapter adaptor = new OleDbDataAdapter();
        public DataSet ds = new DataSet();
        public OleDbCommand komut = new OleDbCommand();

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FormFilmBaslat frmfilmbaslat = new FormFilmBaslat();
            frmfilmbaslat.ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            FormFilmEkle frmfilmekle = new FormFilmEkle();
            frmfilmekle.ShowDialog();
        }
        
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            DialogResult cevap = new DialogResult();
            cevap = MessageBox.Show("Program kapatılacak.Onaylıyor musunuz ?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cevap == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            adaptor = new OleDbDataAdapter("select filmadi,vizyontarihi,seans1,seans2,seans3,seans4 from filmler", baglanti);
            adaptor.Fill(ds, "filmler");
            for (int i = 0; i < ds.Tables["filmler"].Rows.Count; i++)
            {
                DateTime vizyontarihi = Convert.ToDateTime(ds.Tables["filmler"].Rows[i]["vizyontarihi"].ToString());
                DateTime bitistarihi = vizyontarihi.AddDays(14);
                TimeSpan kalangun = bitistarihi - DateTime.Today;
                if (kalangun.TotalDays < 1)
                {
                    komut = new OleDbCommand("delete from filmler where vizyontarihi=@kosul", baglanti);
                    komut.Parameters.AddWithValue("@kosul",ds.Tables["filmler"].Rows[i]["vizyontarihi"]);
                    komut.ExecuteNonQuery();
                    komut.Dispose();
                }
            }
            baglanti.Close();
        }
    }
}
