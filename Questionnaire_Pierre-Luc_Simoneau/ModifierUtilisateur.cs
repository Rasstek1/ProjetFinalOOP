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
            if (user == null)
            {
                MessageBox.Show("Aucun utilisateur trouvé");
            }
            else
            {
                textBoxNom.Text = user.Nom;
                textBoxPrenom.Text = user.Prenom;
                textBoxTelephone.Text = user.Telephone;
                if (user.Type == true) radioButtonAdmin.Checked = true;
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

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            textBoxNom.Text = string.Empty;
            textBoxPrenom.Text = string.Empty;
            textBoxTelephone.Text = string.Empty;
            radioButtonAdmin.Checked = false;
            radioButtonUser.Checked = false;
            textBoxAdrNum.Text = string.Empty;
            textBoxAdrRue.Text = string.Empty;
            textBoxAdrVille.Text = string.Empty;
            textBoxAdrProvince.Text = string.Empty;
            textBoxCP.Text = string.Empty;
            textBoxLogin.Text = string.Empty;
            textBoxMP.Text = string.Empty;
            txtChercherLogin.Text = string.Empty;
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            try
            {
                User u = new User();
                u.Nom = textBoxNom.Text;
                u.Prenom = textBoxPrenom.Text;
                u.Telephone = textBoxTelephone.Text;
                u.Type = (radioButtonUser.Checked == true) ? false : true;
                u.AdrNum = int.Parse(textBoxAdrNum.Text);
                u.AdrRue = textBoxAdrRue.Text;
                u.AdrVille = textBoxAdrVille.Text;
                u.AdrProvince = textBoxAdrProvince.Text;
                u.AdrCP = textBoxCP.Text;
                u.Login = textBoxLogin.Text;
                u.MotPasse = textBoxMP.Text;
                var confirmerMotPasse = textBoxCMP.Text;
                if (u.MotPasse != confirmerMotPasse) ErrorMsg.Visible = true;
                else
                {
                    ErrorMsg.Visible = false;
                    var userDAO = UserDAOFactory.CreerUserDAO("FILE");
                    userDAO.Modifier(u);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\nVous devez remplir tous les champs");
            }
        }
    }
}
