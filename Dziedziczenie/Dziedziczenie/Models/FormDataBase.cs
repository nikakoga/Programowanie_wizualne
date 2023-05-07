using System.Xml.Serialization;

namespace Dziedziczenie.Models
{
    public abstract class FormDataBase
    {
        public int StudentID;
        public string ThesisTitle, FieldOfStudy, AreaOfStudy;

        public virtual void Save()
        {
            Type t = this.GetType();
            if (t != null)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "XML|*.xml";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    XmlSerializer serializer = new XmlSerializer(t);
                    using StreamWriter writer = new StreamWriter(sfd.FileName);
                    serializer.Serialize(writer, this);
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns>True if load was alright, false if anything went wrong</returns>
        public bool Load()
        {
            Type t = this.GetType();
            if (t != null)
            {
                OpenFileDialog sfd = new OpenFileDialog();
                sfd.Filter = "XML|*.xml";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    XmlSerializer serializer = new XmlSerializer(t);
                    FileStream fs = new FileStream(sfd.FileName, FileMode.Open);

                    FormDataBase fdb = (FormDataBase)serializer.Deserialize(fs);
                    StudentID = fdb.StudentID;
                    AreaOfStudy = fdb.AreaOfStudy;
                    ThesisTitle = fdb.ThesisTitle;
                    FieldOfStudy = fdb.FieldOfStudy;

                    OnLoad(fdb);
                    return true;
                }
            }
            return false;
        }

        protected abstract void OnLoad(FormDataBase obj);
    }
}
