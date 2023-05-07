using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Dziedziczenie
{
    public abstract class ClassFORM : Form
    {
        protected int StudentID;
        protected string ThesisTitle, FieldOfStudy, AreaOfStudy;
        protected string studyProfile, studyForm, studyLevel;
        //study profilem form i level w 2 na 3

        protected virtual void Save()
        {
            Type t = this.GetType();
            if (t != null)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "XML|*.xml";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    XmlSerializer mySerializer = new XmlSerializer(t);
                    StreamWriter myWriter = new StreamWriter(sfd.FileName);
                    mySerializer.Serialize(myWriter, this);
                    myWriter.Close();
                }
            }
        }
        
    }
}
