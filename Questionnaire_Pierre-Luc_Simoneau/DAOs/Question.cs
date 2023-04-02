using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questionnaire_Pierre_Luc_Simoneau.DAOs
{
    internal class Question
    {
        static int count = 0;
        

        public int Id { get; internal set; }
        public string Enonce { get; set; }
        public bool Type { get; set;}
        public bool ReponseVF { get; set; }
        public List<string>? PropositionSM { get; set; }
        public List<string>? ReponseSM { get; set; }
        public string TypeDisplay => Type ? "Vrai/Faux" : "Choix multiple";
        public string PropositionsDisplay => Type ? "" : string.Join(", ", PropositionSM);
        public string ReponsesDisplay => Type ? (ReponseVF ? "Vrai" : "Faux") : string.Join(", ", ReponseSM);

        public Question()
        {
            Id = ++count;
        }
        private Question(string enonce, bool type):this()
        {            
            Enonce = enonce;
            Type = type;
        }
        public Question(string enonce, bool type,bool reponseVF) : this(enonce, type)
        {
            ReponseVF = reponseVF;
        }
        public Question(string enonce, bool type,List<string> propositionSM, List<string> reponseSM) : this(enonce, type)
        {
            PropositionSM = propositionSM;
            ReponseSM = reponseSM;
        }
        

        public override bool Equals(object? obj)
        {
            return obj is Question q && q.Id == Id;
        }

        public override string ToString()
        {
           return Id + ";" +
           Enonce + ";" +
           TypeDisplay + ";" +
           ReponseVF + ";" +
           PropositionsDisplay + ";" +
           ReponsesDisplay;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id, Enonce, Type, ReponseVF, PropositionSM, ReponseSM);
        }
    }
}
