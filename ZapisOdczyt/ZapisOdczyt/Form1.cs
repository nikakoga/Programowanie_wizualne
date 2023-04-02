using System.Data;

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
        private void Load_from_csv(string path)
        {
            try
            {
                string[] lines = System.IO.File.ReadAllLines(path);

                //from 1 instead of 0 to avoid adding headers
                for (int i = 1; i < lines.Length; i++)
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

        private void Load_from_xml(string path, DataGridView dgv)
        {
            DataSet dataSet = new DataSet();
            dataSet.ReadXml(path);
            
            //from one to avoid adding columns names
            for (int i=0; i<dataSet.Tables[0].Rows.Count;i++)
            {
                dgv.Rows.Add(dataSet.Tables[0].Rows[i][0], dataSet.Tables[0].Rows[i][1],
                    dataSet.Tables[0].Rows[i][2], dataSet.Tables[0].Rows[i][3], dataSet.Tables[0].Rows[i][4]);
            }

        }

        private void buttonLOAD_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();


            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string path_open = ofd.FileName;
                string extension = Path.GetExtension(ofd.FileName).ToLower();

                switch (extension)
                {
                    case ".csv":
                        {
                            try
                            {

                                Load_from_csv(path_open);
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.ToString());
                            }
                            break;
                        }


                    case ".xml":
                        {
                            try
                            {
                                Load_from_xml(path_open,dataGridView1);
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.ToString());
                            }
                            break;
                        }
                    default:
                        MessageBox.Show("Wrong file type");
                        break;

                }


            }

        }

        public static DataTable DataGridView_To_Datatable(DataGridView dg)
        {
            DataTable ExportDataTable = new DataTable(dg.Name);
            foreach (DataGridViewColumn col in dg.Columns)
            {
                ExportDataTable.Columns.Add(col.Name);
            }
            bool empty = true;
            foreach (DataGridViewRow row in dg.Rows)
            {
                DataRow dRow = ExportDataTable.NewRow();
                empty = true;
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value != null)
                    {
                        empty = false;
                        dRow[cell.ColumnIndex] = cell.Value;
                    }

                }
                if (!empty)
                {
                    ExportDataTable.Rows.Add(dRow);
                }

            }
            return ExportDataTable;
        }
        private void ExportDgvToXML(DataTable dt, string path)
        {
            //foreach (DataRow row in dt.Rows)
            //{
            //    Console.WriteLine(row.ToString());
            //}

            try
            {
                dt.WriteXml(path);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
        private void Save_to_csv(string path)
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
                        if (cell.Value != null)
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

        private void Save_to_xml(DataGridView dataGridView1, string path)
        {
            ExportDgvToXML(DataGridView_To_Datatable(dataGridView1), path);

        }
        private void buttonSAVE_Click(object sender, EventArgs e)
        {

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "CSV| *.csv|XML|*.xml";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string extension = Path.GetExtension(sfd.FileName).ToLower();
                    path = sfd.FileName;

                    switch (extension)
                    {

                        case ".csv":
                            {
                                Save_to_csv(path);
                                MessageBox.Show("Data is saved!");
                                break;
                            }

                        case ".xml":
                            {
                                Save_to_xml(dataGridView1, path);
                                MessageBox.Show("Data is saved!");
                                break;
                            }


                        default:
                            throw new ArgumentOutOfRangeException(extension);
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }

        }

        private void buttonSEARCH_Click(object sender, EventArgs e)
        {
            FormSEARCH search_form = new FormSEARCH(this);
            search_form.ShowDialog();


        }
    }
}