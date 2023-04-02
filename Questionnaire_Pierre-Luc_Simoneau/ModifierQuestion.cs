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
    public partial class ModifierQuestion : UserControl
    {
        public ModifierQuestion()
        {
            InitializeComponent();
        }

        private void btnChercher_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtId.Text, out int id))
            {
                MessageBox.Show("Veuillez entrer un ID de question valide");
            }


            Question question = QuestionDAOFactory.CreerQuestionDAO("FILE").ChercherParId(id);
            txtEnonce.Text = question.Enonce;
            if (question == null)
            {
                MessageBox.Show("Aucune question trouvée avec ce ID");
            }
            else
            {
                if (question.Type == true)
                {
                    rbVF.Checked = true;
                    pnlReponses.Controls.Clear();
                    ReponseVF reponseVF = new ReponseVF();
                    pnlReponses.Controls.Add(reponseVF);
                    if (question.ReponseVF)
                    {
                        reponseVF.IsVraiChecked = true;
                    }
                    else
                    {
                        reponseVF.IsFauxChecked = true;
                    }

                }
                else
                {
                    rbSM.Checked = true;
                    pnlReponses.Controls.Clear();
                    ReponseSM reponseSM = new ReponseSM();
                    pnlReponses.Controls.Add(reponseSM);

                    reponseSM.Reponse1 = question.PropositionSM[0];
                    reponseSM.Reponse2 = question.PropositionSM[1];
                    reponseSM.Reponse3 = question.PropositionSM[2];
                    reponseSM.Reponse4 = question.PropositionSM[3];

                    if (question.ReponseSM.Contains(reponseSM.Reponse1))
                    {
                        reponseSM.Reponse1Checked = true;
                    }
                    if (question.ReponseSM.Contains(reponseSM.Reponse2))
                    {
                        reponseSM.Reponse2Checked = true;
                    }
                    if (question.ReponseSM.Contains(reponseSM.Reponse3))
                    {
                        reponseSM.Reponse3Checked = true;
                    }
                    if (question.ReponseSM.Contains(reponseSM.Reponse4))
                    {
                        reponseSM.Reponse4Checked = true;
                    }





                }
            }
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            pnlReponses.Controls.Clear();
            txtEnonce.Text = string.Empty;
            txtId.Text = string.Empty;
            rbSM.Checked = false;
            rbVF.Checked = false;
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtId.Text, out int id))
            {
                MessageBox.Show("Veuillez entrer un ID de question valide");
                return;
            }

            string enonce = txtEnonce.Text;
            if (string.IsNullOrEmpty(enonce))
            {
                MessageBox.Show("Vous devez entrer un énoncé pour la question");
            }

            if (rbVF.Checked)
            {
                ReponseVF reponseVF = pnlReponses.Controls[0] as ReponseVF;
                bool? bonneReponse = null;
                if (reponseVF.IsVraiChecked)
                {
                    bonneReponse = true;
                }
                else if (reponseVF.IsFauxChecked)
                {
                    bonneReponse = false;
                }

                if (bonneReponse.HasValue)
                {
                    Question question = new Question(txtEnonce.Text, true, bonneReponse.Value);
                    question.Id = id;
                    var questionDAO = QuestionDAOFactory.CreerQuestionDAO("FILE");
                    questionDAO.Modifier(question);
                }
                else
                {
                    MessageBox.Show("Vous devez choisir la bonne réponse");
                }
            }
            else if (rbSM.Checked)
            {
                ReponseSM reponseSM = pnlReponses.Controls[0] as ReponseSM;
                List<string> reponses = new List<string>();
                List<string> propositions = new List<string>();
                if (!string.IsNullOrEmpty(reponseSM.Reponse1))
                {
                    propositions.Add(reponseSM.Reponse1);
                    if (reponseSM.Reponse1Checked)
                    {
                        reponses.Add(reponseSM.Reponse1);
                    }
                }
                if (!string.IsNullOrEmpty(reponseSM.Reponse2))
                {
                    propositions.Add(reponseSM.Reponse2);
                    if (reponseSM.Reponse2Checked)
                    {
                        reponses.Add(reponseSM.Reponse2);
                    }
                }
                if (!string.IsNullOrEmpty(reponseSM.Reponse3))
                {
                    propositions.Add(reponseSM.Reponse3);
                    if (reponseSM.Reponse3Checked)
                    {
                        reponses.Add(reponseSM.Reponse3);
                    }
                }
                if (!string.IsNullOrEmpty(reponseSM.Reponse4))
                {
                    propositions.Add(reponseSM.Reponse4);
                    if (reponseSM.Reponse4Checked)
                    {
                        reponses.Add(reponseSM.Reponse4);
                    }
                }
                if (propositions.Count > 0 && reponses.Count > 0)
                {
                    Question question = new Question(txtEnonce.Text, false, propositions, reponses);
                    question.Id = id;
                    var questionDAO = QuestionDAOFactory.CreerQuestionDAO("FILE");
                    questionDAO.Modifier(question);
                    MessageBox.Show("Question modifié avec succès");
                    this.btnAnnuler_Click(sender, e);
                }
                else
                {
                    MessageBox.Show("Vous devez entrer au moins une proposition et une bonne réponse");
                }
            }
            else
            {
                MessageBox.Show("Vous devez choisir le type de question");
            }
        }

    }

}

