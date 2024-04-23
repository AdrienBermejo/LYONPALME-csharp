using CreditSio.DataAccess;
using CreditSio.Models;
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

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<MaterielEmpruntModel> emprunts = DBInterface.GetPret();

            if (emprunts != null)
            {

                foreach (MaterielEmpruntModel mat in emprunts)
                {
                    string[] row =
                        {
                        mat.IdMateriel,
                        mat.Marque,
                        mat.Type,
                        mat.Taille_Combinaison,
                        mat.Pointure_Monopalme.ToString(),
                        mat.Nom_nageur,
                        mat.Prenom_nageur,
                        mat.debut_Pret.ToString(),
                         };
                    ListViewItem listviewitem = new ListViewItem(row);

                    listView1.Items.Add(listviewitem);
                }
            }
        }
    }
}
