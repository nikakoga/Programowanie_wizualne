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
    public partial class FormADD : Form
    {
        FormMAIN fgrid;
        public FormADD(FormMAIN fg)
        {
            InitializeComponent();
            this.fgrid = fg;
        }

        private void labelName_Click(object sender, EventArgs e)
        {

        }

        private void LabelMonthOfBirth_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void labelDayOfBirth_Click(object sender, EventArgs e)
        {

        }

        private void buttonADD_Click(object sender, EventArgs e)
        {
            fgrid.MyGrid.get();
                
        }
    }
}
