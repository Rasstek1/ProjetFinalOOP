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
    public partial class AfficherResultats : UserControl
    {
        public AfficherResultats()
        {
            InitializeComponent();
        }
        public void SetDataSource(List<Questionnaire> questionnaires)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = questionnaires;
        }
    }
}
