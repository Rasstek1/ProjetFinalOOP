using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questionnaire_Pierre_Luc_Simoneau.DAOs
{
    public class UserDAOFactory
    {
        public static IUserDAO CreerUserDAO(string type)
        {
            if(type=="FILE") return new UserDaoFile();
            else return new UserDaoBD();
        }
    }
}
