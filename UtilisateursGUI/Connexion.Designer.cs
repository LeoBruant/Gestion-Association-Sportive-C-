namespace UtilisateursGUI
{
    partial class Connexion
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.nomUtilisateur = new System.Windows.Forms.Label();
            this.nomUtilisateurChamp = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.motDePasseChamp = new System.Windows.Forms.TextBox();
            this.boutonConnexion = new System.Windows.Forms.Button();
            this.erreurNomUtilisateur = new System.Windows.Forms.Label();
            this.erreurMotDePasse = new System.Windows.Forms.Label();
            this.erreurIdentification = new System.Windows.Forms.Label();
            this.quitter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nomUtilisateur
            // 
            this.nomUtilisateur.Location = new System.Drawing.Point(137, 98);
            this.nomUtilisateur.Name = "nomUtilisateur";
            this.nomUtilisateur.Size = new System.Drawing.Size(191, 36);
            this.nomUtilisateur.TabIndex = 11;
            this.nomUtilisateur.Text = "Nom d\'utilisateur :";
            // 
            // nomUtilisateurChamp
            // 
            this.nomUtilisateurChamp.Location = new System.Drawing.Point(347, 98);
            this.nomUtilisateurChamp.Name = "nomUtilisateurChamp";
            this.nomUtilisateurChamp.Size = new System.Drawing.Size(308, 36);
            this.nomUtilisateurChamp.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(173, 182);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 28);
            this.label1.TabIndex = 9;
            this.label1.Text = "Mot de passe :";
            // 
            // motDePasseChamp
            // 
            this.motDePasseChamp.Location = new System.Drawing.Point(347, 179);
            this.motDePasseChamp.Name = "motDePasseChamp";
            this.motDePasseChamp.PasswordChar = '*';
            this.motDePasseChamp.Size = new System.Drawing.Size(308, 36);
            this.motDePasseChamp.TabIndex = 2;
            // 
            // boutonConnexion
            // 
            this.boutonConnexion.Location = new System.Drawing.Point(313, 272);
            this.boutonConnexion.Name = "boutonConnexion";
            this.boutonConnexion.Size = new System.Drawing.Size(172, 39);
            this.boutonConnexion.TabIndex = 3;
            this.boutonConnexion.Text = "Connexion";
            this.boutonConnexion.Click += new System.EventHandler(this.boutonConnexion_Click);
            // 
            // erreurNomUtilisateur
            // 
            this.erreurNomUtilisateur.AutoSize = true;
            this.erreurNomUtilisateur.BackColor = System.Drawing.Color.Transparent;
            this.erreurNomUtilisateur.ForeColor = System.Drawing.Color.Red;
            this.erreurNomUtilisateur.Location = new System.Drawing.Point(224, 137);
            this.erreurNomUtilisateur.Name = "erreurNomUtilisateur";
            this.erreurNomUtilisateur.Size = new System.Drawing.Size(347, 29);
            this.erreurNomUtilisateur.TabIndex = 4;
            this.erreurNomUtilisateur.Text = "Veuillez remplir le nom d\'utilisateur";
            this.erreurNomUtilisateur.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.erreurNomUtilisateur.Visible = false;
            // 
            // erreurMotDePasse
            // 
            this.erreurMotDePasse.AutoSize = true;
            this.erreurMotDePasse.BackColor = System.Drawing.Color.Transparent;
            this.erreurMotDePasse.ForeColor = System.Drawing.Color.Red;
            this.erreurMotDePasse.Location = new System.Drawing.Point(242, 230);
            this.erreurMotDePasse.Name = "erreurMotDePasse";
            this.erreurMotDePasse.Size = new System.Drawing.Size(313, 29);
            this.erreurMotDePasse.TabIndex = 5;
            this.erreurMotDePasse.Text = "Veuillez remplir le mot de passe";
            this.erreurMotDePasse.Visible = false;
            // 
            // erreurIdentification
            // 
            this.erreurIdentification.AutoSize = true;
            this.erreurIdentification.BackColor = System.Drawing.Color.Transparent;
            this.erreurIdentification.ForeColor = System.Drawing.Color.Red;
            this.erreurIdentification.Location = new System.Drawing.Point(173, 314);
            this.erreurIdentification.Name = "erreurIdentification";
            this.erreurIdentification.Size = new System.Drawing.Size(430, 29);
            this.erreurIdentification.TabIndex = 6;
            this.erreurIdentification.Text = "Nom d\'utilisateur ou mot de passe incorrect\r\n";
            this.erreurIdentification.Visible = false;
            // 
            // quitter
            // 
            this.quitter.Location = new System.Drawing.Point(327, 346);
            this.quitter.Name = "quitter";
            this.quitter.Size = new System.Drawing.Size(138, 39);
            this.quitter.TabIndex = 4;
            this.quitter.Text = "Quitter";
            this.quitter.UseVisualStyleBackColor = true;
            this.quitter.Click += new System.EventHandler(this.quitter_Click);
            // 
            // Connexion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 388);
            this.Controls.Add(this.quitter);
            this.Controls.Add(this.erreurIdentification);
            this.Controls.Add(this.erreurMotDePasse);
            this.Controls.Add(this.erreurNomUtilisateur);
            this.Controls.Add(this.boutonConnexion);
            this.Controls.Add(this.motDePasseChamp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nomUtilisateurChamp);
            this.Controls.Add(this.nomUtilisateur);
            this.Font = new System.Drawing.Font("Calibri Light", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "Connexion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Connexion";
            this.Load += new System.EventHandler(this.Connexion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nomUtilisateur;
        private System.Windows.Forms.TextBox nomUtilisateurChamp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox motDePasseChamp;
        private System.Windows.Forms.Button boutonConnexion;
        private System.Windows.Forms.Label erreurNomUtilisateur;
        private System.Windows.Forms.Label erreurMotDePasse;
        private System.Windows.Forms.Label erreurIdentification;
        private System.Windows.Forms.Button quitter;
    }
}

