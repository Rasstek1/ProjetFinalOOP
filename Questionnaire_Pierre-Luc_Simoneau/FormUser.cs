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
    public partial class FormUser : Form
    {
        public FormUser()
        {
            InitializeComponent();
        }
                       

        private void btnEnregistrer_Click_1(object sender, EventArgs e)
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
                userDAO.Ajouter(u);
                this.Hide();

            }
        }

        private void btnAnnuler_Click_1(object sender, EventArgs e)
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
            textBoxCMP.Text = string.Empty;
            ErrorMsg.Visible = false;
        }
    }
}
