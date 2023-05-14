using Microsoft.VisualBasic;

namespace ShipsGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int cols = Int32.Parse(tbxCols.Text);
            int rows = Int32.Parse(tbxRows.Text);
            if (cols>0&&rows>0)
            {
                this.Close();
                Game game = new Game(cols,rows);
            }
            else
            {
                MessageBox.Show("Please give apropriate parameters");
            }
                
        }
    }
}