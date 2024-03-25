using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CreditSio.Models
{
    public class CombinaisonModel:MaterielModel
    {
        public CombinaisonModel(string id, string marque, string libelle, string etat, string taille)
            : base(id, marque, libelle, etat)
        {
            Taille = taille;
        }
        public string Taille { get; set; }

    }
}
