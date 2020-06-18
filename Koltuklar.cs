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
    class Koltuklar
    {
        FormPerde frmperde = new FormPerde();
        FormBilet frmbilet = new FormBilet();
        public bool komut;
        public void İslemler(string adsoyad, string sirakoltuk)
        {
            foreach (Form forms in Application.OpenForms)
            {
                if (forms.Name == "FormPerde")
                {
                    komut = true;
                    FormPerde frmperde = (FormPerde)forms;
                    switch (sirakoltuk)
                    {
                        case "A1":
                            if (frmperde.btnA1.Text != "A1")
                            {
                                komut = false;
                            }
                            else
                            {
                                frmperde.btnA1.Text = adsoyad;
                                frmperde.btnA1.BackColor = Color.Red;
                                frmperde.btnA1.Tag = "Dolu";
                            }
                            break;
                        case "A2":
                            if (frmperde.btnA2.Text != "A2")
                            {
                                komut = false;
                            }
                            else
                            {
                                frmperde.btnA2.Text = adsoyad;
                                frmperde.btnA2.BackColor = Color.Red;
                                frmperde.btnA2.Tag = "Dolu";
                            }
                            break;
                        case "A3":
                            if (frmperde.btnA3.Text != "A3")
                            {
                                komut = false;
                            }
                            else
                            {
                                frmperde.btnA3.Text = adsoyad;
                                frmperde.btnA3.BackColor = Color.Red;
                                frmperde.btnA3.Tag = "Dolu";
                            }
                            break;
                        case "A4":
                            if (frmperde.btnA4.Text != "A4")
                            {
                                komut = false;
                            }
                            else
                            {
                                frmperde.btnA4.Text = adsoyad;
                                frmperde.btnA4.BackColor = Color.Red;
                                frmperde.btnA4.Tag = "Dolu";
                            }
                            break;
                        case "A5":
                            if (frmperde.btnA5.Text != "A5")
                            {
                                komut = false;
                            }
                            else
                            {
                                frmperde.btnA5.Text = adsoyad;
                                frmperde.btnA5.BackColor = Color.Red;
                                frmperde.btnA5.Tag = "Dolu";
                            }
                            break;
                        case "B1":
                            if (frmperde.btnB1.Text != "B1")
                            {
                                komut = false;
                            }
                            else
                            {
                                frmperde.btnB1.Text = adsoyad;
                                frmperde.btnB1.BackColor = Color.Red;
                                frmperde.btnB1.Tag = "Dolu";
                            }
                            break;
                        case "B2":
                            if (frmperde.btnB2.Text != "B2")
                            {
                                komut = false;
                            }
                            else
                            {
                                frmperde.btnB2.Text = adsoyad;
                                frmperde.btnB2.BackColor = Color.Red;
                                frmperde.btnB2.Tag = "Dolu";
                            }
                            break;
                        case "B3":
                            if (frmperde.btnB3.Text != "B3")
                            {
                                komut = false;
                            }
                            else
                            {
                                frmperde.btnB3.Text = adsoyad;
                                frmperde.btnB3.BackColor = Color.Red;
                                frmperde.btnB3.Tag = "Dolu";
                            }
                            break;
                        case "B4":
                            if (frmperde.btnB4.Text != "B4")
                            {
                                komut = false;
                            }
                            else
                            {
                                frmperde.btnB4.Text = adsoyad;
                                frmperde.btnB4.BackColor = Color.Red;
                                frmperde.btnB4.Tag = "Dolu";
                            }
                            break;
                        case "B5":
                            if (frmperde.btnB5.Text != "B5")
                            {
                                komut = false;
                            }
                            else
                            {
                                frmperde.btnB5.Text = adsoyad;
                                frmperde.btnB5.BackColor = Color.Red;
                                frmperde.btnB5.Tag = "Dolu";
                            }
                            break;
                        case "B6":
                            if (frmperde.btnB6.Text != "B6")
                            {
                                komut = false;
                            }
                            else
                            {
                                frmperde.btnB6.Text = adsoyad;
                                frmperde.btnB6.BackColor = Color.Red;
                                frmperde.btnB6.Tag = "Dolu";
                            }
                            break;
                        case "C1":
                            if (frmperde.btnC1.Text != "C1")
                            {
                                komut = false;
                            }
                            else
                            {
                                frmperde.btnC1.Text = adsoyad;
                                frmperde.btnC1.BackColor = Color.Red;
                                frmperde.btnC1.Tag = "Dolu";
                            }
                            break;
                        case "C2":
                            if (frmperde.btnC2.Text != "C2")
                            {
                                komut = false;
                            }
                            else
                            {
                                frmperde.btnC2.Text = adsoyad;
                                frmperde.btnC2.BackColor = Color.Red;
                                frmperde.btnC2.Tag = "Dolu";
                            }
                            break;
                        case "C3":
                            if (frmperde.btnC3.Text != "C3")
                            {
                                komut = false;
                            }
                            else
                            {
                                frmperde.btnC3.Text = adsoyad;
                                frmperde.btnC3.BackColor = Color.Red;
                                frmperde.btnC3.Tag = "Dolu";
                            }
                            break;
                        case "C4":
                            if (frmperde.btnC4.Text != "C4")
                            {
                                komut = false;
                            }
                            else
                            {
                                frmperde.btnC4.Text = adsoyad;
                                frmperde.btnC4.BackColor = Color.Red;
                                frmperde.btnC4.Tag = "Dolu";
                            }
                            break;
                        case "C5":
                            if (frmperde.btnC5.Text != "C5")
                            {
                                komut = false;
                            }
                            else
                            {
                                frmperde.btnC5.Text = adsoyad;
                                frmperde.btnC5.BackColor = Color.Red;
                                frmperde.btnC5.Tag = "Dolu";
                            }
                            break;
                        case "C6":
                            if (frmperde.btnC6.Text != "C6")
                            {
                                komut = false;
                            }
                            else
                            {
                                frmperde.btnC6.Text = adsoyad;
                                frmperde.btnC6.BackColor = Color.Red;
                                frmperde.btnC6.Tag = "Dolu";
                            }
                            break;
                        case "C7":
                            if (frmperde.btnC7.Text != "C7")
                            {
                                komut = false;
                            }
                            else
                            {
                                frmperde.btnC7.Text = adsoyad;
                                frmperde.btnC7.BackColor = Color.Red;
                                frmperde.btnC7.Tag = "Dolu";
                            }
                            break;
                        case "D1":
                            if (frmperde.btnD1.Text != "D1")
                            {
                                komut = false;
                            }
                            else
                            {
                                frmperde.btnD1.Text = adsoyad;
                                frmperde.btnD1.BackColor = Color.Red;
                                frmperde.btnD1.Tag = "Dolu";
                            }
                            break;
                        case "D2":
                            if (frmperde.btnD2.Text != "D2")
                            {
                                komut = false;
                            }
                            else
                            {
                                frmperde.btnD2.Text = adsoyad;
                                frmperde.btnD2.BackColor = Color.Red;
                                frmperde.btnD2.Tag = "Dolu";
                            }
                            break;
                        case "D3":
                            if (frmperde.btnD3.Text != "D3")
                            {
                                komut = false;
                            }
                            else
                            {
                                frmperde.btnD3.Text = adsoyad;
                                frmperde.btnD3.BackColor = Color.Red;
                                frmperde.btnD3.Tag = "Dolu";
                            }
                            break;
                        case "D4":
                            if (frmperde.btnD4.Text != "D4")
                            {
                                komut = false;
                            }
                            else
                            {
                                frmperde.btnD4.Text = adsoyad;
                                frmperde.btnD4.BackColor = Color.Red;
                                frmperde.btnD4.Tag = "Dolu";
                            }
                            break;
                        case "D5":
                            if (frmperde.btnD5.Text != "D5")
                            {
                                komut = false;
                            }
                            else
                            {
                                frmperde.btnD5.Text = adsoyad;
                                frmperde.btnD5.BackColor = Color.Red;
                                frmperde.btnD5.Tag = "Dolu";
                            }
                            break;
                        case "D6":
                            if (frmperde.btnD6.Text != "D6")
                            {
                                komut = false;
                            }
                            else
                            {
                                frmperde.btnD6.Text = adsoyad;
                                frmperde.btnD6.BackColor = Color.Red;
                                frmperde.btnD6.Tag = "Dolu";
                            }
                            break;
                        case "D7":
                            if (frmperde.btnD7.Text != "D7")
                            {
                                komut = false;
                            }
                            else
                            {
                                frmperde.btnD7.Text = adsoyad;
                                frmperde.btnD7.BackColor = Color.Red;
                                frmperde.btnD7.Tag = "Dolu";
                            }
                            break;
                        case "D8":
                            if (frmperde.btnD8.Text != "D8")
                            {
                                komut = false;
                            }
                            else
                            {
                                frmperde.btnD8.Text = adsoyad;
                                frmperde.btnD8.BackColor = Color.Red;
                                frmperde.btnD8.Tag = "Dolu";
                            }
                            break;
                        case "E1":
                            if (frmperde.btnE1.Text != "E1")
                            {
                                komut = false;
                            }
                            else
                            {
                                frmperde.btnE1.Text = adsoyad;
                                frmperde.btnE1.BackColor = Color.Red;
                                frmperde.btnE1.Tag = "Dolu";
                            }
                            break;
                        case "E2":
                            if (frmperde.btnE2.Text != "E2")
                            {
                                komut = false;
                            }
                            else
                            {
                                frmperde.btnE2.Text = adsoyad;
                                frmperde.btnE2.BackColor = Color.Red;
                                frmperde.btnE2.Tag = "Dolu";
                            }
                            break;
                        case "E3":
                            if (frmperde.btnE3.Text != "E3")
                            {
                                komut = false;
                            }
                            else
                            {
                                frmperde.btnE3.Text = adsoyad;
                                frmperde.btnE3.BackColor = Color.Red;
                                frmperde.btnE3.Tag = "Dolu";
                            }
                            break;
                        case "E4":
                            if (frmperde.btnE4.Text != "E4")
                            {
                                komut = false;
                            }
                            else
                            {
                                frmperde.btnE4.Text = adsoyad;
                                frmperde.btnE4.BackColor = Color.Red;
                                frmperde.btnE4.Tag = "Dolu";
                            }
                            break;
                        case "E5":
                            if (frmperde.btnE5.Text != "E5")
                            {
                                komut = false;
                            }
                            else
                            {
                                frmperde.btnE5.Text = adsoyad;
                                frmperde.btnE5.BackColor = Color.Red;
                                frmperde.btnE5.Tag = "Dolu";
                            }
                            break;
                        case "E6":
                            if (frmperde.btnE6.Text != "E6")
                            {
                                komut = false;
                            }
                            else
                            {
                                frmperde.btnE6.Text = adsoyad;
                                frmperde.btnE6.BackColor = Color.Red;
                                frmperde.btnE6.Tag = "Dolu";
                            }
                            break;
                        case "E7":
                            if (frmperde.btnE7.Text != "E7")
                            {
                                komut = false;
                            }
                            else
                            {
                                frmperde.btnE7.Text = adsoyad;
                                frmperde.btnE7.BackColor = Color.Red;
                                frmperde.btnE7.Tag = "Dolu";
                            }
                            break;
                        case "E8":
                            if (frmperde.btnE8.Text != "E8")
                            {
                                komut = false;
                            }
                            else
                            {
                                frmperde.btnE8.Text = adsoyad;
                                frmperde.btnE8.BackColor = Color.Red;
                                frmperde.btnE8.Tag = "Dolu";
                            }
                            break;
                        case "E9":
                            if (frmperde.btnE9.Text != "E9")
                            {
                                komut = false;
                            }
                            else
                            {
                                frmperde.btnE9.Text = adsoyad;
                                frmperde.btnE9.BackColor = Color.Red;
                                frmperde.btnE9.Tag = "Dolu";
                            }
                            break;
                        case "F1":
                            if (frmperde.btnF1.Text != "F1")
                            {
                                komut = false;
                            }
                            else
                            {
                                frmperde.btnF1.Text = adsoyad;
                                frmperde.btnF1.BackColor = Color.Red;
                                frmperde.btnF1.Tag = "Dolu";
                            }
                            break;
                        case "F2":
                            if (frmperde.btnF2.Text != "F2")
                            {
                                komut = false;
                            }
                            else
                            {
                                frmperde.btnF2.Text = adsoyad;
                                frmperde.btnF2.BackColor = Color.Red;
                                frmperde.btnF2.Tag = "Dolu";
                            }
                            break;
                        case "F3":
                            if (frmperde.btnF3.Text != "F3")
                            {
                                komut = false;
                            }
                            else
                            {
                                frmperde.btnF3.Text = adsoyad;
                                frmperde.btnF3.BackColor = Color.Red;
                                frmperde.btnF3.Tag = "Dolu";
                            }
                            break;
                        case "F4":
                            if (frmperde.btnF4.Text != "F4")
                            {
                                komut = false;
                            }
                            else
                            {
                                frmperde.btnF4.Text = adsoyad;
                                frmperde.btnF4.BackColor = Color.Red;
                                frmperde.btnF4.Tag = "Dolu";
                            }
                            break;
                        case "F5":
                            if (frmperde.btnF5.Text != "F5")
                            {
                                komut = false;
                            }
                            else
                            {
                                frmperde.btnF5.Text = adsoyad;
                                frmperde.btnF5.BackColor = Color.Red;
                                frmperde.btnF5.Tag = "Dolu";
                            }
                            break;
                        case "F6":
                            if (frmperde.btnF6.Text != "F6")
                            {
                                komut = false;
                            }
                            else
                            {
                                frmperde.btnF6.Text = adsoyad;
                                frmperde.btnF6.BackColor = Color.Red;
                                frmperde.btnF6.Tag = "Dolu";
                            }
                            break;
                        case "F7":
                            if (frmperde.btnF7.Text != "F7")
                            {
                                komut = false;
                            }
                            else
                            {
                                frmperde.btnF7.Text = adsoyad;
                                frmperde.btnF7.BackColor = Color.Red;
                                frmperde.btnF7.Tag = "Dolu";
                            }
                            break;
                        case "F8":
                            if (frmperde.btnF8.Text != "F8")
                            {
                                komut = false;
                            }
                            else
                            {
                                frmperde.btnF8.Text = adsoyad;
                                frmperde.btnF8.BackColor = Color.Red;
                                frmperde.btnF8.Tag = "Dolu";
                            }
                            break;
                        case "F9":
                            if (frmperde.btnF9.Text != "F9")
                            {
                                komut = false;
                            }
                            else
                            {
                                frmperde.btnF9.Text = adsoyad;
                                frmperde.btnF9.BackColor = Color.Red;
                                frmperde.btnF9.Tag = "Dolu";
                            }
                            break;
                        case "F10":
                            if (frmperde.btnF10.Text != "F10")
                            {
                                komut = false;
                            }
                            else
                            {
                                frmperde.btnF10.Text = adsoyad;
                                frmperde.btnF10.BackColor = Color.Red;
                                frmperde.btnF10.Tag = "Dolu";
                            }
                            break;
                        case "G1":
                            if (frmperde.btnG1.Text != "G1")
                            {
                                komut = false;
                            }
                            else
                            {
                                frmperde.btnG1.Text = adsoyad;
                                frmperde.btnG1.BackColor = Color.Red;
                                frmperde.btnG1.Tag = "Dolu";
                            }
                            break;
                        case "G2":
                            if (frmperde.btnG2.Text != "G2")
                            {
                                komut = false;
                            }
                            else
                            {
                                frmperde.btnG2.Text = adsoyad;
                                frmperde.btnG2.BackColor = Color.Red;
                                frmperde.btnG2.Tag = "Dolu";
                            }
                            break;
                        case "G3":
                            if (frmperde.btnG3.Text != "G3")
                            {
                                komut = false;
                            }
                            else
                            {
                                frmperde.btnG3.Text = adsoyad;
                                frmperde.btnG3.BackColor = Color.Red;
                                frmperde.btnG3.Tag = "Dolu";
                            }
                            break;
                        case "G4":
                            if (frmperde.btnG4.Text != "G4")
                            {
                                komut = false;
                            }
                            else
                            {
                                frmperde.btnG4.Text = adsoyad;
                                frmperde.btnG4.BackColor = Color.Red;
                                frmperde.btnG4.Tag = "Dolu";
                            }
                            break;
                        case "G5":
                            if (frmperde.btnG5.Text != "G5")
                            {
                                komut = false;
                            }
                            else
                            {
                                frmperde.btnG5.Text = adsoyad;
                                frmperde.btnG5.BackColor = Color.Red;
                                frmperde.btnG5.Tag = "Dolu";
                            }
                            break;
                        case "G6":
                            if (frmperde.btnG6.Text != "G6")
                            {
                                komut = false;
                            }
                            else
                            {
                                frmperde.btnG6.Text = adsoyad;
                                frmperde.btnG6.BackColor = Color.Red;
                                frmperde.btnG6.Tag = "Dolu";
                            }
                            break;
                        case "G7":
                            if (frmperde.btnG7.Text != "G7")
                            {
                                komut = false;
                            }
                            else
                            {
                                frmperde.btnG7.Text = adsoyad;
                                frmperde.btnG7.BackColor = Color.Red;
                                frmperde.btnG7.Tag = "Dolu";
                            }
                            break;
                        case "G8":
                            if (frmperde.btnG8.Text != "G8")
                            {
                                komut = false;
                            }
                            else
                            {
                                frmperde.btnG8.Text = adsoyad;
                                frmperde.btnG8.BackColor = Color.Red;
                                frmperde.btnG8.Tag = "Dolu";
                            }
                            break;
                        case "G9":
                            if (frmperde.btnG9.Text != "G9")
                            {
                                komut = false;
                            }
                            else
                            {
                                frmperde.btnG9.Text = adsoyad;
                                frmperde.btnG9.BackColor = Color.Red;
                                frmperde.btnG9.Tag = "Dolu";
                            }
                            break;
                        case "G10":
                            if (frmperde.btnG10.Text != "G10")
                            {
                                komut = false;
                            }
                            else
                            {
                                frmperde.btnG10.Text = adsoyad;
                                frmperde.btnG10.BackColor = Color.Red;
                                frmperde.btnG10.Tag = "Dolu";
                            }
                            break;
                        case "G11":
                            if (frmperde.btnG11.Text != "G11")
                            {
                                komut = false;
                            }
                            else
                            {
                                frmperde.btnG11.Text = adsoyad;
                                frmperde.btnG11.BackColor = Color.Red;
                                frmperde.btnG11.Tag = "Dolu";
                            }
                            break;
                        default:
                            MessageBox.Show("Geçerli bir koltuk girmediniz !", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                            break;
                    }
                }
            }
        }
    }
}
