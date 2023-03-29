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
    public partial class SupprimerUtilisateur : UserControl
    {
        List<User> listUser;
        public SupprimerUtilisateur()
        {
            InitializeComponent();
        }

        private void SupprimerUtilisateur_Load(object sender, EventArgs e)
        {
            //récupérer la liste des utilisateurs
            listUser = UserDAOFactory.CreerUserDAO("FILE").ChercherTout();
            //Affecter la liste à la grille
            dataGridView1.DataSource = listUser; 
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            //supprimer le user du fichier
            UserDAOFactory.CreerUserDAO("FILE").Supprimer(listUser[dataGridView1.SelectedCells[0].RowIndex]);
            //supprimer le user de la liste
            listUser.RemoveAt(dataGridView1.SelectedCells[0].RowIndex);
            //réafficher la liste
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = listUser;
        }
    }
}
