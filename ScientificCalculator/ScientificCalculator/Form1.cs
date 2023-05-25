using System;
using System.Data;
using System.Linq.Expressions;
using System.Windows.Forms;
//using org.mariuszgromada.math.mxparser;


namespace ScientificCalculator
{
    public partial class Form1 : Form
    {
        string expression;
        string lastValue;
        bool result;
        Button[] Scientific;
        Button[] NotScientific;
        public Form1()
        {
            InitializeComponent();

            Scientific = new Button[] { btnRad, btnDeg, btnInv, btnPi, btnE, btnAns, btnSin, btnCos, btnTan, btnExp, btnx, btnLn, btnLog, btnPierw, btnxy };
            NotScientific = new Button[] { btn0, btn1, btn2, btn3, btn4, btn5, btn6, btn7, btn8, btn9, btnMnoz, btnDod, btnDziel, btnOdj, btnProc, btnNawO, btnNawZa, btnAc, btnKrop };

            foreach (var btn in Scientific)
            {
                btn.Visible = false;
                if (btn != btnAns)
                {
                    btn.Click += (s, e) => ButtonClick(s, e);
                }

            }
            foreach (var btn in NotScientific)
            {
                if (btn != btnAc && btn != btnMnoz && btn != btnDziel)
                {
                    btn.Click += (s, e) => ButtonClick(s, e);
                }
            }
        }

        private void btnRow_Click(object sender, EventArgs e)
        {
            //tutaj przekazywanie do parsera i jesli bedzie ok to wpisywanie tego na liste ostatnich operacji a jesli nie to nie wpisywanie
            lastValue = new DataTable().Compute(expression, null).ToString();
            //Expression rownanie = new Expression(expression);
            //lastValue= rownanie.calculate().ToString();
            tbxWindow.Text = lastValue;

            History.Items.Insert(0, expression + "=" + lastValue);
            while (History.Items.Count > 13)
            {
                History.Items.RemoveAt(History.Items.Count - 1);
            }
            expression = lastValue;
            result = true;
        }
        private void btnAc_Click(object sender, EventArgs e)
        {
            expression = "";
            tbxWindow.Text = expression;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
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

        private void ButtonClick(object sender, EventArgs e)
        {

            Button clickedButton = (Button)sender;
            FreshStart();
            expression += clickedButton.Text;
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

        private void FreshStart()
        {
            if (result) //for "fresh start" after result
            {
                expression = "";
                result = false;
            }
        }

        
    }
}