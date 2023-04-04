using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questionnaire_Pierre_Luc_Simoneau.DAOs
{
    public class Questionnaire
    {
        private int count = 0;
        public int Id { get; internal set; }
        public int ScoreObtenu { get; set; } = 0;
        public int ScoreDePassage { get; set; }
        public string UserLogin { get; set; }
        public List<Question> Questions { get; set; }

        public Questionnaire()
        {
            Id = ++count;
            Questions = new List<Question>();
        }
        
        public Questionnaire(int nbrQuestions, int scoreDePassage, User loggedInUser):this()
        {
            GenererQuestionnaire(nbrQuestions, scoreDePassage, loggedInUser);
        }
        public void AjouterQuestion(Question q)
        {
            Questions.Add(q);
        }
        public string VerifierScore()
        {
            if( ScoreObtenu >= ScoreDePassage) return "Réussi";
            else return "Échoué";
        }
        public override string ToString()
        {
            return Id + ";" +                
                ScoreDePassage + ";" +
                ScoreObtenu + ";" +
                UserLogin +";"+
                VerifierScore();
        }
        public void GenererQuestionnaire(int nbrQuestions, int scoreDePassage, User loggedInUser)
        {
            List<Question> questions = QuestionDAOFactory.CreerQuestionDAO("FILE").ChercherTout();

            // Mélanger les questions en les triant selon un nombre aléatoire généré pour chaque question
            Random random = new Random();
            List<Question> shuffledQuestions = questions.OrderBy(q => random.Next()).ToList();

            //.take() prend la quantité demandé d'une liste, ou toute la liste si la quantité est insufisante
            this.Questions = shuffledQuestions.Take(nbrQuestions).ToList();
            this.UserLogin = loggedInUser.Login;
            if (scoreDePassage > this.Questions.Count) scoreDePassage = this.Questions.Count;
            this.ScoreDePassage = scoreDePassage;
        }
    }
}
