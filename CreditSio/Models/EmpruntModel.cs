using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditSio.Models
{
    public class EmpruntModel
    {
        public string Id { get; set; }
        public DateTime DateDebut { get; set; }
        public DateTime DateFin { get; set; }
        public string Etat { get; set; }
        public MaterielModel Materiel { get; set; }
        public NageurModel Nageur { get; set; }


    }
}
