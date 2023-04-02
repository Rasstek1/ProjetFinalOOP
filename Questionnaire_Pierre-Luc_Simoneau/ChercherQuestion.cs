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
    public partial class ChercherQuestion : UserControl
    {
        //create an intersect list
        private List<Question> IntersectLists(List<Question> list1, List<Question> list2)
        {
            List<Question> intersection = new List<Question>();
            foreach (Question question in list1)
            {
                if (list2.Contains(question))
                {
                    intersection.Add(question);
                }
            }
            return intersection;
        }
        public ChercherQuestion()
        {
            InitializeComponent();
        }

        private void btnConsulter_Click(object sender, EventArgs e)
        {
            List<Question> questions = QuestionDAOFactory.CreerQuestionDAO("FILE").ChercherTout();
            List<Question> filteredQuestions = new List<Question>();

            foreach (var question in questions)
            {
                if (chkVF.Checked && question.Type)
                {
                    filteredQuestions.Add(question);
                }
                else if (chkSM.Checked && !question.Type)
                {
                    filteredQuestions.Add(question);
                }
                else if (!chkVF.Checked && !chkSM.Checked)
                {
                    filteredQuestions.Add(question);
                }
            }

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = filteredQuestions;
        }



    }
}
