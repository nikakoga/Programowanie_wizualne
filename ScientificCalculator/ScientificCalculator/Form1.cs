using org.mariuszgromada.math.mxparser;
using static System.Net.Mime.MediaTypeNames;


namespace ScientificCalculator
{
    public partial class Form1 : Form
    {
        string expression="";
        string lastValue;
        bool result;
        Button[] ScientificRest;
        Button[] NotScientificNotSpecial;
        Button[] ScientificTrygonomic;
        Button[] ScientificBracketNeeded;
        public Form1()
        {
            InitializeComponent();

            tbxWindow.ReadOnly = true;

            ScientificRest = new Button[] { btnE, btnAns, btnx, btnxy, btnPi };
            NotScientificNotSpecial = new Button[] { btn0, btn1, btn2, btn3, btn4, btn5, btn6, btn7, btn8, btn9, btnDod, btnOdj, btnProc, btnNawO, btnNawZa, btnKrop };

            ScientificTrygonomic = new Button[] { btnCos, btnTan, btnSin };
            ScientificBracketNeeded = new Button[] { btnLn, btnLog, btnExp }; //+jeszcze te co sa w trygonomic

            HideScientific();
            AddActionsToButtons();

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
            //FreshStart();
            expression += clickedButton.Text;
            tbxWindow.Text = expression;
        }
        private void ButtonTrygonomicClick(object sender, EventArgs e)
        {

            Button clickedButton = (Button)sender;
            //FreshStart();
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
        private void ButtonBracketClick(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            //FreshStart();
            expression += clickedButton.Text + "(";
            tbxWindow.Text = expression;
        }
        private void btnRow_Click(object sender, EventArgs e)
        {
            SetDegreeOrRadians(); //if trygonometric functions are used combobox Rad/Deg have to be selected
            if (SafeCheck()) //if no missing brackets
            {
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
        }
        private void btnAc_Click(object sender, EventArgs e)
        {
            expression = "";
            tbxWindow.Text = expression;
        }
        private void btnDel_Click(object sender, EventArgs e)
        {
            var len = expression.Length;
            if (len > 0) 
            {
                expression = expression.Remove(len - 1);
                tbxWindow.Text = expression;
            }
        }
        private void btnxy_Click(object sender, EventArgs e)
        {
            //FreshStart();
            expression += "^";
            tbxWindow.Text = expression;
        }
        private void btnDziel_Click(object sender, EventArgs e)
        {
            //FreshStart();
            expression += "/";
            tbxWindow.Text = expression;
        }
        private void btnMnoz_Click(object sender, EventArgs e)
        {
            //FreshStart();
            expression += "*";
            tbxWindow.Text = expression;
        }
        private void btnPierw_Click(object sender, EventArgs e)
        {
            //FreshStart();
            expression += "sqrt(";
            tbxWindow.Text = expression;
        }
        private void btnAns_Click(object sender, EventArgs e)
        {
            //FreshStart();
            expression += lastValue;
            tbxWindow.Text = expression;
        }

        private bool SafeCheck()
        {
            expression = expression.Replace(',', '.');

            int count_open = expression.Count(c => c == '(');//lambda expression to count open bracket
            int count_close = expression.Count(c => c == ')');
            if (count_open != count_close)
            {
                MessageBox.Show("Missing Bracket");
                return false;
            }
            return true;
        }

        //private void FreshStart()
        //{
        //    if (result) //for "fresh start" after result
        //    {
        //        expression = "";
        //        result = false;
        //    }
        //}
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
            foreach (var btn in ScientificRest)
            {
                btn.Visible = false;

            }

            foreach (var btn in ScientificTrygonomic)
            {
                btn.Visible = false;
            }

            foreach (var btn in ScientificBracketNeeded)
            {
                btn.Visible = false;
            }

            cbxRadDeg.Visible = false;
        }
        private void ShowScientific()
        {
            foreach (var btn in ScientificRest)
            {
                btn.Visible = true;
            }

            cbxRadDeg.Visible = true;

            foreach (var btn in ScientificTrygonomic)
            {
                btn.Visible = true;
            }

            foreach (var btn in ScientificBracketNeeded)
            {
                btn.Visible = true;
            }
        }

        private void AddActionsToButtons()
        {
            foreach (var btn in ScientificRest)
            {
                if (btn != btnAns)
                {
                    btn.Click += (s, e) => ButtonClick(s, e);
                }

            }
            foreach (var btn in ScientificTrygonomic)
            {
                btn.Click += (s, e) => ButtonTrygonomicClick(s, e);
            }
            foreach (var btn in ScientificBracketNeeded)
            {
                btn.Click += (s, e) => ButtonBracketClick(s, e);
            }
            foreach (var btn in NotScientificNotSpecial)
            {
                btn.Click += (s, e) => ButtonClick(s, e);
            }
        }
    }
}