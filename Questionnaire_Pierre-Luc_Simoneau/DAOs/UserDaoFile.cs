using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questionnaire_Pierre_Luc_Simoneau.DAOs
{
    public class UserDaoFile : IUserDAO
    {
        private string path = @"..\..\..\FILES\users.txt";
        public void Ajouter(User u)
        {
            if (ChercherParLogin(u.Login)==null)
            {
                string contenu = u.ToString() + "\n";
                File.AppendAllText(path, contenu);
            }

        }

        public User? ChercherParLogin(string login)
        {
            List<User> users = ChercherTout();
            return users.Find(u => u.Login == login);
        }

        public User? ChercherParLoginMPType(string login, string mp, bool type)
        {
            List<User> users = ChercherTout();
            return users.Find(u => u.Login == login && u.MotPasse == mp && u.Type);
        }

        public List<User> ChercherTout()
        {
            List<string> tab = File.ReadAllLines(path).ToList();
            List<User> listeUsers = new List<User>();
            foreach(string line in tab)
            {
                //décomposé la ligne selon le séparateur
                string[] tabDecomposer = line.Split(";");
                //créer User
                User u = new User();
                u.Nom = tabDecomposer[0];
                u.Prenom = tabDecomposer[1];
                u.Telephone = tabDecomposer[2];
                u.Type = bool.Parse(tabDecomposer[3]);
                u.AdrNum = int.Parse(tabDecomposer[4]);
                u.AdrRue = tabDecomposer[5];
                u.AdrVille = tabDecomposer[6];
                u.AdrProvince = tabDecomposer[7];
                u.AdrCP = tabDecomposer[8];
                u.Login = tabDecomposer[9];
                u.MotPasse = tabDecomposer[10];
                listeUsers.Add(u);                
            }

            return listeUsers;
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
