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
    public partial class SupprimerQuestion : UserControl
    {
        public SupprimerQuestion()
        {
            InitializeComponent();
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            
            if (int.TryParse(txtId.Text, out int id))
            {
                Question question = QuestionDAOFactory.CreerQuestionDAO("FILE").ChercherParId(id);
                if (question == null)
                {
                    MessageBox.Show("Aucune question trouvée avec ce ID");
                }
                else
                {
                    QuestionDAOFactory.CreerQuestionDAO("FILE").Supprimer(question);
                    MessageBox.Show("Question supprimée");
                }
            }
            else
            {
                MessageBox.Show("Veuillez entrer un ID de question valide");
            }


        }
    }
}
