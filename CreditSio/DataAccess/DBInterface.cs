using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CreditSio.Models;
using System.Data;
using System.Data.SqlClient;

namespace CreditSio.DataAccess
{
    /// <summary>
    /// Gère l'interface entre la base de données et la couche présentation.
    /// </summary>
    public class DBInterface
    {
        public static List<ClientModel>GetAllClients(int idConseiller)
        {
            List<ClientModel> clients = new List<ClientModel>();
            SqlConnection connection = null; ;
            SqlDataReader sqlDataReader = null;
            try
            {
                connection = Connection.getInstance().getConnection();
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
            catch(SqlException)
            {
                throw;
            }
            finally
            {
                connection.Close();
            }
            return clients;
        }
    }
}
