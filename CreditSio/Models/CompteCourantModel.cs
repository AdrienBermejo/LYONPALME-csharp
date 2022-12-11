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
    /// Modélise un compte courant.
    /// </summary>
    public class  CompteCourantModel:CompteModel
    {
        /// <summary>
        /// Decouvert autorisé.
        /// </summary>
        public string Decouvert { get; set; }

    }
}
