using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;

namespace Puntatore
{
    public partial class Puntatore : Form
    {
        public Puntatore()
        {
            InitializeComponent();
            RegistryKey HkLocal = Registry.LocalMachine;
            RegistryKey RegKey = HkLocal.OpenSubKey(@"System\State\Samsung\Mouse", true);
            int at = (int)RegKey.GetValue("ActionMethod");
            if (at == 4001)
            {
                label3.Text = "Stato:  OFF";
                button1.Text = "ATTIVA";
            }
            else
            {
                label3.Text = "Stato:  ON";
                button1.Text = "DISATTIVA";
            }

            RegistryKey HkLocal2 = Registry.LocalMachine;
            RegistryKey RegKey2 = HkLocal2.OpenSubKey(@"System\State\Samsung\Mouse", true);
            int vat = (int)RegKey2.GetValue("Speed");
            if (vat == 1001)
            {
                trackBar1.Value = 1;
            }
            if (vat == 2001)
            {
                trackBar1.Value = 2;
            }
            if (vat == 3001)
            {
                trackBar1.Value = 3;
            }
        }

        private void menuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void menuItem2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sviluppato da:\njonny.rosworth@hotmail.it");
        }

        private void scrivi(string n)
        {
            RegistryKey HkLocal = Registry.LocalMachine;
            RegistryKey RegKey = HkLocal.OpenSubKey(@"System\State\Samsung\Mouse", true);
            RegKey.SetValue("CursorShape", ""+n+"", RegistryValueKind.DWord);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            scrivi("0");
        }
        
        private void pictureBox5_Click(object sender, EventArgs e)
        {
            scrivi("1");
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            scrivi("2");
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            scrivi("3");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            scrivi("4");
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            scrivi("5");
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            scrivi("6");
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            scrivi("7");
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            scrivi("8");
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            scrivi("9");
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            scrivi("10");
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            scrivi("11");
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            scrivi("12");
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            scrivi("13");
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            scrivi("14");
        }

        private void pictureBox20_Click(object sender, EventArgs e)
        {
            scrivi("15");
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            scrivi("16");
        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            scrivi("17");
        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {
            scrivi("18");
        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {
            scrivi("19");
        }

        private void pictureBox25_Click(object sender, EventArgs e)
        {
            scrivi("20");
        }

        private void pictureBox21_Click(object sender, EventArgs e)
        {
            scrivi("21");
        }

        private void pictureBox22_Click(object sender, EventArgs e)
        {
            scrivi("22");
        }

        private void pictureBox23_Click(object sender, EventArgs e)
        {
            scrivi("23");
        }

        private void pictureBox24_Click(object sender, EventArgs e)
        {
            scrivi("24");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RegistryKey HkLocal = Registry.LocalMachine;
            RegistryKey RegKey = HkLocal.OpenSubKey(@"System\State\Samsung\Mouse", true);
            int ad = (int)RegKey.GetValue("ActionMethod");
            if (ad == 4001)
            {
                RegKey.SetValue("ActionMethod", "3001", RegistryValueKind.DWord);
            }
            else
            {
                RegKey.SetValue("ActionMethod", "4001", RegistryValueKind.DWord);
            }

            RegistryKey HkLocalo = Registry.LocalMachine;
            RegistryKey RegKeyo = HkLocalo.OpenSubKey(@"System\State\Samsung\Mouse", true);
            int adt = (int)RegKeyo.GetValue("ActionMethod");
            if (adt == 4001)
            {
                label3.Text = "Stato:  OFF";
                button1.Text = "ATTIVA";
            }
            else
            {
                label3.Text = "Stato:  ON";
                button1.Text = "DISATTIVA";
            }
            
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            int val = trackBar1.Value;
            RegistryKey HkLocal = Registry.LocalMachine;
            RegistryKey RegKey = HkLocal.OpenSubKey(@"System\State\Samsung\Mouse", true);
            if (val == 1)
            {
                RegKey.SetValue("Speed", "1001", RegistryValueKind.DWord);
            }
            if (val == 2)
            {
                RegKey.SetValue("Speed", "2001", RegistryValueKind.DWord);
            }
            if (val == 3)
            {
                RegKey.SetValue("Speed", "3001", RegistryValueKind.DWord);
            }
            
        }

        
        
    }
}