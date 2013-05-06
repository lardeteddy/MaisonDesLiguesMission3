using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BaseDeDonnees;
using System.Configuration;
using System.Drawing.Printing;

namespace MaisonDesLigues
{
    public partial class FrmPrincipale : Form
    {
        private Bdd UneConnexion;
        private String TitreApplication;

        /// <summary>
        /// Initialise les composants de la form
        /// </summary>
        public FrmPrincipale()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Fonction qui permet d'ajouter le qr code et la clé wpa sur une feuille pour pouvoir l'imprimer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uneimpression_PrintPage(object sender, PrintPageEventArgs e)
        {
            //Police, taille et couleur de la clé wpa
            Font drawFont = new Font("Arial", 16);
            SolidBrush drawBrush = new SolidBrush(Color.Black);
            //Prend les valeur de largeur et de hauteur de l'image du qr code
            Bitmap myBitmap1 = new Bitmap(PictureBox_QRCODE.Width, PictureBox_QRCODE.Height);
            //Dessine un bitmap avec les valeurs du qr code
            PictureBox_QRCODE.DrawToBitmap(myBitmap1, new Rectangle(0, 0, PictureBox_QRCODE.Width, PictureBox_QRCODE.Height));
            //dessine le qr code sur la page
            e.Graphics.DrawImage(myBitmap1, 380, 150);
            //dessine la clé wpa sur la page
            e.Graphics.DrawString(Txt_WPA.Text, drawFont, drawBrush, 300, 500);
        }

        /// <summary>
        /// initialise et vérifie le fonctionnement au début du programme
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmPrincipale_Load(object sender, EventArgs e)
        {
            UneConnexion = ((FrmLogin)Owner).UneConnexion;
            TitreApplication = ((FrmLogin)Owner).TitreApplication;
            this.Text = TitreApplication;
            //remplie la combo box
            Utilitaire.RemplirComboBox(UneConnexion, cmb_Participant);
            //si la combobox est vide l'application se ferme, elle n'a pas lieu d'être ouverte
            if (cmb_Participant.Items.Count == 0)
            {
                //si le boutton ok est cliquer alors on coupe la connexion et on ferme l'application
                if (MessageBox.Show("Aucun participant n'est prévu pour être enregistrer", ConfigurationManager.AppSettings["TitreApplication"], MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.OK)
                {
                    UneConnexion.FermerConnexion();
                    Application.Exit();
                }
            }
            cmb_Participant.Text = "Veuillez choisir un participant";
            Txt_WPA.Visible = false;
            radioButton2.Checked = true;
        }

        /// <summary>
        /// Boutton enregistrer qui appel la fonction pour générer le qr code, met a jour la base de donnée oracle
        /// Sauvegarde l'image du qr code dans le fichier bin, appel la fonction mail pour envoi un mail au participant
        /// et envoi un message de réussite
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_enregArrivé_Click(object sender, EventArgs e)
        {
            String ValeurCmb = Convert.ToString(cmb_Participant.SelectedValue);
            QRCODE UnQRCODE = new QRCODE();
            PictureBox_QRCODE.Image = UnQRCODE.QRGen(ValeurCmb, 10);
            UneConnexion.MajVacation(Txt_WPA.Text, Convert.ToInt32(ValeurCmb));
            PictureBox_QRCODE.Image.Save("QrCode" + cmb_Participant.Text + ".png");
            Utilitaire.EnvoiMail(Txt_courriel.Text, cmb_Participant.Text, Txt_WPA.Text);
            MessageBox.Show("L'email du participant a bien était envoyé!");
        }

        /// <summary>
        /// Quand on clique sur oui, on ferme la connexion et l'application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_Quitter_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Voulez-vous quitter l'application ?", ConfigurationManager.AppSettings["TitreApplication"], MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                UneConnexion.FermerConnexion();
                Application.Exit();
            }
        }

        /// <summary>
        /// Quand le radio boutton change de valeur, soit la textbox est visible et la clé wpa se génére, soit la textbox est invisible
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                Txt_WPA.Visible = true;
                Txt_WPA.Text = Utilitaire.GetRandom();
            }
            if (radioButton2.Checked)
            {
                Txt_WPA.Visible = false;
                Txt_WPA.Text = null;
            }
        }

        /// <summary>
        /// Boutton imprimer qui ouvre la fenêtre d'impression
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_Imprimer_Click(object sender, EventArgs e)
        {
            PrintDialog myPrinDialog1 = new PrintDialog();
            PrintDocument uneimpression = new PrintDocument();
            //on appel la fonction uneimpression_PrintPage qui va nous générer une feuille avec le qr code et la clé wpa
            uneimpression.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(uneimpression_PrintPage);
            myPrinDialog1.Document = uneimpression;
            //si on clique sur ok on imprime le document
            if (myPrinDialog1.ShowDialog() == DialogResult.OK)
            {
                uneimpression.Print();
            }
        }

        /// <summary>
        /// On remplie les textbox avec les données du participant
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmb_Participant_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (Convert.ToString(cmb_Participant.SelectedValue) != "System.Data.DataRowView")
            {
                Utilitaire.RemplirTextBox(UneConnexion, Txt_adresse, "adresse", Convert.ToString(cmb_Participant.SelectedValue));
                Utilitaire.RemplirTextBox(UneConnexion, Txt_cp, "cp", Convert.ToString(cmb_Participant.SelectedValue));
                Utilitaire.RemplirTextBox(UneConnexion, Txt_ville, "ville", Convert.ToString(cmb_Participant.SelectedValue));
                Utilitaire.RemplirTextBox(UneConnexion, Txt_telephone, "telephone", Convert.ToString(cmb_Participant.SelectedValue));
                Utilitaire.RemplirTextBox(UneConnexion, Txt_courriel, "mail", Convert.ToString(cmb_Participant.SelectedValue));
                Utilitaire.RemplirTextBox(UneConnexion, Txt_dateInscri, "dateinscrit", Convert.ToString(cmb_Participant.SelectedValue));
            }
        }



    }
}
