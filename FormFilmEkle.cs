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
    public partial class FormFilmEkle : Form
    {
        public FormFilmEkle()
        {
            InitializeComponent();
        }
        Form1 frmanaekran = new Form1();

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            string durum;
            durum = "";
            if (pictureBox1.ImageLocation != null && textBox1.Text != "" && textseans1.Text != "" && textseans2.Text != "" && textseans3.Text != "" && textseans4.Text != "")
            {
                DateTime vizyontarihi = Convert.ToDateTime(dateTimePicker1.Text);
                if (vizyontarihi<DateTime.Today)
                {
                    MessageBox.Show("Vizyon tarihi geçmiş film ekleyemezsiniz !!!","HATA",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
                else
                {
                    frmanaekran.baglanti.Open();
                    frmanaekran.adaptor = new OleDbDataAdapter("select seans1 from filmler where seans1='"+textseans1.Text+"'",frmanaekran.baglanti);
                    frmanaekran.adaptor.Fill(frmanaekran.ds,"hataseans1");
                    if (frmanaekran.ds.Tables["hataseans1"].Rows.Count>0)
                    {
                        MessageBox.Show("Eklediğiniz filmin Seans1'i başka bir filmin seansıyla çakışıyor.");
                        frmanaekran.ds.Tables["hataseans1"].Clear();
                        durum = "hataseans1";
                        frmanaekran.baglanti.Close();
                        goto git;
                    }
                    frmanaekran.adaptor = new OleDbDataAdapter("select seans2 from filmler where seans2='" + textseans2.Text + "'", frmanaekran.baglanti);
                    frmanaekran.adaptor.Fill(frmanaekran.ds, "hataseans2");
                    if (frmanaekran.ds.Tables["hataseans2"].Rows.Count>0)
                    {
                        MessageBox.Show("Eklediğiniz filmin Seans2'si başka bir filmin seansıyla çakışıyor.");
                        frmanaekran.ds.Tables["hataseans2"].Clear();
                        durum = "hataseans2";
                        frmanaekran.baglanti.Close();
                        goto git;
                    }
                    frmanaekran.adaptor = new OleDbDataAdapter("select seans3 from filmler where seans3='" + textseans3.Text + "'", frmanaekran.baglanti);
                    frmanaekran.adaptor.Fill(frmanaekran.ds, "hataseans3");
                    if (frmanaekran.ds.Tables["hataseans3"].Rows.Count > 0)
                    {
                        MessageBox.Show("Eklediğiniz filmin Seans3'ü başka bir filmin seansıyla çakışıyor.");
                        frmanaekran.ds.Tables["hataseans3"].Clear();
                        durum = "hataseans3";
                        frmanaekran.baglanti.Close();
                        goto git;
                    }
                    frmanaekran.adaptor = new OleDbDataAdapter("select seans4 from filmler where seans4='" + textseans4.Text + "'", frmanaekran.baglanti);
                    frmanaekran.adaptor.Fill(frmanaekran.ds, "hataseans4");
                    if (frmanaekran.ds.Tables["hataseans4"].Rows.Count > 0)
                    {
                        MessageBox.Show("Eklediğiniz filmin Seans4'ü başka bir filmin seansıyla çakışıyor.");
                        frmanaekran.ds.Tables["hataseans4"].Clear();
                        durum = "hataseans4";
                        frmanaekran.baglanti.Close();
                        goto git;
                    }
                    frmanaekran.baglanti.Close();
                    pictureBox1.Image.Save(textBox1.Text + ".jpg");
                    string afisismi = textBox1.Text + ".jpg";
                    frmanaekran.baglanti.Open();
                    frmanaekran.komut = new OleDbCommand("insert into filmler(filmadi,afis,vizyontarihi,seans1,seans2,seans3,seans4) values('" + textBox1.Text + "','" + afisismi + "','" + dateTimePicker1.Text + "','" + textseans1.Text + "','" + textseans2.Text + "','" + textseans3.Text + "','" + textseans4.Text + "')", frmanaekran.baglanti);
                    frmanaekran.komut.ExecuteNonQuery();
                    frmanaekran.komut.Dispose();
                    frmanaekran.komut = new OleDbCommand("insert into gise(filmadi) values('"+textBox1.Text+"')",frmanaekran.baglanti);
                    frmanaekran.komut.ExecuteNonQuery();
                    frmanaekran.komut.Dispose();
                    frmanaekran.baglanti.Close();
                    MessageBox.Show("Film Ekleme Başarılı", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBox1.Text = "";
                    textseans1.Text = "";
                    textseans2.Text = "";
                    textseans3.Text = "";
                    textseans4.Text = "";
                    dateTimePicker1.Text = "";
                    pictureBox1.ImageLocation = null;
                    this.Width = 267;
                git:
                    if (durum=="hataseans1")
	                {
		               textseans1.Text="";
	                }
                    else if(durum=="hataseans2")
                    {
                        textseans2.Text="";
                    }
                    else if (durum == "hataseans3")
                    {
                        textseans3.Text = "";
                    }
                    else if (durum == "hataseans4")
                    {
                        textseans4.Text = "";
                    }
                }
            }
            else
            {
                MessageBox.Show("Lütfen istenilen tüm alanları doldurunuz !!!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Resim Dosyaları|*.jpg;*.png";
            openFileDialog1.ShowDialog();
            string secilen = openFileDialog1.FileName;
            if (secilen!="openFileDialog1")
            {
                pictureBox1.ImageLocation = secilen;
                this.Width = 441;
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
