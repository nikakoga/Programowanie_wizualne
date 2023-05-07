namespace Dziedziczenie.Models
{
    public class FormDataTopic : FormDataProtocolBase
    {
        public string University;
        public string[] Students;
        public int[] StudentsID;
        public string EnglishTitle, InputData, Scope, Deadline, Supervisor, Unit;

        protected override void OnLoad(FormDataBase obj)
        {
            base.OnLoad(obj);
            if (obj is FormDataTopic fdt)
            {
                University = fdt.University;
                Students = fdt.Students;
                StudentsID = fdt.StudentsID;
                EnglishTitle = fdt.EnglishTitle;
                InputData = fdt.InputData;
                Scope = fdt.Scope;
                Deadline = fdt.Deadline;
                Supervisor = fdt.Supervisor;
                Unit = fdt.Unit;
            }
        }
    }
}
