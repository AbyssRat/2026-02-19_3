using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Fuggohidak
{
    public partial class FormMain : Form
    {
        private List<Fuggohid> hidak = new List<Fuggohid>();
        public FormMain()
        {
            InitializeComponent();
        }

        private void radio2000Utan_CheckedChanged(object sender, EventArgs e)
        {
            if(radio2000Utan.Checked)
            {
                int szam = hidak.Count(h => h.Ev >= 2000);
                textBoxHidSzam.Text = szam.ToString();
            }
        }

        private void kilépésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonKilep_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }



        private void listBoxHidak_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxHidak.SelectedIndex < 0) return;
            var h = hidak[listBoxHidak.SelectedIndex];
            textBoxHely.Text = h.Hely;
            textBoxOrszag.Text = h.Orszag;
            textBoxHossz.Text = h.Hossz.ToString();
            textBoxEv.Text = h.Ev.ToString();
        }

        private void megnyitásToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "CSV fájlok (*.csv)|*.csv";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                Beolvas(ofd.FileName);
                ListBoxFrissit();
            }
        }

        private void Beolvas(string filePath)
        {
            hidak.Clear();
            using (StreamReader sr = new StreamReader(filePath))
            {
                sr.ReadLine();

                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] parts = line.Split('\t');
                    if (parts.Length == 6)
                    {
                        int helyezes = int.Parse(parts[0]);
                        string hid = parts[1];
                        string hely = parts[2];
                        string orszag = parts[3];
                        int hossz = int.Parse(parts[4]);
                        int ev = int.Parse(parts[5]);
                        hidak.Add(new Fuggohid(helyezes, hid, hely, orszag, hossz, ev));
                    }
                }
            }
        }

        private void ListBoxFrissit()
        {
            listBoxHidak.Items.Clear();
            foreach (var hid in hidak)
            {
                listBoxHidak.Items.Add($"{hid.Helyezes}. {hid.Hid} - {hid.Hely}, {hid.Orszag} ({hid.Hossz} m, {hid.Ev})");
            }
        }

        private void radio2000Elott_CheckedChanged(object sender, EventArgs e)
        {
            if (radio2000Elott.Checked)
            {
                int szam = hidak.Count(h => h.Ev < 2000);
                textBoxHidSzam.Text = szam.ToString();
            }
        }

        private void keresésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KeresesForm keresesForm = new KeresesForm(hidak);
            this.Hide();
            keresesForm.ShowDialog();
            this.Show();
        }
    }
}
