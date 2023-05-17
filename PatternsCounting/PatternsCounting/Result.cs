using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PatternsCounting
{
    public partial class Result : Form
    {
        string sequence;
        Dictionary<string, int> patterns =
    new Dictionary<string, int>();
        public Result(string DNA)
        {
            InitializeComponent();
            sequence = DNA;
        }

        private void createPatterns()
        {
            for (int i=0; i<sequence.Length-4; i++) 
            {
                string find = sequence.Substring(i, 4);
                if (!patterns.ContainsKey(find))
                {
                    patterns.Add(find, i);
                }
                else
                {
                    int counter = patterns[find];
                    patterns[find] = counter+1;
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
