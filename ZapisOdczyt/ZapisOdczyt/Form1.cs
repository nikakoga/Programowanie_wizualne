namespace ZapisOdczyt
{
    
    public partial class FormMAIN : Form
    {
        private string path;

        
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
        private void Load_from_file (string path)
        {
            try
            {
                string[] lines = System.IO.File.ReadAllLines(path);
               
                //from 1 instead of 0 to avoid adding headers
                for (int i=1;i<lines.Length;i++)
                {    
                    string[] cells = lines[i].Split(',');
                    dataGridView1.Rows.Add(new object[] { cells[0], cells[1], cells[2], cells[3], cells[4] });
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonLOAD_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            path = ofd.FileName;
            Load_from_file(path);
        }

        private void Save_to_file(string path)
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

                //To remove coma after last value in a row
                csv = csv.Remove(csv.Length - 1);

                //Add new line.
                csv += "\r\n";

                //Adding the Rows

                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                   
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        //Add the Data rows.
                        if(cell.Value!=null)
                        {
                            csv += cell.Value.ToString() + ',';
                            
                        }
                        
                    }

                    //To remove coma after last value in a row
                    csv = csv.Remove(csv.Length - 1);

                    //Add new line.
                    csv += "\r\n";
                }

                //To remove new line after last value in a row
                csv = csv.Remove(csv.Length - 2);

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
            
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "CSV|*.csv";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    path = sfd.FileName;
                    Save_to_file(path);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
            }
            
        }
    }
}