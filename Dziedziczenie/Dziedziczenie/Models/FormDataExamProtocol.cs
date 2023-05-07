namespace Dziedziczenie.Models
{
    public class FormDataExamProtocol : FormDataProtocolBase
    {
        public string NameSurname;
        public string PlaceBirth, DateBirth, DateExamination, DateCommencement;
        public string ChairPerson, Supervisor, Reviewer;
        public double DefenseGrade;
        public string[] Questions;
        public double[] QuestionGrade;
        public double DiplomaGrade;
        public double WeightAverage, WeightThesis, WeightExam, WeightX06, WeightX02Thesis, WeightX02Exam;
        public string ResultWord, ResultLetter;
        public double ResultNumber;

        protected override void OnLoad(FormDataBase obj)
        {
            base.OnLoad(obj);
            if (obj is FormDataExamProtocol fdep)
            {
                NameSurname = fdep.NameSurname;
                PlaceBirth = fdep.PlaceBirth;
                DateBirth = fdep.DateBirth;
                DateExamination = fdep.DateExamination;
                DateCommencement = fdep.DateCommencement;
                ChairPerson = fdep.ChairPerson;
                Supervisor = fdep.Supervisor;
                Reviewer = fdep.Reviewer;
                DefenseGrade = fdep.DefenseGrade;
                Questions = fdep.Questions;
                QuestionGrade = fdep.QuestionGrade;
                DiplomaGrade = fdep.DiplomaGrade;
                WeightAverage = fdep.WeightAverage;
                WeightThesis = fdep.WeightThesis;
                WeightExam = fdep.WeightExam;
                WeightX06 = fdep.WeightX06;
                WeightX02Thesis = fdep.WeightX02Thesis;
                WeightX02Exam = fdep.WeightX02Exam;
                ResultLetter = fdep.ResultLetter;
                ResultWord = fdep.ResultWord;
                ResultNumber = fdep.ResultNumber;
            }
        }
    }
}
