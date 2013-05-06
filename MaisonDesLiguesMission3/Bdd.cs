using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Oracle.DataAccess.Client;
using System.Configuration;
using System.Windows.Forms;
using System.Collections.ObjectModel;
using System.Text.RegularExpressions;  // bibliothèque pour les expressions régulières
using MaisonDesLigues;



namespace BaseDeDonnees
{
    class Bdd
    {
        //
        // propriétés membres
        //
        public OracleConnection CnOracle;
        private OracleCommand UneOracleCommand;
        private OracleDataAdapter UnOracleDataAdapter;
        private DataTable UneDataTable;
        private OracleTransaction UneOracleTransaction;
        //
        // méthodes
        //
        /// <summary>
        /// constructeur de la connexion
        /// </summary>
        /// <param name="UnLogin">login utilisateur</param>
        /// <param name="UnPwd">mot de passe utilisateur</param>
        public Bdd(String UnLogin, String UnPwd)
        {
            try
            {
                /// <remarks>on commence par récupérer dans CnString les informations contenues dans le fichier app.config
                /// pour la connectionString de nom StrConnMdl
                /// </remarks>
                ConnectionStringSettings CnString = ConfigurationManager.ConnectionStrings["StrConnMdl"];
                ///<remarks>
                /// on va remplacer dans la chaine de connexion les paramètres par le login et le pwd saisis
                ///dans les zones de texte. Pour ça on va utiliser la méthode Format de la classe String. 
                /// </remarks>
                CnOracle = new OracleConnection(string.Format(CnString.ConnectionString, UnLogin, UnPwd));
                CnOracle.Open();
            }
            catch (OracleException Oex)
            {
                throw new Exception("Erreur à la connexion" + Oex.Message);
            }
        }

        /// <summary>
        /// Méthode permettant de fermer la connexion
        /// </summary>
        public void FermerConnexion()
        {
            this.CnOracle.Close();
        }

        /// <summary>
        /// permet de récupérer le contenu d'une table ou d'une vue. 
        /// </summary>
        /// <returns>un objet de type datatable contenant les données récupérées</returns>
        public DataTable ObtenirDonnesOracle()
        {
            try
            {
                string Sql = "select id, nomparticipant || ' ' || prenomparticipant as NomPrenom from PARTICIPANT where dateenregistrementarrivee is null";
                this.UneOracleCommand = new OracleCommand(Sql, CnOracle);
                UnOracleDataAdapter = new OracleDataAdapter();
                UnOracleDataAdapter.SelectCommand = this.UneOracleCommand;
                UneDataTable = new DataTable();
                UnOracleDataAdapter.Fill(UneDataTable);
                return UneDataTable;
            }
            catch (Exception Ex)
            {
                throw new Exception("Erreur:" + Ex);
            }
        }


        public void MajVacation(String uneCle, Int32 unId)
        {
            String MessageErreur = "";
            try
            {
                UneOracleCommand = new OracleCommand("MDL.pckparticipant.pmodif_cle", CnOracle); //Package.procedure
                UneOracleCommand.CommandType = CommandType.StoredProcedure;
                // début de la transaction Oracle il vaut mieux gérer les transactions dans l'applicatif que dans la bd dans les procédures stockées.
                UneOracleCommand.Parameters.Add("pId", OracleDbType.Int32, ParameterDirection.Input).Value = unId;
                UneOracleCommand.Parameters.Add("puneCle", OracleDbType.Char, ParameterDirection.Input).Value = uneCle;
                UneOracleTransaction = this.CnOracle.BeginTransaction();
                //execution
                UneOracleCommand.ExecuteNonQuery();
                // fin de la transaction. Si on arrive à ce point, c'est qu'aucune exception n'a été levée
                UneOracleTransaction.Commit();
            }
            catch (OracleException Oex)
            {
                UneOracleTransaction.Rollback();
                throw new Exception("Erreur chargement packatage" + Oex.Message);
            }
            catch (Exception ex)
            {
                UneOracleTransaction.Rollback();
                throw new Exception("Erreur de la mise à jour de la vacation" + ex.Message);
            }
            finally
            {
                if (MessageErreur.Length > 0)
                {
                    // annulation de la transaction
                    UneOracleTransaction.Rollback();
                    // Déclenchement de l'exception
                    throw new Exception(MessageErreur);
                }
            }
        }
    }
}
