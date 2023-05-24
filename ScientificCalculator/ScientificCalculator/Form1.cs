namespace ScientificCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            btnRad.Visible = false;
            btnDeg.Visible = false;
            btnInv.Visible = false;
            btnPi.Visible = false;
            btnE.Visible = false;
            btnAns.Visible = false;
            btnSin.Visible = false;
            btnCos.Visible = false;
            btnTan.Visible = false;
            btnExp.Visible = false;
            btnx.Visible = false;
            btnLn.Visible = false;
            btnLog.Visible = false;
            btnPierw.Visible = false;
            btnxy.Visible = false;
        }

        private void btnRow_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked)
            {
                btnRad.Visible = true;
                btnDeg.Visible = true;
                btnInv.Visible = true;
                btnPi.Visible = true;
                btnE.Visible = true;
                btnAns.Visible = true;
                btnSin.Visible = true;
                btnCos.Visible = true;
                btnTan.Visible = true;
                btnExp.Visible = true;
                btnx.Visible = true;
                btnLn.Visible = true;
                btnLog.Visible = true;
                btnPierw.Visible = true;
                btnxy.Visible = true;
            }
            else
            {
                btnRad.Visible = false;
                btnDeg.Visible = false;
                btnInv.Visible = false;
                btnPi.Visible = false;
                btnE.Visible = false;
                btnAns.Visible = false;
                btnSin.Visible = false;
                btnCos.Visible = false;
                btnTan.Visible = false;
                btnExp.Visible = false;
                btnx.Visible = false;
                btnLn.Visible = false;
                btnLog.Visible = false;
                btnPierw.Visible = false;
                btnxy.Visible = false;
            }
        }
    }
}