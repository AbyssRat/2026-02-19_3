using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fuggohidak
{
    public partial class KeresesForm : Form
    {
        private List<Fuggohid> hidak;
        public KeresesForm()
        {
            InitializeComponent();
            this.hidak = hidak;

            var orszagok = hidak.Select(h => h.Orszag).Distinct().ToList();
            comboBoxOrszagok.Items.AddRange(orszagok.ToArray());
            if (comboBoxOrszagok.Items.Count > 0) comboBoxOrszagok.SelectedIndex = 0;
        }

        private void KeresesForm_Load(object sender, EventArgs e)
        {

        }

        private void buttonKereses_Click(object sender, EventArgs e)
        {
            string orszag = comboBoxOrszagok.SelectedItem.ToString();
            bool csak1km = checkBoxKeresos.Checked;

            var eredmeny = hidak.Where(h => h.Orszag == orszag);
            if (csak1km)
            {
                eredmeny = eredmeny.Where(h => h.Hossz > 1000);
            }
        }

        private void buttonBezar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
