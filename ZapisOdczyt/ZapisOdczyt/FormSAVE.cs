using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZapisOdczyt
{
    public partial class FormSAVE : Form
    {
        FormMAIN main_form;
        public FormSAVE(FormMAIN main)
        {
            InitializeComponent();
            this.main_form = main;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBoxFOLDER_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonSAVE_2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
