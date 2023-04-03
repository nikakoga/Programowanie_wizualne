using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Solver_Algorytm_Floyda
{
    public partial class InsertedData : Form
    {
        public InsertedData()
        {
            InitializeComponent();
        }

        DataGridView PanelDesigner;

        private List<string> CreateHeaders (int size)
        {
            List<string> headers = new List<string>();

            for (int i=0;i<=size;i++)
            {
                headers.Add(i.ToString());
            }

            return headers;
        }

        public DataGridView CreateEmptyGrid(int size)
        {
            List<string> headers = CreateHeaders(size)
            CreateEmptyGrid.Rows.Add(headers.ToArray());

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                dataGridView1.Rows[i].HeaderCell.Value = rowHeaders[i];
            }
            return PanelDesigner
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
