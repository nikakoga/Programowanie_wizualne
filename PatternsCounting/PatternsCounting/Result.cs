using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
            createPatterns();
            DataGridViewCreator();


        }

        private void createPatterns()
        {
            for (int i = 0; i < sequence.Length - 3; i++)
            {
                string find = sequence.Substring(i, 4);
                if (!patterns.ContainsKey(find))
                {
                    patterns.Add(find, 1);
                }
                else
                {
                    int counter = patterns[find];
                    patterns[find] = counter + 1;
                }
            }
        }

        private void DataGridViewCreator()
        {
            foreach (var kvp in patterns)
            {
                dgvCounter.Rows.Add(kvp.Key, kvp.Value);
            }

            // Dodanie DataGridView do formularza lub innego kontenera
            Controls.Add(dgvCounter);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "CSV| *.csv";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                string extension = Path.GetExtension(sfd.FileName).ToLower();
                string path = sfd.FileName;

                try
                {
                    //Build the CSV file data as a Comma separated string.
                    string csv = string.Empty;

                    //Add the Header row for CSV file.
                    foreach (DataGridViewColumn column in dgvCounter.Columns)
                    {
                        csv += column.HeaderText + ',';
                    }

                    //To remove coma after last value in a row
                    csv = csv.Remove(csv.Length - 1);

                    //Add new line.
                    csv += "\r\n";

                    //Adding the Rows

                    foreach (DataGridViewRow row in dgvCounter.Rows)
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
                    MessageBox.Show(ex.ToString());
                }
            }

        }
    }
}

