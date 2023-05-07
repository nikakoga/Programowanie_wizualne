using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dziedziczenie
{
    public partial class Opinion : Form
    {
        public Opinion(string who)
        {
            InitializeComponent();
            label3.Text = who;
            label1.Text = who + "'s Opinion on the Engineering Diploma Thesis";
            label2.Text = "INFORMATION ON THE " + who.ToUpper();

        }

        private void SaveButton_Click(object sender, EventArgs e)
        {

        }
    }
}
