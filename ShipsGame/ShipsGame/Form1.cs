using Microsoft.VisualBasic;


namespace ShipsGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //MessageBox.Show("SZANOWNY PANIE DOKTORZE\nWiem, ¿e projekt mia³ mieæ planszê kwadratow¹ i wiem, ¿e udziwniam go dodaj¹c opcjê przegrania,poziom trudnoœci oraz obrazki w miejscach ikonek, ale bardzo chcia³am nauczyæ siê w tym projekcie czegoœ wiêcej i aby moje portfolio na githubie by³o bardziej zaawansowane. Jeœli jest to niezgodne z wymaganiami, mogê cofn¹æ projekt do wersji podstawowej");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Int32.TryParse(tbxCols.Text, out int cols);
            Int32.TryParse(tbxRows.Text, out int rows);

            if (cols > 2 && rows > 2)
            {
                int gameLevel = level.SelectedIndex;
                Game game = new Game(cols, rows, gameLevel);
                game.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Please give apropriate parameters");
            }

        }


    }
}