namespace UtilisateursGUI
{
    partial class ChoixAdmin
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
            this.deconnexion = new System.Windows.Forms.Button();
            this.accesAdministrateur = new System.Windows.Forms.Button();
            this.accesComptabilite = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // deconnexion
            // 
            this.deconnexion.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deconnexion.Location = new System.Drawing.Point(234, 353);
            this.deconnexion.Name = "deconnexion";
            this.deconnexion.Size = new System.Drawing.Size(334, 56);
            this.deconnexion.TabIndex = 3;
            this.deconnexion.Text = "Déconnexion";
            this.deconnexion.UseVisualStyleBackColor = true;
            this.deconnexion.Click += new System.EventHandler(this.deconnexion_Click);
            // 
            // accesAdministrateur
            // 
            this.accesAdministrateur.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accesAdministrateur.Location = new System.Drawing.Point(111, 79);
            this.accesAdministrateur.Name = "accesAdministrateur";
            this.accesAdministrateur.Size = new System.Drawing.Size(590, 77);
            this.accesAdministrateur.TabIndex = 1;
            this.accesAdministrateur.Text = "Acceder aux fonctionnalités administrateur";
            this.accesAdministrateur.UseVisualStyleBackColor = true;
            this.accesAdministrateur.Click += new System.EventHandler(this.accesAdministrateur_Click);
            // 
            // accesComptabilite
            // 
            this.accesComptabilite.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accesComptabilite.Location = new System.Drawing.Point(111, 220);
            this.accesComptabilite.Name = "accesComptabilite";
            this.accesComptabilite.Size = new System.Drawing.Size(590, 77);
            this.accesComptabilite.TabIndex = 2;
            this.accesComptabilite.Text = "Acceder aux fonctionnalités de comptabilité";
            this.accesComptabilite.UseVisualStyleBackColor = true;
            this.accesComptabilite.Click += new System.EventHandler(this.accesComptabilite_Click);
            // 
            // ChoixAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.accesComptabilite);
            this.Controls.Add(this.accesAdministrateur);
            this.Controls.Add(this.deconnexion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "ChoixAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChoixAdmin";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button deconnexion;
        private System.Windows.Forms.Button accesAdministrateur;
        private System.Windows.Forms.Button accesComptabilite;
    }
}