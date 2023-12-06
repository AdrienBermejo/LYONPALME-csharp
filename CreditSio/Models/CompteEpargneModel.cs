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
        public double Taux { get; set; }
        #endregion

        #region méthodes
        /// <summary>
        /// Retourne l'id du compte.
        /// </summary>
        /// <returns></returns>
        public string GetId()
        {
            return Id;
        }

        /// <summary>
        /// Obtenir le solde du compte.
        /// </summary>
        /// <returns>Solde (propriété de la classe CompteCourant)</returns>
        public double GetSolde()
        {
            return Solde;
        }

        /// <summary>
        /// Modifier l'id du compte.
        /// </summary>
        /// <param name="id">L'id du compte à modifier.</param>
        public void SetId(string id)
        {
            if (id != null)
                Id = id;
        }

        /// <summary>
        /// Modifier le solde du compte.
        /// </summary>
        /// <param name="solde">Le solde à modifier.</param>
        public void SetSolde(float solde)
        {
            Solde = solde;
        }
        #endregion
    }
}
