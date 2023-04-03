namespace Solver_Algorytm_Floyda
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }



        private void button1_Click(object sender, EventArgs e)
        {

            TableLayoutPanel panel = new TableLayoutPanel();
        }

        private void TextBoxPanelSize_TextChanged(object sender, EventArgs e)
        {
            if (IsAnswearCorrect(TextBoxPanelSize.Text))
            {

            }
            
        }

        private bool IsAnswearCorrect(string text)
        {
            bool IsNumeric = false;
            int ans;
            IsNumeric = int.TryParse(text, out ans);

            if (!IsNumeric)
            {
                MessageBox.Show("Not numeric, try again");
                TextBoxPanelSize.Clear();
                return false;
            }

            if (ans <= 0)
            {
                MessageBox.Show("Value must be positive, try again");
                TextBoxPanelSize.Clear();
                return false;
            }

            return true;
            
        }
    }
}