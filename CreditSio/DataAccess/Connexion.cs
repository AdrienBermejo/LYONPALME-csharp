using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace CreditSio.DataAccess
{
    /// <summary>
    /// Auteur : B. Chataing.
    /// Date de création : 8/12/2022.
    /// Date de modification : 17/12/2022.
    /// Gère la connexion à la base de données, par un singleton (une seule instance d'une classe).
    /// </summary>
    public class Connection
    {
        /// <summary>
        /// Instance SqlConnection : persiste la connexion au serveur.
        /// </summary>
        private static SqlConnection sqlConnection = null;

        /// <summary>
        /// Singleton : instance unique de la classe Connexion.
        /// </summary>
        private static Connection instance;

        /// <summary>
        /// Constructeur privé, pour créer le singleton.
        /// </summary>
        private Connection() { }

        /// <summary>
        /// Connexion à SQL Server.
        /// </summary>
        /// <returns>Un SqlConnection non null si connexion réussie.</returns>
        public SqlConnection GetConnection()
        {
            string connectionString;
            try
            {
                connectionString = ConfigurationManager.ConnectionStrings["sqlserver_creditsio"].ConnectionString;
                sqlConnection = new SqlConnection(connectionString);
                sqlConnection.Open();
                
            }
            catch(SqlException)
            {
                Console.WriteLine("Erreur connexion au serveur");
            }
            return sqlConnection;
        }

        /// <summary>
        /// Crée le singleton s'il n'existe pas.
        /// </summary>
        /// <returns>L'instance de Connection</returns>
        public static Connection getInstance()
        {
            if (Connection.instance == null)
                Connection.instance = new Connection();
            return Connection.instance;
        }
    }
}
