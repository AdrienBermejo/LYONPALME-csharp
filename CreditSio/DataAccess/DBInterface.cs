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
        /// Obtenir le conseiller qui s'est connecté
        /// </summary>
        /// <param name="login"></param>
        /// <param name="password"></param>
        /// <returns>L'objet Conseiller qui s'est connecté</returns>
        public static ConseillerModel GetConseiller(string login, byte[] password)
        {
            ConseillerModel conseiller = new ConseillerModel();
            SqlConnection connection = null;
            try
            {
                connection = Connection.getInstance().GetConnection();
                using (SqlCommand sqlCommand = new SqlCommand("authentification", connection))
                {
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.Parameters.AddWithValue("@login", SqlDbType.NVarChar).Value = login;
                    sqlCommand.Parameters.Add("@mdp", SqlDbType.VarBinary).Value = password;
                    using (SqlDataReader sqlDataReader = sqlCommand.ExecuteReader())
                    {
                        if(sqlDataReader.HasRows)
                        {
                            sqlDataReader.Read();
                            conseiller.Id = sqlDataReader.GetString(0);
                            conseiller.Nom = sqlDataReader.GetString(1);
                            conseiller.Prenom = sqlDataReader.GetString(2);
                            using (StreamWriter w = File.AppendText("../Logs/logerror.txt"))
                            {
                                Log.WriteLog(String.Concat("DBInterface : l'utilisateur ", login, " vient de se connecter"), w);
                            }
                        }
                        else
                        {
                            using (StreamWriter w = File.AppendText("../Logs/logerror.txt"))
                            {
                                Log.WriteLog(String.Concat(String.Concat("DBInterface : identifiants de connexion invalide. Login :", login)), w);
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
            return conseiller;
        }

        /// <summary>
        /// Obtenir tous les clients d'un conseiller financier.
        /// </summary>
        /// <param name="idConseiller"></param>
        /// <returns>Liste de tous les clients</returns>
        public static List<ClientModel> GetAllClients(string idConseiller)
        {
            List<ClientModel> clients = new List<ClientModel>();
            SqlConnection connection = null;
            try
            {
                connection = Connection.getInstance().GetConnection();
                using (SqlCommand sqlCommand = new SqlCommand("spClient_GetByConseiller", connection))
                {
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.Parameters.AddWithValue("@pIdConseiller", SqlDbType.VarChar).Value = idConseiller;
                    /// tentative d'extraction d'erreur :
                    //Console.WriteLine("erreur");
                    using (SqlDataReader sqlDataReader = sqlCommand.ExecuteReader())
                    {
                        while (sqlDataReader.Read())
                        {
                            /*using (StreamWriter w = File.AppendText("../Logs/logerror.txt"))
                            {
                                Log.WriteLog("creation d'un client", w);
                            }*/
                            ClientModel clientModel = new ClientModel();
                            clientModel.Id = sqlDataReader.GetString(0);
                            clientModel.Nom = sqlDataReader.GetString(1);
                            clientModel.Prenom = sqlDataReader.GetString(2);
                            clientModel.Mobile = sqlDataReader.GetString(3);
                            clientModel.Mail = sqlDataReader.GetString(4);
                            clients.Add(clientModel);
                            /// tentative d'extraction d'erreur :
                            //Console.WriteLine(clientModel.Id);
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


        public static List<CompteModel> GetAllComptes(string idClient)
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
                    sqlCommand.Parameters.AddWithValue("@pIdClient", SqlDbType.VarChar).Value = idClient;
                    using (SqlDataReader sqlDataReader = sqlCommand.ExecuteReader())
                    {
                        while (sqlDataReader.Read())
                        {
                            //Si le type de compte est null (colonne 4 de la requête), alors il s'agit d'un compte courant
                            if (sqlDataReader.IsDBNull(3))
                            {
                                CompteCourantModel compteCourantModel = new CompteCourantModel();
                                compteCourantModel.SetId(sqlDataReader.GetString(0));
                                //Le solde du compte est stocké en decimal dans la DB. Il faut le convertir en double.
                                compteCourantModel.SetSolde(decimal.ToSingle(sqlDataReader.GetDecimal(1))); 
                                //Le découvert du compte est stocké en decimal dans la DB. Il faut le convertir en double.
                                compteCourantModel.Decouvert = decimal.ToSingle(sqlDataReader.GetDecimal(2));
                                //Bien que l'objet soit un CompteCourant, on peut l'ajouter dans la liste de Compte,
                                //Car un CompteCourant "est un" Compte.
                                comptes.Add(compteCourantModel);
                            }
                            else
                            {
                                CompteEpargneModel compteEpargneModel = new CompteEpargneModel();
                                compteEpargneModel.SetId(sqlDataReader.GetString(0));
                                //Le solde du compte est stocké en decimal dans la DB. Il faut le convertir en double.
                                compteEpargneModel.SetSolde(decimal.ToSingle(sqlDataReader.GetDecimal(1)));
                                compteEpargneModel.Type = sqlDataReader.GetString(3);
                                //Le taux d'interets est stocké en décimal dans la DB. Il faut le convertir en double.
                                compteEpargneModel.Taux = decimal.ToSingle(sqlDataReader.GetDecimal(4));
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

        /*internal static List<ClientModel> GetAllClients(string idConseiller)
        {
            throw new NotImplementedException();
        }*/
    }
}

