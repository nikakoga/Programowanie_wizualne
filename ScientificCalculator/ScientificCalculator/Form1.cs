namespace ScientificCalculator
{
    public partial class Form1 : Form
    {
        string expression;
        Button[] Scientific;
        public Form1()
        {
            InitializeComponent();

            Scientific = new Button[] {btnRad,btnDeg,btnInv,btnPi,btnE,btnAns,btnSin,btnCos,btnTan,btnExp,btnx,btnLn,btnLog,btnPierw,btnxy };

            foreach (var btn in Scientific)
            {
                btn.Visible = false;
            }
        }

        private void btnRow_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked)
            {
                foreach (var btn in Scientific)
                {
                    btn.Visible = true;
                }
            }
            else
            {
                foreach (var btn in Scientific)
                {
                    btn.Visible = false;
                }
            }
        }

        void Button_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            expression += clickedButton.Text;
        }
    }
}