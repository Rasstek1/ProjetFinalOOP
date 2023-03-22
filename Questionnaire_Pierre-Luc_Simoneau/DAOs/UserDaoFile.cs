using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questionnaire_Pierre_Luc_Simoneau.DAOs
{
    public class UserDaoFile : IUserDAO
    {
        public void Ajouter(User u)
        {
            throw new NotImplementedException();
        }

        public User? ChercherParLogin(string login)
        {
            List<User> users = ChercherTout();
            return users.Find(u => u.Login == login);
        }

        public User? ChercherParLoginMPType(string login, string mp, bool type)
        {
            List<User> users = ChercherTout();
            return users.Find(u => u.Login == login && u.MotPasse==mp && u.Type);
        }

        public List<User> ChercherTout()
        {
            throw new NotImplementedException();
        }

        public void Modifier(User u)
        {
            Supprimer(u);
            Ajouter(u);
        }

        public void Supprimer(User u)
        {
            throw new NotImplementedException();
        }
    }
}
