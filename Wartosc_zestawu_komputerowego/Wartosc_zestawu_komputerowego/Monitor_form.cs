using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wartosc_zestawu_komputerowego
{
    public partial class Monitor_form : Form
    {
        private Form1 _form1;
        int cena_monitora = 0;

        public Monitor_form(Form1 form1)
        {
            InitializeComponent();
            _form1 = form1;
        }

        private void Zapisz_button_Click(object sender, EventArgs e)
        {
            _form1.CenaMonitora = cena_monitora; // tutaj ma byc laczna cena
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            cena_monitora = 0;
            int[] array_ceny_monitorow = { 500, 4293, 3789, 3340 };
            foreach (int idx in listView1.SelectedIndices)
            {
                cena_monitora += array_ceny_monitorow[idx];
            }

            label_cena.Text = cena_monitora.ToString() + "zl";
        }

        private void Monitor_form_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }

}


