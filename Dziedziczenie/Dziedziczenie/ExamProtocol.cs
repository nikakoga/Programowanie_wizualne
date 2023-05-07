namespace Dziedziczenie
{
    public partial class ExamProtocol : ClassPROTOCOL
    {
        public ExamProtocol()
        {
            InitializeComponent();
        }


        private void ReadButton_Click(object sender, EventArgs e)
        {

        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            //From ClassFORM
            this.AreaOfStudy = AreaOfStudyTextBox.Text;
            this.studyForm = FormOfStudiesTextBox.Text;
            this.studyLevel = LevelOfStudiesTextBox.Text;
            this.FieldOfStudy = FieldOfStudyTextBox.Text;
            this.ThesisTitle = TitleOfDiplomaThesisTextBox.Text;
            this.studyProfile = ProfileOfStudyTextBox.Text;
            this.StudentID = Convert.ToInt32(StudentIDTextBox.Text);

            //From ClassPROTOCOL
            this.nameSurname = NameSurenameTextBox.Text;
            this.dateBirth = DateOfBirthTextBox.Text;
            this.placeBirth = PlaceOfBirthTextBox.Text;
            this.dateExamination = DateOfDiplomaExaminationTextBox.Text;
            this.dateCommencement = DateOfStudyCommencementTextBox.Text;
            this.chairperson = ChairpersonTextBox.Text;
            this.supervisor = SupervisorTextBox.Text;
            this.reviewer = ReviewerTextBox.Text;
            this.defenseGrade = Convert.ToDouble(DefenseOfDiplomaThesisTextBox.Text);
            this.diplomaGrade = Convert.ToDouble(DiplomaExaminationGradeTextBox.Text);

            this.questions[0] = Question1TextBox.Text;
            this.questions[1] = Question2TextBox.Text;
            this.questions[2] = Question3TextBox.Text;

            this.questionGrade[0] = Convert.ToDouble(QuestionGrade1TextBox.Text);
            this.questionGrade[1] = Convert.ToDouble(QuestionGrade2TextBox.Text);
            this.questionGrade[2] = Convert.ToDouble(QuestionGrade2TextBox.Text);

            this.weightAverage = Convert.ToDouble(weightAverageTextBox.Text);
            this.weightthesis = Convert.ToDouble(weightThesisTextBox.Text);
            this.weightexam = Convert.ToDouble(weightexamTextBox.Text);
            this.weightx06 = Convert.ToDouble(weightx06TextBox.Text);
            this.weightx02thesis = Convert.ToDouble(weightx02thesisTextBox.Text);
            this.weightx02examx = Convert.ToDouble(weightx02examxTextBox.Text);
            this.resultWord = resultWordTextBox.Text;
            this.resultLetter = resultLetterTextBox.Text;
            this.resultNumber = Convert.ToDouble(resultNumberTextBox.Text);

            this.Save();
        }
    }
}
