namespace Wartosc_zestawu_komputerowego
{
    public partial class Form1 : Form
    {
        private int _cenaKomputera = 0;
        private int _cenaMonitora = 0;
        public int CenaKomputera //autoproperty
        {
            get => _cenaKomputera;
            set
            {
                _cenaKomputera = value;
                suma_wartosci.Text = (_cenaKomputera + _cenaMonitora).ToString() + "zl";

            }
        }
        public int CenaMonitora //autoproperty
        {
            get => _cenaMonitora;
            set
            {
                _cenaMonitora = value;
                suma_wartosci.Text = (_cenaKomputera + _cenaMonitora).ToString() + "zl";

            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Komputer_Button_Click(object sender, EventArgs e)
        {
            Komputer_form f2 = new Komputer_form(this);
            f2.ShowDialog(); // Shows Form2
        }

        private void MonitorButton_Click(object sender, EventArgs e)
        {
            Monitor_form f3 = new Monitor_form(this);
            f3.ShowDialog(); // Shows Form2
        }

        private void suma_wartosci_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}