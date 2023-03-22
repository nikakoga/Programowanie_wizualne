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

    }
}