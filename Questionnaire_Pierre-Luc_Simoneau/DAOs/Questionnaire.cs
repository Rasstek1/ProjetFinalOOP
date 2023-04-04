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
        public User User { get; set; }
        public List<Question> Questions { get; set; }

        public Questionnaire()
        {
            Id = ++count;
            Questions = new List<Question>();
        }
        public void AjouterQuestion(Question q)
        {
            Questions.Add(q);
        }
        public bool VerifierScore()
        {
            return ScoreObtenu >= ScoreDePassage;
        }
        public override string ToString()
        {
            return Id + ";" +                
                ScoreDePassage + ";" +
                ScoreObtenu + ";" +
                User.Login;
        }
    }
}
