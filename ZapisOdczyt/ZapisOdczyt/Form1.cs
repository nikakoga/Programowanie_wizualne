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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public DataGridView MyGrid 
        {
            get { return dataGridView1; }
            set { dataGridView1 = value; }
        }
    }
}