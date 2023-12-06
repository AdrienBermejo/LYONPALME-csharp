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
        protected string id;
        protected float solde;
        protected ClientModel clientModel;

        /// <summary>
        /// Id du compte.
        /// </summary>
        protected string Id { get => id; set => id = value; }

        /// <summary>
        /// Solde du compte.
        /// </summary>
        protected float Solde { get => solde; set => solde = value; }

        protected ClientModel ClientModel { get => clientModel; set => clientModel = value; }
    }
}
