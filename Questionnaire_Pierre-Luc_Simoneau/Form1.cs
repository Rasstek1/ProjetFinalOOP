using Questionnaire_Pierre_Luc_Simoneau.DAOs;

namespace Questionnaire_Pierre_Luc_Simoneau
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void buttonAnnuler_Click(object sender, EventArgs e)
        {
            textBoxLogin.Text = string.Empty;
            textBoxMP.Text = string.Empty;
            radioButtonAdmin.Checked = false;
            radioButtonUser.Checked = false;
        }

        private void buttonConnecter_Click(object sender, EventArgs e)
        {
            string login = textBoxLogin.Text;
            string mp = textBoxMP.Text;
            bool type = (radioButtonUser.Checked == true) ? false : true;

            var userDAO = UserDAOFactory.CreerUserDAO("FILE");
            var user = userDAO.ChercherParLoginMPType(login,mp,type);
            if(user == null)
            {
                MessageBox.Show("Aucun utilisateur trouvé");
                 
            }
            else if(type)
            {
                new PanelCentrale().Show();
                
            }
            else
            {
                new UserPanel().Show();
            }
        }

        private void linkLabelNewUser_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new Form2().Show();
        }
    }
}