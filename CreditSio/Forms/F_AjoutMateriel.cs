using CreditSio.DataAccess;
using CreditSio.Models;
using System;
using System.Collections;
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
            string idMateriel, marque, libelle, etat, pointure, taille;
            
            idMateriel = textBox4.Text;
            marque = textBox1.Text;
            libelle = textBox2.Text;
            etat = textBox3.Text;
            pointure = textBox5.Text; //pointure
            taille = textBox6.Text; //taille
            
            if (pointure is null && taille is null)
            {
                MaterielModel materiel = new MaterielModel(idMateriel, marque, libelle, etat);
                DBInterface.AddMaterielStock(materiel);
            }
            else if(pointure is null)
            {
                CombinaisonModel materiel = new CombinaisonModel(idMateriel, marque, libelle, etat, taille);
                DBInterface.AddCombinaisonStock(materiel);
            }
            else if(taille is null)
            {
                MonopalmeModel materiel = new MonopalmeModel(idMateriel, marque, libelle, etat, pointure);
                DBInterface.AddMonopalmeStock(materiel);
            }
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<IdModel> ID = DBInterface.GetLastMateriel();

            if (ID != null)
            {

                foreach (IdModel stock in ID)
                {
                    string[] row = { stock.Id };
                    ListViewItem listviewitem = new ListViewItem(row);

                    dMat.Items.Add(listviewitem);
                }
            }
        }
    }
}
