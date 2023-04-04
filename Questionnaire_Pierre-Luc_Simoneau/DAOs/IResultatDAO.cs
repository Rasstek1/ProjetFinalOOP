using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questionnaire_Pierre_Luc_Simoneau.DAOs
{
    internal interface IResultatDAO
    {
        List<Questionnaire>? ChercherTout();
    }
}
