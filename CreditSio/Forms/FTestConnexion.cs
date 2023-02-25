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
using System.Security.Cryptography;

namespace CreditSio.Forms
{
    public partial class FTestConnexion : Form
    {
        public FTestConnexion()
        {
            InitializeComponent();
        }

        private void btnConnecter_Click(object sender, EventArgs e)
        {
            ConseillerModel conseiller;
            string login, password;
            login = tbxLogin.Text;
            password = tbxPassword.Text;
            using (SHA512Managed sha2 = new SHA512Managed())
            {
                var password_hash = sha2.ComputeHash(Encoding.UTF8.GetBytes(password));
                conseiller = DBInterface.GetConseiller(login, password_hash);
            }
            //On teste que le conseiller ne soit pas vide. Si il est vide, c'est qu'il y a eu une erreur...
            if (conseiller != null)
            {
                if(conseiller.Prenom ==null || conseiller.Nom == null)
                {
                    labConnexion.Text = "Identifiants de connexion invalides";
                }
                else
                {
                    labConnexion.Text = "Vous êtes connecté.";
                    labBienvenue.Visible = true;
                    labBienvenue.Text = String.Concat("Bienvenue, ", conseiller.Prenom, conseiller.Nom);
                    btnVoirComptes.Visible = true;
                }
            }
        }
    }
}
