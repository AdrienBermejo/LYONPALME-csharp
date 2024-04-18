using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditSio.Models
{
    public class MaterielEmpruntModel
    {
        public MaterielModel Materiel { get; set; }
        public string Taille_Combinaison { get; set; }
        public string Pointure_Monopalme { get; set; }
        public string Nom_nageur { get; set; }
        public string Prenom_nageur { get; set; }
        public DateTime debut_Pret { get; set; }
        public DateTime fin_Pret { get; set; }
    }
}
