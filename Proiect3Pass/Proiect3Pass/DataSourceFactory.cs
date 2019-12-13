using Proiect3Pass.DbEF;
using Proiect3Pass.XML;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect3Pass
{
    public class DataSourceFactory
    {
        public static IStudentRepository getDataSource(string dataSourceString)
        {
            IStudentRepository retDataSource = null;

            if (dataSourceString == "SQL")
                return new EFStudentRepository();
            else if (dataSourceString == "XML")
                return new XmlStudentRepository();
            else
                return new EFStudentRepository();
        }
    }
}
