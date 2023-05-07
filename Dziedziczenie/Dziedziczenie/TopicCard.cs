using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dziedziczenie
{
    public partial class TopicCard : ClassTOPIC
    {
        public TopicCard()
        {
            InitializeComponent();
            students = new string[4];
            studentsID = new int[4];
        }

        
        private void SaveButton_Click(object sender, EventArgs e)
        {

            //From ClassFORM
            this.AreaOfStudy = AreaOfStudyTextBox.Text;
            this.studyForm = FormOfStudiesTextBox.Text;
            this.studyLevel = LevelOfStudiesTextBox.Text;
            this.FieldOfStudy = FieldOfStudyTextBox.Text;
            this.ThesisTitle = ThesisTitleTextBox.Text;
            this.studyProfile = ProfileOfStudyTextBox.Text;

            //From ClassTOPIC
            this.university = UniversityTextBox.Text;
            this.englishTitle = EnglishTitleTextBox.Text;
            this.inputData = InputTextBox.Text;
            this.Scope = ScopeTextBox.Text;
            this.Deadline = DeadlineTextBox.Text;
            this.Supervisor = SupervisorTextBox.Text;
            this.Unit = SupervisorUnitTextBox.Text;

            this.students[0]=student0.Text;
            this.students[1]=student1.Text;
            this.students[2]=student2.Text;
            this.students[3]=student3.Text;

            this.studentsID[0] = Convert.ToInt32(student0ID.Text);
            this.studentsID[1] = Convert.ToInt32(student1ID.Text);
            this.studentsID[2] = Convert.ToInt32(student2ID.Text);
            this.studentsID[3] = Convert.ToInt32(student3ID.Text);

            this.Save();

        }
    }
}
