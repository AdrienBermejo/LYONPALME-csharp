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
    public partial class F_AjoutMateriel : Form
    {
        public F_AjoutMateriel()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // appel la dbinterface et lui fournis les données des text box
            string idMateriel, marque, libelle, etat;
            
            idMateriel = textBox4.Text;
            marque = textBox1.Text;
            libelle = textBox2.Text;
            etat = textBox3.Text;
            MaterielModel materiel = new MaterielModel(idMateriel,marque,libelle,etat);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
