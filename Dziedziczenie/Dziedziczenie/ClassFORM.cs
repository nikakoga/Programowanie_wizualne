using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Dziedziczenie
{
    public abstract class ClassFORM
    {
        public int StudentID;
        public string ThesisTitle, FieldOfStudy, AreaOfStudy;
        public string studyProfile, studyForm, studyLevel;
        //study profilem form i level w 2 na 3

        public void Save (TopicCard card=null, ExamProtocol protocol=null, Opinion opinion=null)
        {
            if(card != null)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "XML|*.xml";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    XmlSerializer mySerializer = new XmlSerializer(typeof(ClassTOPIC));
                    StreamWriter myWriter = new StreamWriter(sfd.FileName);
                    mySerializer.Serialize(myWriter, card);
                    myWriter.Close();
                }
            }
            if(protocol != null) 
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "XML|*.xml";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    XmlSerializer mySerializer = new XmlSerializer(typeof(ClassPROTOCOL));
                    StreamWriter myWriter = new StreamWriter(sfd.FileName);
                    mySerializer.Serialize(myWriter, protocol);
                    myWriter.Close();
                }
            }
            if(opinion != null)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "XML|*.xml";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    XmlSerializer mySerializer = new XmlSerializer(typeof(ClassOPINION));
                    StreamWriter myWriter = new StreamWriter(sfd.FileName);
                    mySerializer.Serialize(myWriter, opinion);
                    myWriter.Close();
                }
            }

            
        }

        
    }
}
