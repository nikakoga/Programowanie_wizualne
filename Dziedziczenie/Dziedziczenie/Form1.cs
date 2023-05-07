namespace Dziedziczenie
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void OpenForms_Click(object sender, EventArgs e)
        {
            var Selected = FormOptions.SelectedIndex;
            switch(Selected)
            {
                case 0:
                    {
                        TopicCard topicCard = new TopicCard();
                        topicCard.Show();
                        break;
                    }
                case 1:
                    {
                        string who = "Supervisor";
                        Opinion promotorsOpinion = new Opinion(who);
                        promotorsOpinion.Show();
                        break;
                    }
                    case 2:
                    {
                        string who = "Reviewer";
                        Opinion reviewersOpinion = new Opinion(who);
                        reviewersOpinion.Show();
                        break;
                    }
                    case 3:
                    {
                        ExamProtocol examProtocol = new ExamProtocol();
                        examProtocol.Show();
                        break;
                    }
                default:
                    {
                        MessageBox.Show("First select witch form to open");
                        break;
                    }

            }

        }
    }
}