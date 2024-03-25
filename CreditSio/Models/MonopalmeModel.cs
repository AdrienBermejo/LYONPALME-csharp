using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditSio.Models
{
    public class MonopalmeModel : MaterielModel
    {
        public MonopalmeModel(string id,string marque,string libelle, string etat, string pointure)
            : base(id,marque,libelle,etat) 
        {
            Pointure = pointure;
        }
        public string Pointure { get; set; }

    }
}
