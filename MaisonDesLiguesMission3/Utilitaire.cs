using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BaseDeDonnees;
using System.Data;
using Oracle.DataAccess.Client;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Net;
using System.Net.Mail;

namespace MaisonDesLigues
{
    internal abstract class Utilitaire
    {

        /// <summary>
        /// méthode permettant de remplir une combobox à partir d'une source de données
        /// </summary>
        /// <param name="UneConnexion">L'objet connexion à utiliser pour la connexion à la BD</param>
        /// <param name="UneCombo"> La combobox que l'on doit remplir</param>
        public static void RemplirComboBox(Bdd UneConnexion, ComboBox UneCombo)
        {
            try
            {
                UneCombo.DataSource = UneConnexion.ObtenirDonnesOracle();
                UneCombo.DisplayMember = "NomPrenom";
                UneCombo.ValueMember = "id";
            }
            catch (Exception Ex)
            {
                throw new Exception("Erreur:" + Ex);
            }
        }

        /// <summary>
        /// Permet de remplir les combobox du frm principale
        /// </summary>
        /// <param name="UneConnexion">Connexion d'oracle</param>
        /// <param name="maTextBox">la textbox conserner</param>
        /// <param name="monChamp">Champ de oracle</param>
        /// <param name="idParticipant">L'id du participant</param>
        public static void RemplirTextBox(Bdd UneConnexion, TextBox maTextBox, String monChamp, String idParticipant)
        {
            int test;
            if (monChamp == "adresse")
            {
                test = 3;
            }
            else if (monChamp == "cp")
            {
                test = 5;
            }
            else if (monChamp == "ville")
            {
                test = 6;
            }
            else if (monChamp == "telephone")
            {
                test = 7;
            }
            else if (monChamp == "mail")
            {
                test = 8;
            }
            else if (monChamp == "dateinscrit")
            {
                test = 9;
            }
            else
            {
                test = 0;
            }

            //On selectionne toutes les infos du participant
            String MaRequete = "select * from participant where id=" + idParticipant;
            OracleCommand uneOracleCommand = new OracleCommand(MaRequete, UneConnexion.CnOracle);
            OracleDataAdapter uneOracleDataAdapter = new OracleDataAdapter();
            uneOracleDataAdapter.SelectCommand = uneOracleCommand;
            DataTable uneDataTable = new DataTable();
            uneOracleDataAdapter.Fill(uneDataTable);
            //On parcourt chaque ligne de la table, et on prend le numero de test qui est le n elements et on le recupère en string
            maTextBox.Text = uneDataTable.Rows[0].ItemArray[test].ToString();            
        }

        /// <summary>
        /// Permet de créer une chaine de caractère aléatoirement pour la clé wpa
        /// </summary>
        /// <returns></returns>
        public static string GetRandom()
        {
            StringBuilder builder = new StringBuilder();
            Random random = new Random();
            string stringlist = "0123456789abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";

            for (int i = 0; i < 24; i++)
            {
                builder.Append(stringlist[random.Next(0, stringlist.Length - 1)]);
            }

            return builder.ToString();
        }

        /// <summary>
        /// Envoi un mail au participant
        /// </summary>
        /// <param name="mail">Mail du participant</param>
        /// <param name="NomPrenom">Nom et prenom du participant</param>
        /// <param name="Cléwifi">Clé wifi générer pour le participant</param>
        public static void EnvoiMail(String mail, String NomPrenom, String Cléwifi)
        {
            // Objet mail
            MailMessage msg = new MailMessage();

            // Expéditeur (obligatoire). Notez qu'on peut spécifier le nom
            msg.From = new MailAddress("mdl83000@gmail.com", "Maison des ligues");
            
            // Destinataires (il en faut au moins un)
            msg.To.Add(new MailAddress(mail, "Participant"));

            //Objet du message
            msg.Subject = "Maison des ligues";

            // Texte du mail (facultatif)
            msg.Body = "Bonjour " + NomPrenom + ",\n\n" +
            "Nous vous souhaitons la bienvenue et un agréable séjour chez nous. Nous avons bien enregistrer votre arrivé.\n" +
            "Vous pouvez récupérer votre qr code en pièce jointe pour vous présentez au atelier que vous avez choisi.\n\n"+
            "Vous avez demandez une clé wifi voici un récapitulatif de celle ci :\n" + Cléwifi + "\n\n" +
            "En vous souhaitant une bonne journée, cordialement,\n"+
            "La Maison des Ligues.\n";
            
            // Fichier joint si besoin (facultatif)
            msg.Attachments.Add(new Attachment(@"C:\Users\Utilisateur\Desktop\MaisonDesLiguesMission3\MaisonDesLiguesMission3\bin\Debug\QrCode"+ NomPrenom +".png"));

            // Envoi du message SMTP
            SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
            client.EnableSsl = true;
            client.Credentials = new NetworkCredential("mdl83000@gmail.com", "maisondesligues");
            
            // Envoi du mail
            client.Send(msg);
        }
    }
}
