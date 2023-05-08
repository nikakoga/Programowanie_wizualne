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
            Data.StudentID = StudentIDTextBox.Text;

            // From FormDataOpinion
            Data.Who = ReviewerTextBox.Text;
            Data.Unit = UnitTextBox.Text;
            Data.Degree = DegreeCandidateTextBox.Text;
            Data.A = GradeATextBox.Text;
            Data.B = GradeBTextBox.Text;
            Data.C = GradeCTextBox.Text;
            Data.D = GradeDTextBox.Text;
            Data.E = GradeETextBox.Text;
            Data.F = GradeFTextBox.Text;
            Data.G = GradeGTextBox.Text;
            Data.Summary = SummaryTextBox.Text;
            Data.GradeLetter = GradeLetterTextBox.Text;
            Data.Grade = GradeNumericalTextBox.Text;

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
