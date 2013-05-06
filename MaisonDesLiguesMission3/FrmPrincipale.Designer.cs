namespace MaisonDesLigues
{
    partial class FrmPrincipale
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmb_Participant = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Txt_telephone = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Txt_dateInscri = new System.Windows.Forms.TextBox();
            this.Txt_courriel = new System.Windows.Forms.TextBox();
            this.Txt_ville = new System.Windows.Forms.TextBox();
            this.Txt_cp = new System.Windows.Forms.TextBox();
            this.Txt_adresse = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Txt_WPA = new System.Windows.Forms.TextBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.Btn_enregArrivé = new System.Windows.Forms.Button();
            this.PictureBox_QRCODE = new System.Windows.Forms.PictureBox();
            this.Btn_Quitter = new System.Windows.Forms.Button();
            this.Btn_Imprimer = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_QRCODE)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmb_Participant);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(290, 76);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Participant";
            // 
            // cmb_Participant
            // 
            this.cmb_Participant.FormattingEnabled = true;
            this.cmb_Participant.Location = new System.Drawing.Point(32, 29);
            this.cmb_Participant.Name = "cmb_Participant";
            this.cmb_Participant.Size = new System.Drawing.Size(151, 21);
            this.cmb_Participant.TabIndex = 0;
            this.cmb_Participant.SelectionChangeCommitted += new System.EventHandler(this.cmb_Participant_SelectionChangeCommitted);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Txt_telephone);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.Txt_dateInscri);
            this.groupBox2.Controls.Add(this.Txt_courriel);
            this.groupBox2.Controls.Add(this.Txt_ville);
            this.groupBox2.Controls.Add(this.Txt_cp);
            this.groupBox2.Controls.Add(this.Txt_adresse);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(12, 106);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(415, 229);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Informations du participant";
            // 
            // Txt_telephone
            // 
            this.Txt_telephone.Enabled = false;
            this.Txt_telephone.Location = new System.Drawing.Point(147, 193);
            this.Txt_telephone.Name = "Txt_telephone";
            this.Txt_telephone.Size = new System.Drawing.Size(143, 20);
            this.Txt_telephone.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 196);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Telephone";
            // 
            // Txt_dateInscri
            // 
            this.Txt_dateInscri.Enabled = false;
            this.Txt_dateInscri.Location = new System.Drawing.Point(147, 163);
            this.Txt_dateInscri.Name = "Txt_dateInscri";
            this.Txt_dateInscri.Size = new System.Drawing.Size(143, 20);
            this.Txt_dateInscri.TabIndex = 9;
            // 
            // Txt_courriel
            // 
            this.Txt_courriel.Enabled = false;
            this.Txt_courriel.Location = new System.Drawing.Point(147, 129);
            this.Txt_courriel.Name = "Txt_courriel";
            this.Txt_courriel.Size = new System.Drawing.Size(143, 20);
            this.Txt_courriel.TabIndex = 8;
            // 
            // Txt_ville
            // 
            this.Txt_ville.Enabled = false;
            this.Txt_ville.Location = new System.Drawing.Point(147, 98);
            this.Txt_ville.Name = "Txt_ville";
            this.Txt_ville.Size = new System.Drawing.Size(143, 20);
            this.Txt_ville.TabIndex = 7;
            // 
            // Txt_cp
            // 
            this.Txt_cp.Enabled = false;
            this.Txt_cp.Location = new System.Drawing.Point(147, 64);
            this.Txt_cp.Name = "Txt_cp";
            this.Txt_cp.Size = new System.Drawing.Size(143, 20);
            this.Txt_cp.TabIndex = 6;
            // 
            // Txt_adresse
            // 
            this.Txt_adresse.Enabled = false;
            this.Txt_adresse.Location = new System.Drawing.Point(147, 30);
            this.Txt_adresse.Name = "Txt_adresse";
            this.Txt_adresse.Size = new System.Drawing.Size(238, 20);
            this.Txt_adresse.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Date d\'inscription";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Courriel";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ville";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Code Postal";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Adresse";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Txt_WPA);
            this.groupBox3.Controls.Add(this.radioButton2);
            this.groupBox3.Controls.Add(this.radioButton1);
            this.groupBox3.Location = new System.Drawing.Point(12, 341);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(415, 103);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Clé Wi-fi";
            // 
            // Txt_WPA
            // 
            this.Txt_WPA.Enabled = false;
            this.Txt_WPA.Location = new System.Drawing.Point(74, 58);
            this.Txt_WPA.Name = "Txt_WPA";
            this.Txt_WPA.Size = new System.Drawing.Size(216, 20);
            this.Txt_WPA.TabIndex = 2;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(202, 19);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(45, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Non";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(98, 19);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(41, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Oui";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // Btn_enregArrivé
            // 
            this.Btn_enregArrivé.Location = new System.Drawing.Point(303, 450);
            this.Btn_enregArrivé.Name = "Btn_enregArrivé";
            this.Btn_enregArrivé.Size = new System.Drawing.Size(124, 23);
            this.Btn_enregArrivé.TabIndex = 4;
            this.Btn_enregArrivé.Text = "Enregistrer l\'arrivée";
            this.Btn_enregArrivé.UseVisualStyleBackColor = true;
            this.Btn_enregArrivé.Click += new System.EventHandler(this.Btn_enregArrivé_Click);
            // 
            // PictureBox_QRCODE
            // 
            this.PictureBox_QRCODE.Location = new System.Drawing.Point(502, 12);
            this.PictureBox_QRCODE.Name = "PictureBox_QRCODE";
            this.PictureBox_QRCODE.Size = new System.Drawing.Size(309, 260);
            this.PictureBox_QRCODE.TabIndex = 6;
            this.PictureBox_QRCODE.TabStop = false;
            // 
            // Btn_Quitter
            // 
            this.Btn_Quitter.Location = new System.Drawing.Point(619, 404);
            this.Btn_Quitter.Name = "Btn_Quitter";
            this.Btn_Quitter.Size = new System.Drawing.Size(191, 57);
            this.Btn_Quitter.TabIndex = 7;
            this.Btn_Quitter.Text = "Quitter";
            this.Btn_Quitter.UseVisualStyleBackColor = true;
            this.Btn_Quitter.Click += new System.EventHandler(this.Btn_Quitter_Click);
            // 
            // Btn_Imprimer
            // 
            this.Btn_Imprimer.Location = new System.Drawing.Point(605, 292);
            this.Btn_Imprimer.Name = "Btn_Imprimer";
            this.Btn_Imprimer.Size = new System.Drawing.Size(75, 23);
            this.Btn_Imprimer.TabIndex = 8;
            this.Btn_Imprimer.Text = "Imprimer";
            this.Btn_Imprimer.UseVisualStyleBackColor = true;
            this.Btn_Imprimer.Click += new System.EventHandler(this.Btn_Imprimer_Click);
            // 
            // FrmPrincipale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 480);
            this.Controls.Add(this.Btn_Imprimer);
            this.Controls.Add(this.Btn_Quitter);
            this.Controls.Add(this.PictureBox_QRCODE);
            this.Controls.Add(this.Btn_enregArrivé);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmPrincipale";
            this.Text = "FrmPrincipale";
            this.Load += new System.EventHandler(this.FrmPrincipale_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_QRCODE)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmb_Participant;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox Txt_WPA;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.TextBox Txt_dateInscri;
        private System.Windows.Forms.TextBox Txt_courriel;
        private System.Windows.Forms.TextBox Txt_ville;
        private System.Windows.Forms.TextBox Txt_cp;
        private System.Windows.Forms.TextBox Txt_adresse;
        private System.Windows.Forms.Button Btn_enregArrivé;
        private System.Windows.Forms.PictureBox PictureBox_QRCODE;
        private System.Windows.Forms.Button Btn_Quitter;
        private System.Windows.Forms.TextBox Txt_telephone;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button Btn_Imprimer;
    }
}