using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questionnaire_Pierre_Luc_Simoneau.DAOs
{
    public class User
    {
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Telephone { get; set; }
        public bool Type { get; set; }
        public int AdrNum { get; set; }
        public string AdrRue { get; set; }
        public string AdrVille { get; set; }
        public string AdrProvince { get; set; }
        public string AdrCP { get; set; }
        public string Login { get; set; }
        public string MotPasse { get; set; }

        public User(string nom, string prenom, string telephone, bool type, int adrNum, string adrRue, string adrVille, string adrProvince, string adrCP, string login, string motPasse)
        {
            Nom = nom;
            Prenom = prenom;
            Telephone = telephone;
            Type = type;
            AdrNum = adrNum;
            AdrRue = adrRue;
            AdrVille = adrVille;
            AdrProvince = adrProvince;
            AdrCP = adrCP;
            Login = login;
            MotPasse = motPasse;
        }
        public User()
        {

        }

        public override bool Equals(object? obj)
        {
            return obj is User u && u.Login==Login;
        }
        public override string ToString()
        {
            return Nom + ";"+
                Prenom + ";" +
                Telephone + ";" +
                Type + ";" +
                AdrNum + ";" +
                AdrRue + ";" +
                AdrVille + ";" +
                AdrProvince + ";" +
                AdrCP + ";" +
                Login + ";" +
                MotPasse;
        }

    }
}
