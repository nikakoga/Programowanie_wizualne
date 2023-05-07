using Dziedziczenie.Models;

namespace Dziedziczenie
{
    public partial class ExamProtocol : Form
    {
        private FormDataExamProtocol Data { get; set; }

        public ExamProtocol()
        {
            InitializeComponent();
            Data = new FormDataExamProtocol()
            {
                Questions = new string[3],
                QuestionGrade = new double[3],
            };
        }


        private void ReadButton_Click(object sender, EventArgs e)
        {
            if (Data.Load())
            {
                AreaOfStudyTextBox.Text = Data.AreaOfStudy;
                FormOfStudiesTextBox.Text = Data.StudyForm;
                LevelOfStudiesTextBox.Text = Data.StudyLevel;
                FieldOfStudyTextBox.Text = Data.FieldOfStudy;
                TitleOfDiplomaThesisTextBox.Text = Data.ThesisTitle;

                // From FormDataProtocolBase
                ProfileOfStudyTextBox.Text = Data.StudyProfile;
                StudentIDTextBox.Text = Data.StudentID.ToString();

                // From FormDataExamProtocol
                NameSurenameTextBox.Text = Data.NameSurname;
                DateOfBirthTextBox.Text = Data.DateBirth;
                PlaceOfBirthTextBox.Text = Data.PlaceBirth;
                DateOfDiplomaExaminationTextBox.Text = Data.DateExamination;
                DateOfStudyCommencementTextBox.Text = Data.DateCommencement;
                ChairpersonTextBox.Text = Data.ChairPerson;
                SupervisorTextBox.Text = Data.Supervisor;
                ReviewerTextBox.Text = Data.Reviewer;
                DefenseOfDiplomaThesisTextBox.Text = Data.DefenseGrade.ToString();
                DiplomaExaminationGradeTextBox.Text = Data.DiplomaGrade.ToString();

                Question1TextBox.Text = Data.Questions[0];
                Question2TextBox.Text = Data.Questions[1];
                Question3TextBox.Text = Data.Questions[2];

                QuestionGrade1TextBox.Text = Data.QuestionGrade[0].ToString();
                QuestionGrade2TextBox.Text = Data.QuestionGrade[1].ToString();
                QuestionGrade3TextBox.Text = Data.QuestionGrade[2].ToString();

                weightAverageTextBox.Text = Data.WeightAverage.ToString();
                weightThesisTextBox.Text = Data.WeightThesis.ToString();
                weightexamTextBox.Text = Data.WeightExam.ToString();
                weightx06TextBox.Text = Data.WeightX06.ToString();
                weightx02thesisTextBox.Text = Data.WeightX02Thesis.ToString();
                weightx02examxTextBox.Text = Data.WeightX02Exam.ToString();
                resultWordTextBox.Text = Data.ResultWord;
                resultLetterTextBox.Text = Data.ResultLetter;
                resultNumberTextBox.Text = Data.ResultNumber.ToString();
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            // From FormDataBase
            Data.AreaOfStudy = AreaOfStudyTextBox.Text;
            Data.StudyForm = FormOfStudiesTextBox.Text;
            Data.StudyLevel = LevelOfStudiesTextBox.Text;
            Data.FieldOfStudy = FieldOfStudyTextBox.Text;
            Data.ThesisTitle = TitleOfDiplomaThesisTextBox.Text;

            // From FormDataProtocolBase
            Data.StudyProfile = ProfileOfStudyTextBox.Text;
            Data.StudentID = Convert.ToInt32(StudentIDTextBox.Text);

            // From FormDataExamProtocol
            Data.NameSurname = NameSurenameTextBox.Text;
            Data.DateBirth = DateOfBirthTextBox.Text;
            Data.PlaceBirth = PlaceOfBirthTextBox.Text;
            Data.DateExamination = DateOfDiplomaExaminationTextBox.Text;
            Data.DateCommencement = DateOfStudyCommencementTextBox.Text;
            Data.ChairPerson = ChairpersonTextBox.Text;
            Data.Supervisor = SupervisorTextBox.Text;
            Data.Reviewer = ReviewerTextBox.Text;
            Data.DefenseGrade = Convert.ToDouble(DefenseOfDiplomaThesisTextBox.Text);
            Data.DiplomaGrade = Convert.ToDouble(DiplomaExaminationGradeTextBox.Text);

            Data.Questions[0] = Question1TextBox.Text;
            Data.Questions[1] = Question2TextBox.Text;
            Data.Questions[2] = Question3TextBox.Text;

            Data.QuestionGrade[0] = Convert.ToDouble(QuestionGrade1TextBox.Text);
            Data.QuestionGrade[1] = Convert.ToDouble(QuestionGrade2TextBox.Text);
            Data.QuestionGrade[2] = Convert.ToDouble(QuestionGrade3TextBox.Text);

            Data.WeightAverage = Convert.ToDouble(weightAverageTextBox.Text);
            Data.WeightThesis = Convert.ToDouble(weightThesisTextBox.Text);
            Data.WeightExam = Convert.ToDouble(weightexamTextBox.Text);
            Data.WeightX06 = Convert.ToDouble(weightx06TextBox.Text);
            Data.WeightX02Thesis = Convert.ToDouble(weightx02thesisTextBox.Text);
            Data.WeightX02Exam = Convert.ToDouble(weightx02examxTextBox.Text);
            Data.ResultWord = resultWordTextBox.Text;
            Data.ResultLetter = resultLetterTextBox.Text;
            Data.ResultNumber = Convert.ToDouble(resultNumberTextBox.Text);

            Data.Save();
        }
    }
}
