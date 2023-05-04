namespace Dziedziczenie
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void OpenForms_Click(object sender, EventArgs e)
        {
            var Selected = FormOptions.SelectedIndex;
            switch(Selected)
            {
                case 0:
                    {
                        break;
                    }
                case 1:
                    {
                        break;
                    }
                    case 2:
                    { 
                        break;
                    }
                    case 3:
                    {
                        break;
                    }
                default:
                    {
                        MessageBox.Show("First Select witch form to open");
                        break;
                    }


            }

        }
    }
}