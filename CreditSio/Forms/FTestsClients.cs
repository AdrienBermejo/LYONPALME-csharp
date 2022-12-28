using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CreditSio.DataAccess;
using CreditSio.Models;



namespace CreditSio.Forms
{
    public partial class FTestsClients : Form
    {
        public FTestsClients()
        {
            InitializeComponent();
        }

        private void FTestsClients_Load(object sender, EventArgs e)
        {
            //On choisit arbitrairement le conseiller financier avec l'id 2
            int id = 2;
            //On récupère tous les clients de ce conseiller financier

            List<ClientModel> clients = DBInterface.GetAllClients(id);
            //On teste que la liste ne soit pas vide. Si elle est vide, c'est qu'il y a eu une erreur...
            if (clients != null)
            {
                //On parcourt la liste de ClientModel
                foreach (ClientModel client in clients)
                {
                    //On crée un tableau de chaines de caractères : une ligne contient les données d'un client
                    string[] row = { client.Id.ToString(), client.Nom, client.Prenom, client.Mobile, client.Mail };
                    ListViewItem listViewItem = new ListViewItem(row);
                    //On ajoute la ligne dans la listeview
                    lvClients.Items.Add(listViewItem);
                }
            }
            
        }
    }
}
