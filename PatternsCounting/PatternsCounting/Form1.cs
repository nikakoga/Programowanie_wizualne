using System.Drawing;
using System.Text.RegularExpressions;

namespace PatternsCounting
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var regex = @"[^ACTG]";
            Match match = Regex.Match(tbxDNA.Text, regex);

            if(tbxDNA.Text!="")
            {

                if (match.Success)
                {
                    MessageBox.Show("There are different letters than ACTG");
                }
                else
                {
                    Result res = new Result(tbxDNA.Text);
                    res.ShowDialog();
                    this.Close();

                }
            }
            else
            {
                MessageBox.Show("Type in something");
            }

        }
    }
}