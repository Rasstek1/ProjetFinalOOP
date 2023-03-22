using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questionnaire_Pierre_Luc_Simoneau.DAOs
{
    public interface IUserDAO
    {
        void Ajouter(User u);
        void Supprimer(User u);
        void Modifier(User u);
        List<User>? ChercherTout();
        User? ChercherParLogin(string login);
        User? ChercherParLoginMPType(string login, string mp, bool type);

    }
}
