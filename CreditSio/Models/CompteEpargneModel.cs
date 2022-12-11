using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditSio.Models
{
    /// <summary>
    /// Auteur : B. Chataing.
    /// Date de création : 8/12/2022.
    /// Date de modification :
    /// Modélise un compte épargne.
    /// </summary>
    class CompteEpargneModel:CompteModel
    {
        #region Properties
        /// <summary>
        /// Type du compte épargne.
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// Taux d'intérêts.
        /// </summary>
        public int Taux { get; set; }
        #endregion
    }
}
