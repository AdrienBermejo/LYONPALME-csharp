using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CreditSio.Forms
{
    public partial class F_Materiel : Form
    {
        public F_Materiel()
        {
            InitializeComponent();
        }

        private void AddMateriel_Click(object sender, EventArgs e)
        {
            F_AjoutMateriel fTestsClients = new F_AjoutMateriel();
            fTestsClients.ShowDialog();
        }
    }
}
