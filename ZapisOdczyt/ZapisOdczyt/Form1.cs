namespace ZapisOdczyt
{
    public partial class FormMAIN : Form
    {
        public FormMAIN()
        {
            InitializeComponent();
        }

        private void buttonADD_Click(object sender, EventArgs e)
        {
            FormADD f2 = new FormADD(this);
            f2.ShowDialog(); // Shows Form2
        }

        public void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonDELETE_Click(object sender, EventArgs e)
        {
            bool empty = true;

            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                empty = true;
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value != null)
                        empty = false;
                }
                if (empty == false)
                    dataGridView1.Rows.RemoveAt(row.Index);
            }
           
        }
    }
}