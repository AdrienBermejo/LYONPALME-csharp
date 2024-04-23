using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditSio.Models
{
    public class StockModel
    {

        #region composant
        public string Materiel { get; set; }
        public string Taille_Combinaison { get; set; }
        public int Pointure_Monopalme { get; set; }
        public int Quantite { get; set; }


        #endregion
        public void setMateriel(string materiel)
        {
            Materiel = materiel;
        }

        public void setTaille_Combi(string combi)
        {
            Taille_Combinaison = combi;
        }

        public void setPointure(int pointure)
        {
            Pointure_Monopalme = pointure;
        }

        public void setQuantite(int quantite)
        {
            Quantite = quantite;
        }
    }
}
