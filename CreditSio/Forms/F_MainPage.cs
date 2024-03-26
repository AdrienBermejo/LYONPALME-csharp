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
    public partial class F_MainPage : Form
    {
        public F_MainPage()
        {
            InitializeComponent();
        }

        private void OpenF_Materiel_Click(object sender, EventArgs e)
        {
            F_Materiel fTestsClients = new F_Materiel();
            fTestsClients.ShowDialog();
        }

        private void OpenF_Pret_Click(object sender, EventArgs e)
        {
            F_Pret fTestsClients = new F_Pret();
            fTestsClients.ShowDialog();
        }
    }
}
