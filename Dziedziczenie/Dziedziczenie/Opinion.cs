using Dziedziczenie.Models;

namespace Dziedziczenie
{
    public partial class Opinion : Form
    {
        private FormDataOpinion Data { get; set; }

        public Opinion(string who)
        {
            InitializeComponent();
            Data = new FormDataOpinion()
            {
                Who = who,
            };
            label3.Text = who;
            label1.Text = who + "'s Opinion on the Engineering Diploma Thesis";
            label2.Text = "INFORMATION ON THE " + who.ToUpper();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            // From FormDataBase
            Data.AreaOfStudy = AreaOfStudyTextBox.Text;
            Data.FieldOfStudy = FieldOfStudyTextBox.Text;
            Data.ThesisTitle = TitleOfTheThesisTextBox.Text;
            Data.StudentID = Convert.ToInt32(StudentIDTextBox.Text);

            // From FormDataOpinion
            Data.Who = ReviewerTextBox.Text;
            Data.Unit = UnitTextBox.Text;
            Data.Degree = DegreeCandidateTextBox.Text;
            Data.A = Convert.ToInt32(GradeATextBox.Text);
            Data.B = Convert.ToInt32(GradeBTextBox.Text);
            Data.C = Convert.ToInt32(GradeCTextBox.Text);
            Data.D = Convert.ToInt32(GradeDTextBox.Text);
            Data.E = Convert.ToInt32(GradeETextBox.Text);
            Data.F = Convert.ToInt32(GradeFTextBox.Text);
            Data.G = Convert.ToInt32(GradeGTextBox.Text);
            Data.Summary = SummaryTextBox.Text;
            Data.GradeLetter = GradeLetterTextBox.Text;
            Data.Grade = Convert.ToInt32(GradeNumericalTextBox.Text);

            Data.Save();
        }

        private void ReadButton_Click(object sender, EventArgs e)
        {
            if (Data.Load())
            {
                // From FormDataBase
                AreaOfStudyTextBox.Text = Data.AreaOfStudy;
                FieldOfStudyTextBox.Text = Data.FieldOfStudy;
                TitleOfTheThesisTextBox.Text = Data.ThesisTitle;
                StudentIDTextBox.Text = Data.StudentID.ToString();

                // From FormDataOpinion
                ReviewerTextBox.Text = Data.Who;
                UnitTextBox.Text = Data.Unit;
                DegreeCandidateTextBox.Text = Data.Degree;
                GradeATextBox.Text = Data.A.ToString();
                GradeBTextBox.Text = Data.B.ToString();
                GradeCTextBox.Text = Data.C.ToString();
                GradeDTextBox.Text = Data.D.ToString();
                GradeETextBox.Text = Data.E.ToString();
                GradeFTextBox.Text = Data.F.ToString();
                GradeGTextBox.Text = Data.G.ToString();
                SummaryTextBox.Text = Data.Summary;
                GradeLetterTextBox.Text = Data.GradeLetter;
                GradeNumericalTextBox.Text = Data.Grade.ToString();
            }
        }
    }
}
