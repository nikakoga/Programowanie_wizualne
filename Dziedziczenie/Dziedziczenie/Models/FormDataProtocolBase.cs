namespace Dziedziczenie.Models
{
    public abstract class FormDataProtocolBase : FormDataBase
    {
        public string StudyProfile, StudyForm, StudyLevel;

        protected override void OnLoad(FormDataBase obj)
        {
            if (obj is FormDataProtocolBase fdpb)
            {
                StudyProfile = fdpb.StudyProfile;
                StudyForm = fdpb.StudyForm;
                StudyLevel = fdpb.StudyLevel;
            }
        }
    }
}
