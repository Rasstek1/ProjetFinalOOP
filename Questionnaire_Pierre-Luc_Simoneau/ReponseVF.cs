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
    public partial class ReponseVF : UserControl
    {
        public ReponseVF()
        {
            InitializeComponent();
        }

        public bool IsVraiChecked
        {
            get { return rBtnVrai.Checked; }
            set { rBtnVrai.Checked = value; }
        }

        
        public bool IsFauxChecked
        {
            get { return rBtnFaux.Checked; }
            set { rBtnFaux.Checked = value; }
        }
    }
}
