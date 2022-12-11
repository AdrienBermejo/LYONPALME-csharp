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
    /// Modélise un compte.
    /// </summary>
    public abstract class CompteModel
    {
        protected int id;
        protected double solde;

        /// <summary>
        /// Id du compte.
        /// </summary>
        protected int Id { get => id; set => id = value; }

        /// <summary>
        /// Solde du compte.
        /// </summary>
        protected double Solde { get => solde; set => solde = value; }
    }
}
