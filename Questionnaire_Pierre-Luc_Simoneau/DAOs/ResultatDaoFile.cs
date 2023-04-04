using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questionnaire_Pierre_Luc_Simoneau.DAOs
{
    internal class ResultatDaoFile : IResultatDAO
    {
        private string path = @"..\..\..\FILES\resultats.txt";

        public void Ajouter(Questionnaire q)
        {
            List<string> tab = File.ReadAllLines(path).ToList();
            tab.Add(q.ToString());
            File.WriteAllLines(path, tab);
        }

        public List<Questionnaire>? ChercherTout()//use model from other daoFile to implement cherchertout() qith questionnaire class
        {
            List<string> tab = File.ReadAllLines(path).ToList();
            List<Questionnaire> listeQuestionnaire = new List<Questionnaire>();
            foreach (string line in tab)
            {
                //décomposé la ligne selon le séparateur
                string[] tabDecomposer = line.Split(";");
                //créer question
                Questionnaire q = new Questionnaire();
                q.Id = int.Parse(tabDecomposer[0]);
                q.ScoreDePassage = int.Parse(tabDecomposer[1]);
                q.ScoreObtenu = int.Parse(tabDecomposer[2]);
                q.UserLogin = tabDecomposer[3];                
                listeQuestionnaire.Add(q);
            }
            return listeQuestionnaire;
        }
    }
}
