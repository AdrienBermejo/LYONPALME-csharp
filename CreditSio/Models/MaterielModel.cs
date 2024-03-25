using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditSio.Models
{
    public class MaterielModel
    {
        public string IdMateriel { get; set; }
        public string Marque { get; set; }
        public string Libelle { get; set; }
        public string Etat { get; set; }

        #region constructeur

        public MaterielModel(string id, string _marque, string _libelle, string _etat) 
        {
            IdMateriel = id; 
            Marque = _marque; 
            Libelle = _libelle; 
            Etat = _etat;
        }

        #endregion
    }
}
