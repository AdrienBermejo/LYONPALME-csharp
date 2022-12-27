using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CreditSio.Models;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using CreditSio.Tools;

namespace CreditSio.DataAccess
{
    /// <summary>
    /// Gère l'interface entre la base de données et la couche présentation.
    /// </summary>
    public class DBInterface
    {
        /// <summary>
        /// Obtenir tous les clients d'un conseiller financier.
        /// </summary>
        /// <param name="idConseiller"></param>
        /// <returns>Liste de tous les clients</returns>
        public static List<ClientModel>GetAllClients(int idConseiller)
        {
            List<ClientModel> clients = new List<ClientModel>();
            SqlConnection connection = null; ;
            SqlDataReader sqlDataReader = null;
            try
            {
                connection = Connection.getInstance().GetConnection();
                SqlCommand sqlCommand = new SqlCommand("spClient_GetByConseiller", connection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@pIdConseiller", SqlDbType.Int).Value = idConseiller;
                sqlDataReader = sqlCommand.ExecuteReader();
                while(sqlDataReader.Read())
                {
                    ClientModel clientModel = new ClientModel();
                    clientModel.Id = sqlDataReader.GetInt32(0);
                    clientModel.Nom = sqlDataReader.GetString(1);
                    clientModel.Prenom = sqlDataReader.GetString(2);
                    clientModel.Mobile = sqlDataReader.GetString(3);
                    clientModel.Mail = sqlDataReader.GetString(4);
                    clients.Add(clientModel);
                }
            }
            catch(InvalidOperationException)
            {
                using (StreamWriter w = File.AppendText("../Logs/logerror.txt"))
                {
                    Log.WriteLog("DBInterface : erreur SQL", w);
                }

            }
            finally
            {
                connection.Close();
            }
            return clients;
        }
    

        public static List<CompteModel> GetAllComptes(int idClient)
        {
            List<CompteModel> comptes = new List<CompteModel>();
            SqlConnection connection = null; ;
            SqlDataReader sqlDataReader = null;
            try
            {
                connection = Connection.getInstance().GetConnection();
                SqlCommand sqlCommand = new SqlCommand("spCompte_GetByClient", connection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@pIdClient", SqlDbType.Int).Value = idClient;
                sqlDataReader = sqlCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    //Si le type de compte est null, alors il s'agit d'un compte courant
                    if(sqlDataReader.GetString(3) is null)
                    {
                        CompteCourantModel compteCourantModel = new CompteCourantModel();
                        compteCourantModel.Id
                    }
                    
                    clientModel.Id = sqlDataReader.GetInt32(0);
                    clientModel.Nom = sqlDataReader.GetString(1);
                    clientModel.Prenom = sqlDataReader.GetString(2);
                    clientModel.Mobile = sqlDataReader.GetString(3);
                    clientModel.Mail = sqlDataReader.GetString(4);
                    clients.Add(clientModel);
                }
            }
            catch (InvalidOperationException)
            {
                using (StreamWriter w = File.AppendText("../Logs/logerror.txt"))
                {
                    Log.WriteLog("DBInterface : erreur SQL", w);
                }

            }
            finally
            {
                connection.Close();
            }
            return clients;
        }
}
}
