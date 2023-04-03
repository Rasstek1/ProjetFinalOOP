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
                Questionnaire questionnaire = new Questionnaire();

                if (!int.TryParse(txtNbrQuestions.Text, out int nbrQuestions)) MessageBox.Show("Veuillez entrer un nombre valide");
                if (!int.TryParse(txtScore.Text, out int scoreDePassage)) MessageBox.Show("Veuillez entrer un nombre valide");

                List<Question> questions = QuestionDAOFactory.CreerQuestionDAO("FILE").ChercherTout();

                // Shuffle the list of questions
                Random random = new Random();
                List<Question> shuffledQuestions = questions.OrderBy(q => random.Next()).ToList();

                
                questionnaire.Questions = shuffledQuestions.Take(nbrQuestions).ToList();
                questionnaire.User = loggedInUser;
                questionnaire.ScoreDePassage = scoreDePassage;

            }
            else
            {
                MessageBox.Show("Veuillez remplir tous les champs");
            }


        }
    }
}
