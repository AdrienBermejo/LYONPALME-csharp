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
//        using (SqlConnection connection = new SqlConnection(
//        connectionString))
//    {
//        SqlCommand command = new SqlCommand(
//            queryString, connection);
//        connection.Open();
//        using(SqlDataReader reader = command.ExecuteReader())
//        {
//            while (reader.Read())
//            {
//                Console.WriteLine(String.Format("{0}, {1}",
//                    reader[0], reader[1]));
//            }
//}
//    }
        public static List<ClientModel> GetAllClients(int idConseiller)
        {
            List<ClientModel> clients = new List<ClientModel>();
            SqlConnection connection = null;
            try
            {
                connection = Connection.getInstance().GetConnection();
                using (SqlCommand sqlCommand = new SqlCommand("spClient_GetByConseiller", connection))
                {
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.Parameters.AddWithValue("@pIdConseiller", SqlDbType.Int).Value = idConseiller;
                    using (SqlDataReader sqlDataReader = sqlCommand.ExecuteReader())
                    {
                        while (sqlDataReader.Read())
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


        public static List<CompteModel> GetAllComptes(int idClient)
        {
            //La liste créée est une liste de Compte (et non de CompteCourant ou de CompteEpargne)
            List<CompteModel> comptes = new List<CompteModel>();
            SqlConnection connection = null;
            //SqlDataReader sqlDataReader = null;
            try
            {
                connection = Connection.getInstance().GetConnection();
                using (SqlCommand sqlCommand = new SqlCommand("spCompte_GetByClient", connection))
                {
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.Parameters.AddWithValue("@pIdClient", SqlDbType.Int).Value = idClient;
                    using (SqlDataReader sqlDataReader = sqlCommand.ExecuteReader())
                    {
                        while (sqlDataReader.Read())
                        {
                            //Si le type de compte est null (colonne 4 de la requête), alors il s'agit d'un compte courant
                            if (sqlDataReader.IsDBNull(3))
                            {
                                CompteCourantModel compteCourantModel = new CompteCourantModel();
                                compteCourantModel.SetId(sqlDataReader.GetInt32(0));
                                //Le solde du compte est stocké en decimal dans la DB. Il faut le convertir en double.
                                compteCourantModel.SetSolde(decimal.ToDouble(sqlDataReader.GetDecimal(1)));
                                //Le découvert du compte est stocké en decimal dans la DB. Il faut le convertir en double.
                                compteCourantModel.Decouvert = decimal.ToDouble(sqlDataReader.GetDecimal(1));
                                //Bien que l'objet soit un CompteCourant, on peut l'ajouter dans la liste de Compte,
                                //Car un CompteCourant "est un" Compte.
                                comptes.Add(compteCourantModel);
                            }
                            else
                            {
                                CompteEpargneModel compteEpargneModel = new CompteEpargneModel();
                                compteEpargneModel.SetId(sqlDataReader.GetInt32(0));
                                //Le solde du compte est stocké en decimal dans la DB. Il faut le convertir en double.
                                compteEpargneModel.SetSolde(decimal.ToDouble(sqlDataReader.GetDecimal(1)));
                                compteEpargneModel.Type = sqlDataReader.GetString(3);
                                //Le taux d'interets est stocké en décimal dans la DB. Il faut le convertir en double.
                                compteEpargneModel.Taux = decimal.ToDouble(sqlDataReader.GetDecimal(4));
                                //Bien que l'objet soit un CompteEpargne, on peut l'ajouter dans la liste de Compte,
                                //Car un CompteEpargne "est un" Compte.
                                comptes.Add(compteEpargneModel);
                            }
                        }
                    }
                        
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
            return comptes;
        }
    }
}

