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
    public partial class QuestionnairePanel : Form
    {
        private int currentQuestionIndex = 0;
        public Questionnaire QuestionnaireActuel { get; set; }

        public QuestionnairePanel(Questionnaire q)
        {
            InitializeComponent();
            QuestionnaireActuel = q;
        }

        private void QuestionnairePanel_Load(object sender, EventArgs e)
        {
            UpdateLabels();
        }

        private void UpdateLabels()
        {
            if (QuestionnaireActuel.Questions.Count > currentQuestionIndex)
            {
                Question currentQuestion = QuestionnaireActuel.Questions[currentQuestionIndex];
                lblCount.Text = $"Question {currentQuestionIndex + 1} de {QuestionnaireActuel.Questions.Count}";
                lblEnonce.Text = currentQuestion.Enonce;
            }
            else
            {
                MessageBox.Show("Fin du Questionnaire.");
            }
            //if question.Type is true, load reponseVF in pnlReponses, else load reponseSM
            if (QuestionnaireActuel.Questions[currentQuestionIndex].Type)
            {
                pnlReponses.Controls.Clear();
                pnlReponses.Controls.Add(new ReponseVF());
            }
            else
            {
                pnlReponses.Controls.Clear();
                pnlReponses.Controls.Add(new ReponseSM());
                //assign the list of reponses to the txtboxes of the ReponseSM controls
                ReponseSM reponseSM = (ReponseSM)pnlReponses.Controls[0];
                reponseSM.Reponse1 = QuestionnaireActuel.Questions[currentQuestionIndex].PropositionSM[0];
                reponseSM.Reponse2 = QuestionnaireActuel.Questions[currentQuestionIndex].PropositionSM[1];
                reponseSM.Reponse3 = QuestionnaireActuel.Questions[currentQuestionIndex].PropositionSM[2];
                reponseSM.Reponse4 = QuestionnaireActuel.Questions[currentQuestionIndex].PropositionSM[3];
                
                
            }
        }
        private bool VerifierReponse()
        {
            Question currentQuestion = QuestionnaireActuel.Questions[currentQuestionIndex];

            if (currentQuestion.Type)
            {
                ReponseVF reponseVF = (ReponseVF)pnlReponses.Controls[0];
                bool userAnswer = reponseVF.IsVraiChecked;
                return userAnswer == currentQuestion.ReponseVF;
            }
            else
            {
                ReponseSM reponseSM = (ReponseSM)pnlReponses.Controls[0];
                List<string> userAnswers = new List<string>
        {
            reponseSM.Reponse1Checked ? reponseSM.Reponse1 : null,
            reponseSM.Reponse2Checked ? reponseSM.Reponse2 : null,
            reponseSM.Reponse3Checked ? reponseSM.Reponse3 : null,
            reponseSM.Reponse4Checked ? reponseSM.Reponse4 : null,
        };

                userAnswers.RemoveAll(item => item == null);

                return userAnswers.SequenceEqual(currentQuestion.ReponseSM);
            }
        }

        private void btnConfirmer_Click(object sender, EventArgs e)
        {

            if (VerifierReponse())
            {
                QuestionnaireActuel.ScoreObtenu++;
            }

            currentQuestionIndex++;

            if (currentQuestionIndex < QuestionnaireActuel.Questions.Count)
            {
                UpdateLabels();
            }
            else
            {
                string noteDePassage = "Vous n'avez pas obtenue la note de passage";
                if(QuestionnaireActuel.ScoreObtenu>=QuestionnaireActuel.ScoreDePassage) noteDePassage = "Bravo! Vous avez obtenue la note de passage!";
                MessageBox.Show($"Vous avez terminé le questionnaire, votre score: {QuestionnaireActuel.ScoreObtenu}/{QuestionnaireActuel.Questions.Count}\n{noteDePassage}");
                
                currentQuestionIndex = 0;
                UpdateLabels();
                //use ResultatDAOFactory to write to the txt file
                var resultatDAO = ResultatDAOFactory.CreerResultatDAO("FILE");
                resultatDAO.Ajouter(QuestionnaireActuel);

                this.Close();
            }
        }

        private void pnlReponses_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
