using Dziedziczenie.Models;

namespace Dziedziczenie
{
    public partial class TopicCard : Form
    {
        private FormDataTopic Data { get; set; }

        public TopicCard()
        {
            InitializeComponent();
            Data = new FormDataTopic()
            {
                Students = new string[4],
                StudentsID = new int[4],
            };
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            // From FormDataBase
            Data.AreaOfStudy = AreaOfStudyTextBox.Text;
            Data.FieldOfStudy = FieldOfStudyTextBox.Text;
            Data.ThesisTitle = ThesisTitleTextBox.Text;

            // From FormDataProtocolBase
            Data.StudyForm = FormOfStudiesTextBox.Text;
            Data.StudyLevel = LevelOfStudiesTextBox.Text;
            Data.StudyProfile = ProfileOfStudyTextBox.Text;

            // From FormDataTopic
            Data.University = UniversityTextBox.Text;
            Data.EnglishTitle = EnglishTitleTextBox.Text;
            Data.InputData = InputTextBox.Text;
            Data.Scope = ScopeTextBox.Text;
            Data.Deadline = DeadlineTextBox.Text;
            Data.Supervisor = SupervisorTextBox.Text;
            Data.Unit = SupervisorUnitTextBox.Text;

            Data.Students[0] = student0.Text;
            Data.Students[1] = student1.Text;
            Data.Students[2] = student2.Text;
            Data.Students[3] = student3.Text;

            Data.StudentsID[0] = Convert.ToInt32(student0ID.Text);
            Data.StudentsID[1] = Convert.ToInt32(student1ID.Text);
            Data.StudentsID[2] = Convert.ToInt32(student2ID.Text);
            Data.StudentsID[3] = Convert.ToInt32(student3ID.Text);

            Data.Save();
        }

        private void ReadButton_Click(object sender, EventArgs e)
        {
            if (Data.Load())
            {
                // From FormDataBase
                AreaOfStudyTextBox.Text = Data.AreaOfStudy;
                FieldOfStudyTextBox.Text = Data.FieldOfStudy;
                ThesisTitleTextBox.Text = Data.ThesisTitle;

                // From FormDataProtocolBase
                FormOfStudiesTextBox.Text = Data.StudyForm;
                LevelOfStudiesTextBox.Text = Data.StudyLevel;
                ProfileOfStudyTextBox.Text = Data.StudyProfile;

                // From FormDataTopic
                UniversityTextBox.Text = Data.University;
                EnglishTitleTextBox.Text = Data.EnglishTitle;
                InputTextBox.Text = Data.InputData;
                ScopeTextBox.Text = Data.Scope;
                DeadlineTextBox.Text = Data.Deadline;
                SupervisorTextBox.Text = Data.Supervisor;
                SupervisorUnitTextBox.Text = Data.Unit;

                student0.Text = Data.Students[0];
                student1.Text = Data.Students[1];
                student2.Text = Data.Students[2];
                student3.Text = Data.Students[3];

                student0ID.Text = Data.StudentsID[0].ToString();
                student1ID.Text = Data.StudentsID[1].ToString();
                student2ID.Text = Data.StudentsID[2].ToString();
                student3ID.Text = Data.StudentsID[3].ToString();
            }
        }
    }
}
