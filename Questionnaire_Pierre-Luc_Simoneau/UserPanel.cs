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
    public partial class UserPanel : Form
    {
        private User loggedInUser;

        public UserPanel(User user)
        {
            InitializeComponent();
            loggedInUser = user;
            UpdateUserNameLabel();
        }
        private void UpdateUserNameLabel()
        {            
            labelUserName.Text = $"Utilisateur: {loggedInUser.Nom}";
        }

        private void btnDemarrer_Click(object sender, EventArgs e)
        {//validate that both txtboxes are not empty,then create a Questionnaire
            if (txtNbrQuestions.Text != "" && txtScore.Text != "")
            {
                if (!int.TryParse(txtNbrQuestions.Text, out int nbrQuestions)) MessageBox.Show("Veuillez entrer un nombre valide");
                if (!int.TryParse(txtScore.Text, out int scoreDePassage)) MessageBox.Show("Veuillez entrer un nombre valide");
                Questionnaire questionnaire = new Questionnaire(nbrQuestions,scoreDePassage,loggedInUser);                
                new QuestionnairePanel(questionnaire).Show();

            }
            else
            {
                MessageBox.Show("Veuillez remplir tous les champs");
            }


        }
    }
}
