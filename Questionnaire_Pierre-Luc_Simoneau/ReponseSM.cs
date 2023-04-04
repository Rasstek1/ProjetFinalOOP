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
    public partial class ReponseSM : UserControl
    {
        public ReponseSM()
        {
            InitializeComponent();
            //if parent for is QuestionnairePanel, disable the 4 txtboxes
            if (Parent is QuestionnairePanel)
            {
                txtReponse1.Enabled = false;
                txtReponse2.Enabled = false;
                txtReponse3.Enabled = false;
                txtReponse4.Enabled = false;
            }
        }



        public string Reponse1 { get { return txtReponse1.Text; } set { txtReponse1.Text = value; } }
        public string Reponse2 { get { return txtReponse2.Text; } set { txtReponse2.Text = value; } }
        public string Reponse3 { get { return txtReponse3.Text; } set { txtReponse3.Text = value; } }
        public string Reponse4 { get { return txtReponse4.Text; } set { txtReponse4.Text = value; } }
        public bool Reponse1Checked { get { return chkReponse1.Checked; } set { chkReponse1.Checked = value; } }
        public bool Reponse2Checked { get { return chkReponse2.Checked; } set { chkReponse2.Checked = value; } }
        public bool Reponse3Checked { get { return chkReponse3.Checked; } set { chkReponse3.Checked = value; } }
        public bool Reponse4Checked { get { return chkReponse4.Checked; } set { chkReponse4.Checked = value; } }




    }
}
