using Microsoft.VisualBasic;


namespace ShipsGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            MessageBox.Show("SZANOWNY PANIE DOKTORZE\nWiem, �e projekt mia� mie� plansz� kwadratow� i wiem, �e udziwniam go dodaj�c poziom trudno�ci oraz obrazki w miejscach ikonek, ale bardzo chcia�am nauczy� si� w tym projekcie czego� wi�cej i aby moje portfolio na githubie by�o bardziej zaawansowane. Zrobi�am r�wnie� w zalezno�ci od poziomu trudno�ci limit ruch�w a nie limit czasowy. Je�li jest to niezgodne z wymaganiami, mog� cofn�� projekt do wersji podstawowej");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Int32.TryParse(tbxSize.Text, out int size);


            if (size > 2 && size<=20 && level.SelectedIndex > -1)
            {
                int gameLevel = level.SelectedIndex;
                Game game = new Game(size, gameLevel);
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