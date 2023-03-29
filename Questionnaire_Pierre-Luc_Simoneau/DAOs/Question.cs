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
        

        public int Id { get; private set; }
        public string Enonce { get; set; }
        public bool Type { get; set;}
        public bool ReponseVF { get; set; }
        public List<string> PropositionSM { get; set; }
        public List<string> ReponseSM { get; set; }
        


    }
}
