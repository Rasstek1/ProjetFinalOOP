using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questionnaire_Pierre_Luc_Simoneau.DAOs
{
    internal class QuestionDAOFactory
    {
        public static IQuestionDAO CreerQuestionDAO(string type)
        {
            if (type == "FILE") return new QuestionDaoFile();
            else return new QuestionDaoBD();
        }
    }
}
