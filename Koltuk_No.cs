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
    class Koltuk_No
    {
        public void Koltuk_Combo_Ekle(string secilenitem)
        {
            foreach (Form forms in Application.OpenForms)
            {
                if (forms.Name == "FormBilet")
                {
                    FormBilet frmbilet = (FormBilet)forms;
                    frmbilet.combokoltuk.Enabled = true;
                    frmbilet.combokoltuk.Items.Clear();
                    if (secilenitem == "A")
                    {
                        frmbilet.combokoltuk.Items.Add(1);
                        frmbilet.combokoltuk.Items.Add(2);
                        frmbilet.combokoltuk.Items.Add(3);
                        frmbilet.combokoltuk.Items.Add(4);
                        frmbilet.combokoltuk.Items.Add(5);
                    }
                    if (secilenitem == "B")
                    {
                        frmbilet.combokoltuk.Items.Add(1);
                        frmbilet.combokoltuk.Items.Add(2);
                        frmbilet.combokoltuk.Items.Add(3);
                        frmbilet.combokoltuk.Items.Add(4);
                        frmbilet.combokoltuk.Items.Add(5);
                        frmbilet.combokoltuk.Items.Add(6);
                    }
                    if (secilenitem == "C")
                    {
                        frmbilet.combokoltuk.Items.Add(1);
                        frmbilet.combokoltuk.Items.Add(2);
                        frmbilet.combokoltuk.Items.Add(3);
                        frmbilet.combokoltuk.Items.Add(4);
                        frmbilet.combokoltuk.Items.Add(5);
                        frmbilet.combokoltuk.Items.Add(6);
                        frmbilet.combokoltuk.Items.Add(7);
                    }
                    if (secilenitem == "D")
                    {
                        frmbilet.combokoltuk.Items.Add(1);
                        frmbilet.combokoltuk.Items.Add(2);
                        frmbilet.combokoltuk.Items.Add(3);
                        frmbilet.combokoltuk.Items.Add(4);
                        frmbilet.combokoltuk.Items.Add(5);
                        frmbilet.combokoltuk.Items.Add(6);
                        frmbilet.combokoltuk.Items.Add(7);
                        frmbilet.combokoltuk.Items.Add(8);
                    }
                    if (secilenitem == "E")
                    {
                        frmbilet.combokoltuk.Items.Add(1);
                        frmbilet.combokoltuk.Items.Add(2);
                        frmbilet.combokoltuk.Items.Add(3);
                        frmbilet.combokoltuk.Items.Add(4);
                        frmbilet.combokoltuk.Items.Add(5);
                        frmbilet.combokoltuk.Items.Add(6);
                        frmbilet.combokoltuk.Items.Add(7);
                        frmbilet.combokoltuk.Items.Add(8);
                        frmbilet.combokoltuk.Items.Add(9);
                    }
                    if (secilenitem == "F")
                    {
                        frmbilet.combokoltuk.Items.Add(1);
                        frmbilet.combokoltuk.Items.Add(2);
                        frmbilet.combokoltuk.Items.Add(3);
                        frmbilet.combokoltuk.Items.Add(4);
                        frmbilet.combokoltuk.Items.Add(5);
                        frmbilet.combokoltuk.Items.Add(6);
                        frmbilet.combokoltuk.Items.Add(7);
                        frmbilet.combokoltuk.Items.Add(8);
                        frmbilet.combokoltuk.Items.Add(9);
                        frmbilet.combokoltuk.Items.Add(10);
                    }
                    if (secilenitem == "G")
                    {
                        frmbilet.combokoltuk.Items.Add(1);
                        frmbilet.combokoltuk.Items.Add(2);
                        frmbilet.combokoltuk.Items.Add(3);
                        frmbilet.combokoltuk.Items.Add(4);
                        frmbilet.combokoltuk.Items.Add(5);
                        frmbilet.combokoltuk.Items.Add(6);
                        frmbilet.combokoltuk.Items.Add(7);
                        frmbilet.combokoltuk.Items.Add(8);
                        frmbilet.combokoltuk.Items.Add(9);
                        frmbilet.combokoltuk.Items.Add(10);
                        frmbilet.combokoltuk.Items.Add(11);
                    }
                }
            }
        }
    }
}