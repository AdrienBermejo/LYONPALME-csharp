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
                //On parcourt la liste de CompteModel
                foreach (CompteModel compte in comptes)
                {
                    //Bien que la liste soit une liste de CompteModel, elle contient indifféremment des CompteCourant ou des CompteEpargne.
                    //On teste le type de Compte : Si c'est un CompteCourant.
                    if(compte.GetType().ToString() == "CompteCourantModel")
                    {
                        //On transtype l'objet Compte en CompteCourantModel ie on transforme l'objet Compte en CompteCourant.
                        CompteCourantModel compteCourantModel = (CompteCourantModel)compte;
                        //On crée un tableau de chaines de caractères : une ligne contient les données d'un compte (courant ou épargne).
                        string[] row = { "COURANT", compteCourantModel.GetId().ToString(), compteCourantModel.GetSolde().ToString(), compteCourantModel.Decouvert.ToString(), "---", "---" };
                        ListViewItem listViewItem = new ListViewItem(row);
                        //On ajoute la ligne dans la listeview
                        lvComptes.Items.Add(listViewItem);
                    }
                    else
                    {
                        // On transtype l'objet Compte en CompteEpargneModel ie on transforme l'objet Compte en CompteEpargne.
                        CompteEpargneModel compteEpargneModel = (CompteEpargneModel)compte;
                        //On crée un tableau de chaines de caractères : une ligne contient les données d'un compte (courant ou épargne).
                        string[] row = { "EPARGNE", compteEpargneModel.GetId().ToString(), compteEpargneModel.GetSolde().ToString(), "---", compteEpargneModel.Type, compteEpargneModel.Taux.ToString() };
                        ListViewItem listViewItem = new ListViewItem(row);
                        //On ajoute la ligne dans la listeview
                        lvComptes.Items.Add(listViewItem);
                    }
                }
            }
        }
    }
}
