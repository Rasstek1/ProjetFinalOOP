using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questionnaire_Pierre_Luc_Simoneau.DAOs
{
    internal interface IQuestionDAO
    {
        void Ajouter(Question q);
        void Supprimer(Question q);
        void Modifier(Question q);
        List<Question>? ChercherTout();
        Question? ChercherParId(int id);
    }
}
