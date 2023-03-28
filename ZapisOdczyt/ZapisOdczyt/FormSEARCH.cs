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
    public partial class FormSEARCH : Form
    {
        public string Text_search;
        FormMAIN fm;
        public FormSEARCH(FormMAIN fmain)
        {
            InitializeComponent();
            this.fm = fmain;
        }


        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private List<string> CreateArgList (DataGridView dgv, int row)
        {
            List<string> ArgList = new List<string> ();
            
            foreach (DataGridViewCell cell in dgv.Rows[row].Cells)
            {
                ArgList.Add(cell.Value.ToString());
            }
            return ArgList;
        }
        private void buttonSEARCH_Click(object sender, EventArgs e)
        {
            Text_search = "";
            int row_counter = 0;
            if (textBoxSEARCH!=null)
            {
                Text_search= textBoxSEARCH.Text;
                foreach (DataGridViewRow row in fm.dataGridView1.Rows)
                {

                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        //Add the Data rows that matches.
                        if (cell.Value != null && cell.Value.ToString() == Text_search)
                        {
                            
                            dataGridViewSEARCH.Rows.Add(fm.dataGridView1.Rows[row_counter].Cells[0].Value.ToString(),
                                fm.dataGridView1.Rows[row_counter].Cells[1].Value.ToString(), fm.dataGridView1.Rows[row_counter].Cells[2].Value.ToString(),
                                fm.dataGridView1.Rows[row_counter].Cells[3].Value.ToString(),fm.dataGridView1.Rows[row_counter].Cells[4].Value.ToString());
                            
                           
                        }
                        
                    }
                    row_counter++;
                }

            }
        }
    }
}

