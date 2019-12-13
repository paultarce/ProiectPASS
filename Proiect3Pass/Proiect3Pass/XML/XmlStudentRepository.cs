using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Proiect3Pass.XML
{
    public class XmlStudentRepository : IStudentRepository
    {
        public void ActualizeazaStudent(Studenti student)
        {
            throw new NotImplementedException();
        }

        public List<Studenti> GetAllStudents() //folosesc doar asta la XML
        {
            List<Studenti> studenti = new List<Studenti>();

            // Start with XmlReader object  
            //here, we try to setup Stream between the XML file nad xmlReader  
            using (XmlReader reader = XmlReader.Create(@"D:\Cursuri\Master II\PASS\Proiect PASS\ProiectPASS\Proiect3Pass\Proiect3Pass\StudentiXML.xml"))
            {
                Studenti student = new Studenti();
                while (reader.Read())
                {
                    if (reader.IsStartElement())
                    {

                        
                        //return only when you have START tag  
                        switch (reader.Name.ToString())
                        {
                            case "NrMatricol":
                                student = new Studenti();
                                student.NrMatricol = Convert.ToInt32( reader.ReadString());
                                break;
                            case "Nume":
                                student.Nume = reader.ReadString();
                                break;
                            case "Media":
                                student.Medie = double.Parse( reader.ReadString());

                                studenti.Add(student);
                                break;
                        }
                    }
                    Console.WriteLine("");
                }
            }
            return studenti;
        } 

        public void InserareStudent(Studenti student)
        {
            throw new NotImplementedException();
        }

        public void StergereStudent(Studenti student)
        {
            throw new NotImplementedException();
        }
    }
}
