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

        public static void AddMaterielStock(MaterielModel materiel)
        {
            SqlConnection connection = null;
            try
            {
                connection = Connection.getInstance().GetConnection();
                using (SqlCommand sqlCommand = new SqlCommand("LP_AjoutMateriel", connection))
                {
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.Parameters.AddWithValue("@codeMateriel", SqlDbType.VarChar).Value = materiel.IdMateriel;
                    sqlCommand.Parameters.AddWithValue("@marque", SqlDbType.VarChar).Value = materiel.Marque;
                    sqlCommand.Parameters.AddWithValue("@libelle", SqlDbType.VarChar).Value = materiel.Libelle;
                    sqlCommand.Parameters.AddWithValue("@etatMateriel", SqlDbType.VarChar).Value = materiel.Etat;
                    /// tentative d'extraction d'erreur :
                    //Console.WriteLine("erreur");
                    using (SqlDataReader sqlDataReader = sqlCommand.ExecuteReader())
                    {
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
        }

        public static void AddMonopalmeStock(MonopalmeModel materiel)
        {
            SqlConnection connection = null;
            try
            {
                connection = Connection.getInstance().GetConnection();
                using (SqlCommand sqlCommand = new SqlCommand("LP_AjoutMonopalme", connection))
                {
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.Parameters.AddWithValue("@codeMateriel", SqlDbType.VarChar).Value = materiel.IdMateriel;
                    sqlCommand.Parameters.AddWithValue("@marque", SqlDbType.VarChar).Value = materiel.Marque;
                    sqlCommand.Parameters.AddWithValue("@libelle", SqlDbType.VarChar).Value = materiel.Libelle;
                    sqlCommand.Parameters.AddWithValue("@etatMateriel", SqlDbType.VarChar).Value = materiel.Etat;
                    sqlCommand.Parameters.AddWithValue("@taille", SqlDbType.VarChar).Value = materiel.Pointure;

                    /// tentative d'extraction d'erreur :
                    //Console.WriteLine("erreur");
                    using (SqlDataReader sqlDataReader = sqlCommand.ExecuteReader())
                    {
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
        }

        public static void AddCombinaisonStock(CombinaisonModel materiel)
        {
            SqlConnection connection = null;
            try
            {
                connection = Connection.getInstance().GetConnection();
                using (SqlCommand sqlCommand = new SqlCommand("LP_AjoutCombinaison", connection))
                {
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.Parameters.AddWithValue("@codeMateriel", SqlDbType.VarChar).Value = materiel.IdMateriel;
                    sqlCommand.Parameters.AddWithValue("@marque", SqlDbType.VarChar).Value = materiel.Marque;
                    sqlCommand.Parameters.AddWithValue("@libelle", SqlDbType.VarChar).Value = materiel.Libelle;
                    sqlCommand.Parameters.AddWithValue("@etatMateriel", SqlDbType.VarChar).Value = materiel.Etat;
                    sqlCommand.Parameters.AddWithValue("@taille", SqlDbType.VarChar).Value = materiel.Taille;

                    /// tentative d'extraction d'erreur :
                    //Console.WriteLine("erreur");
                    using (SqlDataReader sqlDataReader = sqlCommand.ExecuteReader())
                    {
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
        }

        public static void SuprimerPret(string id)
        {
            SqlConnection connection = null;
            try
            {
                connection = Connection.getInstance().GetConnection();
                using (SqlCommand sqlCommand = new SqlCommand("LP_SuprimerPret", connection))
                {
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.Parameters.AddWithValue("@id", SqlDbType.VarChar).Value = id;
                    /// tentative d'extraction d'erreur :
                    //Console.WriteLine("erreur");
                    using (SqlDataReader sqlDataReader = sqlCommand.ExecuteReader())
                    {
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
        }
        public static void AddEmprunt(string idEmprunt,string idMateriel, string idNageur, string etat, DateTime date)
        {
            SqlConnection connection = null;
            try
            {
                connection = Connection.getInstance().GetConnection();
                using (SqlCommand sqlCommand = new SqlCommand("LP_AjoutEmprunt", connection))
                {
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.Parameters.AddWithValue("@codePret", SqlDbType.VarChar).Value = idEmprunt;
                    sqlCommand.Parameters.AddWithValue("@codeMateriel", SqlDbType.VarChar).Value = idMateriel;
                    sqlCommand.Parameters.AddWithValue("@numNageur", SqlDbType.VarChar).Value = idNageur;
                    sqlCommand.Parameters.AddWithValue("@etatMateriel", SqlDbType.VarChar).Value = etat;
                    sqlCommand.Parameters.AddWithValue("@dateDebut", SqlDbType.Date).Value = date;
                    /// tentative d'extraction d'erreur :
                    //Console.WriteLine("erreur");
                    using (SqlDataReader sqlDataReader = sqlCommand.ExecuteReader())
                    {
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
        }

        public static List<StockModel> GetStock()
        {
            //La liste créée est une liste de Compte (et non de CompteCourant ou de CompteEpargne)
            List<StockModel> stocks = new List<StockModel>();
            SqlConnection connection = null;
            //SqlDataReader sqlDataReader = null;
            try
            {
                connection = Connection.getInstance().GetConnection();
                using (SqlCommand sqlCommand = new SqlCommand("LP_Stock", connection))
                {
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    using (SqlDataReader sqlDataReader = sqlCommand.ExecuteReader())
                    {
                        while (sqlDataReader.Read())
                        {
                            //Si les deux colonnes sont nul ce n'est ni une combinaison ni un monopalme
                            if (sqlDataReader.IsDBNull(1) && sqlDataReader.IsDBNull(2))
                            {
                                StockModel stock = new StockModel();
                                stock.setMateriel(sqlDataReader.GetString(0));
                                stock.setQuantite(sqlDataReader.GetInt32(3));
                                stocks.Add(stock);
                            }
                            else if (sqlDataReader.IsDBNull(1)) //c'est un monopalme
                            {
                                StockModel stock = new StockModel();
                                stock.setMateriel(sqlDataReader.GetString(0));
                                stock.setPointure(sqlDataReader.GetInt32(2));
                                stock.setQuantite(sqlDataReader.GetInt32(3));
                                stocks.Add(stock);
                            }
                            else //c'est une combinaison
                            {
                                StockModel stock = new StockModel();
                                stock.setMateriel(sqlDataReader.GetString(0));
                                stock.setTaille_Combi(sqlDataReader.GetString(1));
                                stock.setQuantite(sqlDataReader.GetInt32(3));
                                stocks.Add(stock);
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
            return stocks;
        }

        public static List<IdModel> GetLastPret()
        {
            //La liste créée est une liste de Compte (et non de CompteCourant ou de CompteEpargne)
            List<IdModel> id = new List<IdModel>();
            SqlConnection connection = null;
            //SqlDataReader sqlDataReader = null;
            try
            {
                connection = Connection.getInstance().GetConnection();
                using (SqlCommand sqlCommand = new SqlCommand("LP_LastPretId", connection))
                {
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    using (SqlDataReader sqlDataReader = sqlCommand.ExecuteReader())
                    {
                        while (sqlDataReader.Read())
                        {
                            IdModel dId = new IdModel();
                            dId.setId(sqlDataReader.GetString(0));
                            id.Add(dId);
                            //Si les deux colonnes sont nul ce n'est ni une combinaison ni un monopalme
                           
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
            return id;
        }

        public static List<IdModel> GetLastMateriel()
        {
            //La liste créée est une liste de Compte (et non de CompteCourant ou de CompteEpargne)
            List<IdModel> id = new List<IdModel>();
            SqlConnection connection = null;
            //SqlDataReader sqlDataReader = null;
            try
            {
                connection = Connection.getInstance().GetConnection();
                using (SqlCommand sqlCommand = new SqlCommand("LP_LastIdMat", connection))
                {
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    using (SqlDataReader sqlDataReader = sqlCommand.ExecuteReader())
                    {
                        while (sqlDataReader.Read())
                        {
                            IdModel dId = new IdModel();
                            dId.setId(sqlDataReader.GetString(0));
                            id.Add(dId);
                            //Si les deux colonnes sont nul ce n'est ni une combinaison ni un monopalme

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
            return id;
        }

        public static List<MaterielEmpruntModel> GetPret()
        {
            //La liste créée est une liste de Compte (et non de CompteCourant ou de CompteEpargne)
            List<MaterielEmpruntModel> EmpruntMats = new List<MaterielEmpruntModel>();
            SqlConnection connection = null;
            //SqlDataReader sqlDataReader = null;
            try
            {
                connection = Connection.getInstance().GetConnection();
                using (SqlCommand sqlCommand = new SqlCommand("LP_MaterielEmprunt", connection))
                {
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    using (SqlDataReader sqlDataReader = sqlCommand.ExecuteReader())
                    {
                        while (sqlDataReader.Read())
                        {
                            //Si les deux colonnes sont nul ce n'est ni une combinaison ni un monopalme
                            if (sqlDataReader.IsDBNull(3) && sqlDataReader.IsDBNull(4))
                            {
                                MaterielEmpruntModel mat = new MaterielEmpruntModel();
                                mat.setMateriel(sqlDataReader.GetString(0));
                                mat.setMarque(sqlDataReader.GetString(1));
                                mat.setType(sqlDataReader.GetString(2));
                                mat.setNom(sqlDataReader.GetString(5));
                                mat.setPrenom(sqlDataReader.GetString(6));
                                mat.setDate(sqlDataReader.GetDateTime(7));
                                EmpruntMats.Add(mat);
                            }
                            else if (sqlDataReader.IsDBNull(3)) //c'est un monopalme
                            {
                                MaterielEmpruntModel mat = new MaterielEmpruntModel();
                                mat.setMateriel(sqlDataReader.GetString(0));
                                mat.setMarque(sqlDataReader.GetString(1));
                                mat.setType(sqlDataReader.GetString(2));
                                mat.setPointure(sqlDataReader.GetInt32(4));
                                mat.setNom(sqlDataReader.GetString(5));
                                mat.setPrenom(sqlDataReader.GetString(6));
                                mat.setDate(sqlDataReader.GetDateTime(7));
                                EmpruntMats.Add(mat);
                            }
                            else //c'est une combinaison
                            {
                                MaterielEmpruntModel mat = new MaterielEmpruntModel();
                                mat.setMateriel(sqlDataReader.GetString(0));
                                mat.setMarque(sqlDataReader.GetString(1));
                                mat.setType(sqlDataReader.GetString(2));
                                mat.setTaille(sqlDataReader.GetString(3));
                                mat.setNom(sqlDataReader.GetString(5));
                                mat.setPrenom(sqlDataReader.GetString(6));
                                mat.setDate(sqlDataReader.GetDateTime(7));
                                EmpruntMats.Add(mat);
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
            return EmpruntMats;
        }
    }
}

