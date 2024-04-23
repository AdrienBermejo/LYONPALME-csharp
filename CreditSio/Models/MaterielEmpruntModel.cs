using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CreditSio.Models
{
    public class MaterielEmpruntModel
    {
        public string IdMateriel { get; set; }
        public string Marque { get; set; }
        public string Type {get ; set; }
        public string Taille_Combinaison { get; set; }
        public int Pointure_Monopalme { get; set; }
        public string Nom_nageur { get; set; }
        public string Prenom_nageur { get; set; }
        public DateTime debut_Pret { get; set; }
        public DateTime fin_Pret { get; set; }

        #region procedure

        public void setMateriel(string mat)
        {
            IdMateriel = mat;
        }

        public void setMarque(string marque)
        {
            Marque = marque;
        }

        public void setType(string type)
        {
            Type = type;
        }

        public void setTaille(string taille)
        {
            Taille_Combinaison = taille;
        }

        public void setPointure(int point)
        {
            Pointure_Monopalme = point;
        }

        public void setNom(string nom)
        {
            Nom_nageur = nom;
        }

        public void setPrenom(string prenom)
        {
            Prenom_nageur = prenom;
        }

        public void setDate(DateTime date)
        {
            debut_Pret = date;
        }

        #endregion
    }
}
