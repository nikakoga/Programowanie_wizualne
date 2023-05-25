using org.mariuszgromada.math.mxparser;


namespace ScientificCalculator
{
    public partial class Form1 : Form
    {
        string expression;
        string lastValue;
        bool result;
        Button[] Scientific;
        Button[] NotScientific;
        Button[] Trygonomic;
        Button[] BracketNeeded;
        public Form1()
        {
            InitializeComponent();

            Scientific = new Button[] { btnE, btnAns, btnExp, btnx, btnLn, btnLog, btnxy, btnPi };
            NotScientific = new Button[] { btn0, btn1, btn2, btn3, btn4, btn5, btn6, btn7, btn8, btn9, btnMnoz, btnDod, btnDziel, btnOdj, btnProc, btnNawO, btnNawZa, btnAc, btnKrop, btnPierw };

            Trygonomic = new Button[] { btnCos, btnTan, btnSin };
            //BracketNeeded = new Button[] { btnLn, btnLog, btnExp }; //+jeszcze te co sa w trygonomic


            foreach (var btn in Scientific)
            {
                btn.Visible = false;
                if (btn != btnAns && btn != btnLog && btn != btnLn && btn != btnExp)
                {
                    btn.Click += (s, e) => ButtonClick(s, e);
                }

            }
            foreach (var btn in Trygonomic)
            {
                btn.Visible = false;
                btn.Click += (s, e) => ButtonTrygonomicClick(s, e);
            }

            foreach (var btn in NotScientific)
            {
                if (btn != btnAc && btn != btnMnoz && btn != btnDziel && btn != btnPierw)
                {
                    btn.Click += (s, e) => ButtonClick(s, e);
                }
            }

            cbxRadDeg.Visible = false;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                ShowScientific();
            }
            else
            {
                HideScientific();
            }
        }

        private void ButtonClick(object sender, EventArgs e)
        {

            Button clickedButton = (Button)sender;
            FreshStart();
            expression += clickedButton.Text;
            tbxWindow.Text = expression;
        }
        private void ButtonTrygonomicClick(object sender, EventArgs e)
        {

            Button clickedButton = (Button)sender;
            FreshStart();
            if (cbxRadDeg.SelectedIndex == -1)
            {
                MessageBox.Show("If you want to use that function select Radians or Degrees first");
            }
            else
            {
                expression += clickedButton.Text + "(";
                tbxWindow.Text = expression;
            }

        }
        private void btnRow_Click(object sender, EventArgs e)
        {
            SetDegreeOrRadians();
            Expression rownanie = new Expression(expression);
            lastValue = rownanie.calculate().ToString();
            if (lastValue != "NaN")
            {
                tbxWindow.Text = lastValue;

                History.Items.Insert(0, expression + "=" + lastValue);
                while (History.Items.Count > 13)
                {
                    History.Items.RemoveAt(History.Items.Count - 1);
                }
                expression = lastValue;
                result = true;
            }
            else
            {
                tbxWindow.Text = "ERROR";
                lastValue = "";
                result = true;
            }
        }
        private void btnAc_Click(object sender, EventArgs e)
        {
            expression = "";
            tbxWindow.Text = expression;
        }

        private void btnxy_Click(object sender, EventArgs e)
        {
            FreshStart();
            expression += "^";
            tbxWindow.Text = expression;
        }

        private void btnDziel_Click(object sender, EventArgs e)
        {
            FreshStart();
            expression += "/";
            tbxWindow.Text = expression;
        }
        private void btnMnoz_Click(object sender, EventArgs e)
        {
            FreshStart();
            expression += "*";
            tbxWindow.Text = expression;
        }

        private void btnPierw_Click(object sender, EventArgs e)
        {
            FreshStart();
            expression += "sqrt(";
            tbxWindow.Text = expression;
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            FreshStart();
            expression += "lg(";
            tbxWindow.Text = expression;
        }

        private void btnLn_Click(object sender, EventArgs e)
        {
            FreshStart();
            expression += "ln(";
            tbxWindow.Text = expression;
        }

        private void btnExp_Click(object sender, EventArgs e)
        {
            FreshStart();
            expression += "exp(";
            tbxWindow.Text = expression;
        }

        private void btnAns_Click(object sender, EventArgs e)
        {
            FreshStart();
            expression += lastValue;
            tbxWindow.Text = expression;
        }

        private void FreshStart()
        {
            if (result) //for "fresh start" after result
            {
                expression = "";
                result = false;
            }
        }

        private void SetDegreeOrRadians()
        {
            if (cbxRadDeg.SelectedIndex == 0)
            {
                mXparser.setRadiansMode();
            }
            else if (cbxRadDeg.SelectedIndex == 1)
            {
                mXparser.setDegreesMode();
            }
        }

        private void HideScientific()
        {
            foreach (var btn in Scientific)
            {
                btn.Visible = false;

            }

            foreach (var btn in Trygonomic)
            {
                btn.Visible = false;
            }

            cbxRadDeg.Visible = false;
        }

        private void ShowScientific()
        {
            foreach (var btn in Scientific)
            {
                btn.Visible = true;
            }

            cbxRadDeg.Visible = true;

            foreach (var btn in Trygonomic)
            {
                btn.Visible = true;
            }
        }

        
    }
}