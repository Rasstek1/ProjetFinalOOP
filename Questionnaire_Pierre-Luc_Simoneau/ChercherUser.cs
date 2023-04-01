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
    public partial class ChercherUser : UserControl
    {
        public ChercherUser()
        {
            InitializeComponent();
        }

        private List<User> IntersectLists(List<User> list1, List<User> list2)
        {
            List<User> intersection = new List<User>();

            foreach (User user in list1)
            {
                if (list2.Contains(user))
                {
                    intersection.Add(user);
                }
            }

            return intersection;
        }

        private void btnChercher_Click(object sender, EventArgs e)
        {
            List<User> users = UserDAOFactory.CreerUserDAO("FILE").ChercherTout();
            List<User> filteredUsers = users;

            if (chkCP.Checked)
            {
                List<User> cpFilteredUsers = new List<User>();
                foreach (var user in users)
                {
                    if (user.AdrCP == txtCP.Text)
                    {
                        cpFilteredUsers.Add(user);
                    }
                }
                filteredUsers = IntersectLists(filteredUsers, cpFilteredUsers);
            }

            if (chkVille.Checked)
            {
                List<User> villeFilteredUsers = new List<User>();
                foreach (var user in users)
                {
                    if (user.AdrVille == txtVille.Text)
                    {
                        villeFilteredUsers.Add(user);
                    }
                }
                filteredUsers = IntersectLists(filteredUsers, villeFilteredUsers);
            }

            if (chkProvince.Checked)
            {
                List<User> provinceFilteredUsers = new List<User>();
                foreach (var user in users)
                {
                    if (user.AdrProvince == txtProvince.Text)
                    {
                        provinceFilteredUsers.Add(user);
                    }
                }
                filteredUsers = IntersectLists(filteredUsers, provinceFilteredUsers);
            }

            if (chkTelephone.Checked)
            {
                List<User> telephoneFilteredUsers = new List<User>();
                foreach (var user in users)
                {
                    if (user.Telephone == txtTelephone.Text)
                    {
                        telephoneFilteredUsers.Add(user);
                    }
                }
                filteredUsers = IntersectLists(filteredUsers, telephoneFilteredUsers);
            }

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = filteredUsers;
        }

    }
}
