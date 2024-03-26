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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CreditSio.Forms
{
    public partial class F_AjouterPret : Form
    {
        public F_AjouterPret()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void EnvoiePret_Click(object sender, EventArgs e)
        {
            string idMateriel, idPret, numNageur, etat;
            DateTime date;

            idPret = Input_CodePret.Text;
            idMateriel = Input_CodeMateriel.Text;
            numNageur = Input_NumeroNageur.Text;
            etat = Input_EtatPret.Text;
            date = DateTime.MinDate;
            DBInterface.AddEmprunt(idPret,idMateriel,idMateriel,etat,date);
        }

        private void Input_CodePret_TextChanged(object sender, EventArgs e)
        {

        }

        private void Input_NumeroNageur_TextChanged(object sender, EventArgs e)
        {

        }

        private void Input_CodeMateriel_TextChanged(object sender, EventArgs e)
        {

        }

        private void DateTime_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Input_EtatPret_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
