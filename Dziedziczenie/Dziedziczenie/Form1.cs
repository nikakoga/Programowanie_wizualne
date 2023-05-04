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
                        PromorsOpinion promotorsOpinion = new PromorsOpinion();
                        promotorsOpinion.Show();
                        break;
                    }
                    case 2:
                    { 
                        ReviewersOpinion reviewersOpinion = new ReviewersOpinion();
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
                        MessageBox.Show("First Select witch form to open");
                        break;
                    }

            }

        }
    }
}