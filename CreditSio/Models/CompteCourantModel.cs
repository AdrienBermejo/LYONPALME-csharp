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
    /// Date de modification : 27/12/2022.
    /// Modélise un compte courant.
    /// </summary>
    public class CompteCourantModel : CompteModel
    {
        #region propriétés
        /// <summary>
        /// Decouvert autorisé.
        /// </summary>
        public double Decouvert { get; set; }
        #endregion

        #region méthodes
        /// <summary>
        /// Retourne l'id du compte.
        /// </summary>
        /// <returns></returns>
        public int GetId()
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
        public void SetId(int id)
        {
            if (id != 0)
                Id = id;
        }

        /// <summary>
        /// Modifier le solde du compte.
        /// </summary>
        /// <param name="solde">Le solde à modifier.</param>
        public void SetSolde(double solde)
        {
            Solde = solde;
        }
        #endregion
    }
}