using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect3Pass.DbEF
{
    class EFStudentRepository : IStudentRepository
    {
        public void ActualizeazaStudent(Studenti student)
        {
            //EF Code
            using (PassDBEntities db = new PassDBEntities())
            {
                db.Entry(student).State = EntityState.Modified;
                db.SaveChanges();
            }
        }

        public List<Studenti> GetAllStudents()
        {
            using (PassDBEntities db = new PassDBEntities())
            {
                return db.Studenti.ToList();
            }
        }

        public void InserareStudent(Studenti student)
        {
            //EF Code
            using (PassDBEntities db = new PassDBEntities())
            {
                db.Studenti.Add(student);
                db.SaveChanges();

            }
        }

        public void StergereStudent(Studenti student)
        {
            //EF COde
            using (PassDBEntities db = new PassDBEntities())
            {
                var entry = db.Entry(student);
                if(entry.State == EntityState.Detached)
                {
                    db.Studenti.Attach(student);
                }
                db.Studenti.Remove(student);
                db.SaveChanges();
            }
        }
    }
}
