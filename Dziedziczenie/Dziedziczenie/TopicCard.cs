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
    public partial class TopicCard : Form
    {
        ClassTOPIC topic;

        public TopicCard()
        {
            InitializeComponent();
            topic = new ClassTOPIC();
        }

        
        private void SaveButton_Click(object sender, EventArgs e)
        {

            //From ClassFORM
            topic.AreaOfStudy = AreaOfStudyTextBox.Text;
            topic.studyForm = FormOfStudiesTextBox.Text;
            topic.studyLevel = LevelOfStudiesTextBox.Text;
            topic.FieldOfStudy = FieldOfStudyTextBox.Text;
            topic.ThesisTitle = ThesisTitleTextBox.Text;
            topic.studyProfile = ProfileOfStudyTextBox.Text;

            //From ClassTOPIC
            topic.university = UniversityTextBox.Text;
            topic.englishTitle = EnglishTitleTextBox.Text;
            topic.inputData = InputTextBox.Text;
            topic.Scope = ScopeTextBox.Text;
            topic.Deadline = DeadlineTextBox.Text;
            topic.Supervisor = SupervisorTextBox.Text;
            topic.Unit = SupervisorUnitTextBox.Text;

            topic.students[2] = student2.Text;
            topic.students[3] = student3.Text;
            topic.students[0]=student0.Text;
            topic.students[1]=student1.Text;
            

            topic.studentsID[0] = Convert.ToDouble(student0ID.Text);
            topic.studentsID[1] = Convert.ToDouble(student1ID.Text);
            topic.studentsID[2] = Convert.ToDouble(student2ID.Text);
            topic.studentsID[3] = Convert.ToDouble(student3ID.Text);

            topic.Save(this);

        }
    }
}
