using Questionnaire_Pierre_Luc_Simoneau.DAOs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Questionnaire_Pierre_Luc_Simoneau
{
    public partial class ModifierUtilisateur : UserControl
    {
        public ModifierUtilisateur()
        {
            InitializeComponent();
        }

        private void btnChercher_Click(object sender, EventArgs e)
        {
            string login = txtChercherLogin.Text;
            User user = UserDAOFactory.CreerUserDAO("FILE").ChercherParLogin(login);
            if(user == null)
            {
                MessageBox.Show("Aucun utilisateur trouvé");
            }
            else
            {
                textBoxNom.Text = user.Nom;
                textBoxPrenom.Text = user.Prenom;
                textBoxTelephone.Text = user.Telephone;
                if(user.Type == true) radioButtonAdmin.Checked = true;
                else radioButtonUser.Checked = true;
                textBoxAdrNum.Text = user.AdrNum.ToString();
                textBoxAdrRue.Text = user.AdrRue;
                textBoxAdrVille.Text = user.AdrVille;
                textBoxAdrProvince.Text = user.AdrProvince;
                textBoxCP.Text = user.AdrCP;
                textBoxLogin.Text = user.Login;
                textBoxMP.Text = user.MotPasse;
            }
        }
    }
}
