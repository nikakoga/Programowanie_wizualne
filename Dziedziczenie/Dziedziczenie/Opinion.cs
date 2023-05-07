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
    public partial class Opinion : ClassOPINION
    {
        public Opinion(string who)
        {
            InitializeComponent();
            label3.Text = who;
            label1.Text = who + "'s Opinion on the Engineering Diploma Thesis";
            label2.Text = "INFORMATION ON THE " + who.ToUpper();

        }

        private void SaveButton_Click(object sender, EventArgs e)
        {   
            //From ClassFORM
            this.AreaOfStudy = AreaOfStudyTextBox.Text;
            this.FieldOfStudy = FieldOfStudyTextBox.Text;
            this.ThesisTitle = TitleOfTheThesisTextBox.Text;
            this.StudentID = Convert.ToInt32(StudentIDTextBox.Text);

            //From ClassOPINION
            this.who = ReviewerTextBox.Text;
            this.unit = UnitTextBox.Text;
            this.degree=DegreeCandidateTextBox.Text;
            this.A=Convert.ToInt32(GradeATextBox.Text);
            this.B= Convert.ToInt32(GradeBTextBox.Text);
            this.C = Convert.ToInt32(GradeCTextBox.Text);
            this.D = Convert.ToInt32(GradeDTextBox.Text);
            this.E = Convert.ToInt32(GradeETextBox.Text);
            this.F = Convert.ToInt32(GradeFTextBox.Text);
            this.G = Convert.ToInt32(GradeGTextBox.Text);
            this.summary = SummaryTextBox.Text;
            this.gradeLetter= GradeLetterTextBox.Text;
            this.grade=Convert.ToInt32(GradeNumericalTextBox.Text);

            Save();
        }
    }
}
