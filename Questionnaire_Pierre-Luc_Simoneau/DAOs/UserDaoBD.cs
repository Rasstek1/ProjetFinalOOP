using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questionnaire_Pierre_Luc_Simoneau.DAOs
{
    public class UserDaoBD : IUserDAO
    {
        public void Ajouter(User u)
        {
            throw new NotImplementedException();
        }

        public User ChercherParLogin(string login)
        {
            throw new NotImplementedException();
        }

        public User ChercherParLoginMPType(string login, string mp, bool type)
        {
            throw new NotImplementedException();
        }

        public List<User> ChercherTout()
        {
            throw new NotImplementedException();
        }

        public void Modifier(User u)
        {
            throw new NotImplementedException();
        }

        public void Supprimer(User u)
        {
            throw new NotImplementedException();
        }
    }
}
