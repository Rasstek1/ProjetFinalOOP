using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Questionnaire_Pierre_Luc_Simoneau.DAOs
{
    internal class QuestionDaoFile : IQuestionDAO
    {
        private string path = @"..\..\..\FILES\questions.txt";
        public void Ajouter(Question q)
        {

                q.Id = GenerateUniqueId();
                string contenu = q.ToString() + "\n";
                File.AppendAllText(path, contenu);
            
        }

        public Question? ChercherParId(int id)
        {
            List<Question> questions = ChercherTout();
            Console.WriteLine("List of questions:");
            
            return questions.Find(q => q.Id == id);
        }

        public List<Question>? ChercherTout()
        {
            //copy ChercherTout from UserDaoFile and modify it to work with Question
            List<string> tab = File.ReadAllLines(path).ToList();
            List<Question> listeQuestion = new List<Question>();
            foreach (string line in tab)
            {
                //décomposé la ligne selon le séparateur
                string[] tabDecomposer = line.Split(";");
                //créer question
                Question q = new Question();
                q.Id = int.Parse(tabDecomposer[0]);
                q.Enonce = tabDecomposer[1];
                q.Type = bool.Parse(tabDecomposer[2]);
                q.ReponseVF = bool.Parse(tabDecomposer[3]);
                q.PropositionSM = tabDecomposer[4].Split(",").ToList();
                q.ReponseSM = tabDecomposer[5].Split(",").ToList();                
                listeQuestion.Add(q);
            }
            return listeQuestion;


        }

        public void Modifier(Question q)
        {
            Supprimer(q);
            Ajouter(q);
        }

        public void Supprimer(Question q)
        {
            List<Question> questions = ChercherTout();
            questions.Remove(q);
            File.WriteAllText(path, "");
            foreach (Question question in questions)
            {
                Ajouter(question);
            }
            
        }
        private int GenerateUniqueId()
        {
            List<Question> questions = ChercherTout();
            if (questions.Count == 0)
            {
                return 1;
            }
            else
            {
                int currentId = 1;
                bool foundUnusedId = false;

                while (!foundUnusedId)
                {
                    foundUnusedId = true;
                    foreach (Question q in questions)
                    {
                        if (q.Id == currentId)
                        {
                            foundUnusedId = false;
                            currentId++;
                            break;
                        }
                    }
                }

                return currentId;
            }
        }


    }
}
