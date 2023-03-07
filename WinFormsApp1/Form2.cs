using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form2 : Form
    {
        Stopwatch sw = new Stopwatch();
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sw.Stop();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            timer1.Start();
            sw.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan ts = TimeSpan.FromMilliseconds(sw.ElapsedMilliseconds);
            Stoper.Text = ts.ToString(@"hh\:mm\:ss\:ff");
        }
    }
}
