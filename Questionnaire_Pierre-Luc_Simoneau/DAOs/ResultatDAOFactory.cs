using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questionnaire_Pierre_Luc_Simoneau.DAOs
{
    internal class ResultatDAOFactory
    {
        public static IResultatDAO CreerResultatDAO(string type)
        {
            if (type == "FILE") return new ResultatDaoFile();
            else return new ResultatDaoBD();
        }
    }
}
