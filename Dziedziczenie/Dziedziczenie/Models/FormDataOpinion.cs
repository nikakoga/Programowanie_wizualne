namespace Dziedziczenie.Models
{
    public class FormDataOpinion : FormDataBase
    {
        public string Who, Unit, Degree;
        public string A, B, C, D, E, F, G;
        public string Summary, GradeLetter;
        public string Grade;

        protected override void OnLoad(FormDataBase obj)
        {
            if (obj is FormDataOpinion fdo)
            {
                Who = fdo.Who;
                Unit = fdo.Unit;
                Degree = fdo.Degree;
                A = fdo.A; B = fdo.B; C = fdo.C; D = fdo.D; E = fdo.E;  F = fdo.F; G = fdo.G;
                Summary = fdo.Summary;
                Grade = fdo.Grade;
                GradeLetter = fdo.GradeLetter;
            }
        }
    }
}
