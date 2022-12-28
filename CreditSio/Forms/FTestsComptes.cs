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
    public partial class FTestsComptes : Form
    {
        public FTestsComptes()
        {
            InitializeComponent();
        }

        private void FTestsComptes_Load(object sender, EventArgs e)
        {
            //On choisit arbitrairement le client avec l'id 2
            int id = 2;
            //On récupère tous les comptes de ce client
            List<CompteModel> comptes = DBInterface.GetAllComptes(id);
            //On teste que la liste ne soit pas vide. Si elle est vide, c'est qu'il y a eu une erreur...
            if (comptes != null)
            {
                //On parcourt la liste de ClientModel
                foreach (CompteModel compte in comptes)
                {
                    //On teste le type de Compte : Si c'est un CompteCourant.
                    if(compte.GetType().ToString() == "CompteCourantModel")
                    {

                    }
                    //On crée un tableau de chaines de caractères : une ligne contient les données d'un compte (courant ou épargne).
                    string[] row = { compte.Id.ToString(), client.Nom, client.Prenom, client.Mobile, client.Mail };
                    ListViewItem listViewItem = new ListViewItem(row);
                    //On ajoute la ligne dans la listeview
                    lvClients.Items.Add(listViewItem);
                }
            }
        }
    }
}
