namespace ScientificCalculator
{
    public partial class Form1 : Form
    {
        string expression;
        Button[] Scientific;
        Button[] NotScientific;
        public Form1()
        {
            InitializeComponent();

            Scientific = new Button[] {btnRad,btnDeg,btnInv,btnPi,btnE,btnAns,btnSin,btnCos,btnTan,btnExp,btnx,btnLn,btnLog,btnPierw,btnxy };
            NotScientific = new Button[] { btn0, btn1, btn2, btn3, btn4, btn5, btn6, btn7, btn8, btn9, btnMnoz, btnDod, btnDziel, btnOdj,btnProc,btnNawO,btnNawZa,btnAc,btnKrop };

            foreach (var btn in Scientific)
            {
                btn.Visible = false;
            }
            foreach (var btn in NotScientific)
            {
                btn.Click += ButtonClick();
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

        private System.EventHandler ButtonClick(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            expression += clickedButton.Text;
            return 
        }
    }
}