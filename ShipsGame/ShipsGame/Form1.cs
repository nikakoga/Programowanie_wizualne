using Microsoft.VisualBasic;


namespace ShipsGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //MessageBox.Show("SZANOWNY PANIE DOKTORZE\nWiem, �e projekt mia� mie� plansz� kwadratow� i wiem, �e udziwniam go dodaj�c opcj� przegrania,poziom trudno�ci oraz obrazki w miejscach ikonek, ale bardzo chcia�am nauczy� si� w tym projekcie czego� wi�cej i aby moje portfolio na githubie by�o bardziej zaawansowane. Je�li jest to niezgodne z wymaganiami, mog� cofn�� projekt do wersji podstawowej");
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