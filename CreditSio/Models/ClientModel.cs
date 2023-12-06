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
    /// Modélise un client.
    /// </summary>
    public class ClientModel
    {
        #region Properties
        /// <summary>
        /// Id du client.
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Nom du client.
        /// </summary>
        public string Nom { get; set; }

        /// <summary>
        /// Prénom du client.
        /// </summary>
        public string Prenom { get; set; }

        /// <summary>
        /// Numéro de téléphone.
        /// </summary>
        public string Mobile { get; set; }

        /// <summary>
        /// Mail.
        /// </summary>
        public string Mail { get; set; }

        public ConseillerModel Conseiller { get; set; }
        #endregion
    }
}
