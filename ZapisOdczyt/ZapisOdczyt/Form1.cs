namespace ZapisOdczyt
{
    public partial class FormMAIN : Form
    {
        public string path;
        
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

        private void buttonLOAD_Click(object sender, EventArgs e)
        {

        }

        public void Save_to_file(string path)
        {
            try
            {
                //Build the CSV file data as a Comma separated string.
                string csv = string.Empty;

                //Add the Header row for CSV file.
                foreach (DataGridViewColumn column in dataGridView1.Columns)
                {
                    csv += column.HeaderText + ',';
                }

                //Add new line.
                csv += "\r\n";

                //Adding the Rows
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        //Add the Data rows.
                        csv += cell.Value.ToString() + ',';
                    }

                    //Add new line.
                    csv += "\r\n";
                }

                //Exporting to CSV.
                File.WriteAllText(path, csv);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void buttonSAVE_Click(object sender, EventArgs e)
        {
            FormSAVE save = new FormSAVE(this);
            save.ShowDialog();
            string folder = save.textBoxFOLDER.Text;
            string filename = save.textBoxPLIK.Text;
            path = folder + "/" + filename + ".csv";
        }
    }
}