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
        //L'id du conseiller passé en paramètre est stocké dans un attribut privé.
        private int idConseiller;
        public FTestsClients()
        {
            InitializeComponent();
        }

        //On surcharge le constructeur afin de lui passer l'id du conseiller en paramètre.
        public FTestsClients(int id) : this()
        {
            idConseiller = id;
        }

        private void FTestsClients_Load(object sender, EventArgs e)
        {
            //On récupère tous les clients de ce conseiller financier dont l'id a été passé en paramètre au formulaire.
            List<ClientModel> clients = DBInterface.GetAllClients(idConseiller);

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
