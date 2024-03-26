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
    public partial class F_Pret : Form
    {
        public F_Pret()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            F_AjouterPret fTestsClients = new F_AjouterPret();
            fTestsClients.ShowDialog();
        }
    }
}
