using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect3Pass
{
    public interface IStudentRepository
    {

        void InserareStudent(Studenti student);
        void StergereStudent(Studenti student);

        void ActualizeazaStudent(Studenti student);

        List<Studenti> GetAllStudents();


    }

}
