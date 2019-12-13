using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect3Pass.AlgoritmiPreziceri
{
    public class PreziceriAlgo
    {

        public PreziceriAlgo()
        {

        }
        public static bool PrezicereMedie(Studenti student)
        {
            int sumaCaractere = 0;
            string nrMatricolString = student.NrMatricol.ToString();
            byte[] asciiNrMatricol = Encoding.ASCII.GetBytes(nrMatricolString);

            for (int i = 0; i < nrMatricolString.Length; i++)
            {
                sumaCaractere += asciiNrMatricol[i];
            }

            byte[] asciiNume = Encoding.ASCII.GetBytes(student.Nume);

            for(int j = 0; j < student.Nume.Length; j++)
            {
                sumaCaractere += asciiNume[j];
            }

            if(sumaCaractere % 2 == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
          
        }
        public static int PrezicereNrMediiScazute()
        {
            return 0;
        }

        public static bool PrezicereTipZi(Studenti student)
        {
            int d = (int)System.DateTime.Now.Day;

            byte asciiNume = Encoding.ASCII.GetBytes(student.Nume)[0];

            int prezicere = d + asciiNume;

            if (prezicere % 2 == 1)
                return true;
            else
                return false;

        }
    }
}
