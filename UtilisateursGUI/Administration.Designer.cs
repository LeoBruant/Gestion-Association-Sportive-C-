namespace UtilisateursGUI
{
    partial class Administration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Administration));
            this.adherents = new System.Windows.Forms.DataGridView();
            this.Retour = new System.Windows.Forms.Button();
            this.Deconnection = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.Modifier = new System.Windows.Forms.Button();
            this.Ajouter = new System.Windows.Forms.Button();
            this.Supprimer = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.fond1 = new System.Windows.Forms.RichTextBox();
            this.dt_sexe = new System.Windows.Forms.Label();
            this.dt_ddn = new System.Windows.Forms.Label();
            this.dt_prenom = new System.Windows.Forms.Label();
            this.dt_login = new System.Windows.Forms.Label();
            this.dt_id = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dt_nom = new System.Windows.Forms.Label();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.dt_aut_prelev = new System.Windows.Forms.Label();
            this.dt_archive = new System.Windows.Forms.Label();
            this.dt_dern_modif = new System.Windows.Forms.Label();
            this.dt_tel_tuteur = new System.Windows.Forms.Label();
            this.dt_tel = new System.Windows.Forms.Label();
            this.dt_email = new System.Windows.Forms.Label();
            this.erreur = new System.Windows.Forms.Label();
            this.success = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.dt_classe = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.adherents)).BeginInit();
            this.SuspendLayout();
            // 
            // adherents
            // 
            this.adherents.AllowUserToAddRows = false;
            this.adherents.AllowUserToResizeColumns = false;
            this.adherents.AllowUserToResizeRows = false;
            this.adherents.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.adherents.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.adherents.ColumnHeadersHeight = 29;
            this.adherents.ColumnHeadersVisible = false;
            this.adherents.Location = new System.Drawing.Point(12, 49);
            this.adherents.Name = "adherents";
            this.adherents.ReadOnly = true;
            this.adherents.RowHeadersWidth = 51;
            this.adherents.RowTemplate.Height = 24;
            this.adherents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.adherents.Size = new System.Drawing.Size(491, 113);
            this.adherents.TabIndex = 0;
            this.adherents.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.adherents_CellClick);
            // 
            // Retour
            // 
            this.Retour.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Retour.Location = new System.Drawing.Point(530, 49);
            this.Retour.Name = "Retour";
            this.Retour.Size = new System.Drawing.Size(121, 34);
            this.Retour.TabIndex = 2;
            this.Retour.Text = "Retour";
            this.Retour.UseVisualStyleBackColor = true;
            this.Retour.Click += new System.EventHandler(this.Retour_Click);
            // 
            // Deconnection
            // 
            this.Deconnection.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Deconnection.Location = new System.Drawing.Point(530, 89);
            this.Deconnection.Name = "Deconnection";
            this.Deconnection.Size = new System.Drawing.Size(121, 34);
            this.Deconnection.TabIndex = 3;
            this.Deconnection.Text = "Deconnexion";
            this.Deconnection.UseVisualStyleBackColor = true;
            this.Deconnection.Click += new System.EventHandler(this.Deconnexion_click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.richTextBox1.Location = new System.Drawing.Point(677, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(664, 263);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // Modifier
            // 
            this.Modifier.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Modifier.Location = new System.Drawing.Point(12, 196);
            this.Modifier.Name = "Modifier";
            this.Modifier.Size = new System.Drawing.Size(111, 34);
            this.Modifier.TabIndex = 5;
            this.Modifier.Text = "Modifier";
            this.Modifier.UseVisualStyleBackColor = true;
            this.Modifier.Click += new System.EventHandler(this.Modifier_Click);
            // 
            // Ajouter
            // 
            this.Ajouter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Ajouter.Location = new System.Drawing.Point(196, 196);
            this.Ajouter.Name = "Ajouter";
            this.Ajouter.Size = new System.Drawing.Size(111, 34);
            this.Ajouter.TabIndex = 6;
            this.Ajouter.Text = "Ajouter";
            this.Ajouter.UseVisualStyleBackColor = true;
            this.Ajouter.Click += new System.EventHandler(this.Ajouter_Click);
            // 
            // Supprimer
            // 
            this.Supprimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Supprimer.Location = new System.Drawing.Point(392, 196);
            this.Supprimer.Name = "Supprimer";
            this.Supprimer.Size = new System.Drawing.Size(111, 34);
            this.Supprimer.TabIndex = 7;
            this.Supprimer.Text = "Supprimer";
            this.Supprimer.UseVisualStyleBackColor = true;
            this.Supprimer.Click += new System.EventHandler(this.Supprimer_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Control;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBox1.Location = new System.Drawing.Point(21, 265);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(78, 23);
            this.textBox1.TabIndex = 10;
            this.textBox1.Text = "Details :";
            // 
            // fond1
            // 
            this.fond1.BackColor = System.Drawing.SystemColors.Window;
            this.fond1.Cursor = System.Windows.Forms.Cursors.Default;
            this.fond1.Location = new System.Drawing.Point(21, 303);
            this.fond1.Name = "fond1";
            this.fond1.ReadOnly = true;
            this.fond1.Size = new System.Drawing.Size(490, 202);
            this.fond1.TabIndex = 1;
            this.fond1.Text = "";
            // 
            // dt_sexe
            // 
            this.dt_sexe.AutoSize = true;
            this.dt_sexe.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.dt_sexe.Location = new System.Drawing.Point(202, 482);
            this.dt_sexe.Name = "dt_sexe";
            this.dt_sexe.Size = new System.Drawing.Size(37, 17);
            this.dt_sexe.TabIndex = 30;
            this.dt_sexe.Text = "sexe";
            this.dt_sexe.Visible = false;
            // 
            // dt_ddn
            // 
            this.dt_ddn.AutoSize = true;
            this.dt_ddn.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.dt_ddn.Location = new System.Drawing.Point(202, 449);
            this.dt_ddn.Name = "dt_ddn";
            this.dt_ddn.Size = new System.Drawing.Size(32, 17);
            this.dt_ddn.TabIndex = 29;
            this.dt_ddn.Text = "ddn";
            this.dt_ddn.Visible = false;
            // 
            // dt_prenom
            // 
            this.dt_prenom.AutoSize = true;
            this.dt_prenom.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.dt_prenom.Location = new System.Drawing.Point(201, 412);
            this.dt_prenom.Name = "dt_prenom";
            this.dt_prenom.Size = new System.Drawing.Size(56, 17);
            this.dt_prenom.TabIndex = 28;
            this.dt_prenom.Text = "prenom";
            this.dt_prenom.Visible = false;
            // 
            // dt_login
            // 
            this.dt_login.AutoSize = true;
            this.dt_login.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.dt_login.Location = new System.Drawing.Point(201, 343);
            this.dt_login.Name = "dt_login";
            this.dt_login.Size = new System.Drawing.Size(38, 17);
            this.dt_login.TabIndex = 27;
            this.dt_login.Text = "login";
            this.dt_login.Visible = false;
            // 
            // dt_id
            // 
            this.dt_id.AutoSize = true;
            this.dt_id.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.dt_id.Location = new System.Drawing.Point(202, 310);
            this.dt_id.Name = "dt_id";
            this.dt_id.Size = new System.Drawing.Size(19, 17);
            this.dt_id.TabIndex = 26;
            this.dt_id.Text = "id";
            this.dt_id.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(28, 482);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 17);
            this.label5.TabIndex = 25;
            this.label5.Text = "sexe :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(28, 449);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 17);
            this.label4.TabIndex = 24;
            this.label4.Text = "date de naissance :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(28, 412);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 17);
            this.label3.TabIndex = 23;
            this.label3.Text = "prenom :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(28, 343);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 22;
            this.label2.Text = "login :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(27, 310);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 17);
            this.label1.TabIndex = 21;
            this.label1.Text = "id :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(64, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(19, 17);
            this.label6.TabIndex = 31;
            this.label6.Text = "Id";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(236, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 17);
            this.label7.TabIndex = 32;
            this.label7.Text = "Nom";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(419, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 17);
            this.label8.TabIndex = 33;
            this.label8.Text = "Prenom";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Location = new System.Drawing.Point(30, 380);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 17);
            this.label9.TabIndex = 34;
            this.label9.Text = "nom :";
            // 
            // dt_nom
            // 
            this.dt_nom.AutoSize = true;
            this.dt_nom.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.dt_nom.Location = new System.Drawing.Point(201, 380);
            this.dt_nom.Name = "dt_nom";
            this.dt_nom.Size = new System.Drawing.Size(35, 17);
            this.dt_nom.TabIndex = 35;
            this.dt_nom.Text = "nom";
            this.dt_nom.Visible = false;
            // 
            // richTextBox2
            // 
            this.richTextBox2.BackColor = System.Drawing.SystemColors.Window;
            this.richTextBox2.Location = new System.Drawing.Point(677, 303);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.ReadOnly = true;
            this.richTextBox2.Size = new System.Drawing.Size(664, 202);
            this.richTextBox2.TabIndex = 36;
            this.richTextBox2.Text = "";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label10.Location = new System.Drawing.Point(686, 310);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 17);
            this.label10.TabIndex = 37;
            this.label10.Text = "email :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label11.Location = new System.Drawing.Point(686, 343);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(79, 17);
            this.label11.TabIndex = 38;
            this.label11.Text = "telephone :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label12.Location = new System.Drawing.Point(686, 380);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(120, 17);
            this.label12.TabIndex = 39;
            this.label12.Text = "telephone tuteur :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label13.Location = new System.Drawing.Point(686, 412);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(107, 17);
            this.label13.TabIndex = 40;
            this.label13.Text = "derniere modif :";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label14.Location = new System.Drawing.Point(686, 449);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(85, 17);
            this.label14.TabIndex = 41;
            this.label14.Text = "est archivé :";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label15.Location = new System.Drawing.Point(686, 482);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(172, 17);
            this.label15.TabIndex = 42;
            this.label15.Text = "autorisation prélèvement :";
            // 
            // dt_aut_prelev
            // 
            this.dt_aut_prelev.AutoSize = true;
            this.dt_aut_prelev.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.dt_aut_prelev.Location = new System.Drawing.Point(903, 482);
            this.dt_aut_prelev.Name = "dt_aut_prelev";
            this.dt_aut_prelev.Size = new System.Drawing.Size(164, 17);
            this.dt_aut_prelev.TabIndex = 48;
            this.dt_aut_prelev.Text = "autorisation prélèvement\r\n";
            this.dt_aut_prelev.Visible = false;
            // 
            // dt_archive
            // 
            this.dt_archive.AutoSize = true;
            this.dt_archive.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.dt_archive.Location = new System.Drawing.Point(903, 449);
            this.dt_archive.Name = "dt_archive";
            this.dt_archive.Size = new System.Drawing.Size(77, 17);
            this.dt_archive.TabIndex = 47;
            this.dt_archive.Text = "est archivé";
            this.dt_archive.Visible = false;
            // 
            // dt_dern_modif
            // 
            this.dt_dern_modif.AutoSize = true;
            this.dt_dern_modif.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.dt_dern_modif.Location = new System.Drawing.Point(903, 412);
            this.dt_dern_modif.Name = "dt_dern_modif";
            this.dt_dern_modif.Size = new System.Drawing.Size(99, 17);
            this.dt_dern_modif.TabIndex = 46;
            this.dt_dern_modif.Text = "derniere modif";
            this.dt_dern_modif.Visible = false;
            // 
            // dt_tel_tuteur
            // 
            this.dt_tel_tuteur.AutoSize = true;
            this.dt_tel_tuteur.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.dt_tel_tuteur.Location = new System.Drawing.Point(903, 380);
            this.dt_tel_tuteur.Name = "dt_tel_tuteur";
            this.dt_tel_tuteur.Size = new System.Drawing.Size(116, 17);
            this.dt_tel_tuteur.TabIndex = 45;
            this.dt_tel_tuteur.Text = "telephone tuteur ";
            this.dt_tel_tuteur.Visible = false;
            // 
            // dt_tel
            // 
            this.dt_tel.AutoSize = true;
            this.dt_tel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.dt_tel.Location = new System.Drawing.Point(903, 343);
            this.dt_tel.Name = "dt_tel";
            this.dt_tel.Size = new System.Drawing.Size(71, 17);
            this.dt_tel.TabIndex = 44;
            this.dt_tel.Text = "telephone\r\n";
            this.dt_tel.Visible = false;
            // 
            // dt_email
            // 
            this.dt_email.AutoSize = true;
            this.dt_email.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.dt_email.Location = new System.Drawing.Point(903, 310);
            this.dt_email.Name = "dt_email";
            this.dt_email.Size = new System.Drawing.Size(41, 17);
            this.dt_email.TabIndex = 43;
            this.dt_email.Text = "email";
            this.dt_email.Visible = false;
            // 
            // erreur
            // 
            this.erreur.AutoSize = true;
            this.erreur.Font = new System.Drawing.Font("Calibri Light", 12F);
            this.erreur.ForeColor = System.Drawing.Color.Red;
            this.erreur.Location = new System.Drawing.Point(224, 264);
            this.erreur.Name = "erreur";
            this.erreur.Size = new System.Drawing.Size(279, 24);
            this.erreur.TabIndex = 49;
            this.erreur.Text = "Aucun adhérent n\'est séléctionné";
            this.erreur.Visible = false;
            // 
            // success
            // 
            this.success.AutoSize = true;
            this.success.Font = new System.Drawing.Font("Calibri Light", 12F);
            this.success.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.success.Location = new System.Drawing.Point(247, 240);
            this.success.Name = "success";
            this.success.Size = new System.Drawing.Size(256, 24);
            this.success.TabIndex = 50;
            this.success.Text = "l\'adhérent a bien été supprimé";
            this.success.Visible = false;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.SystemColors.Window;
            this.label16.Location = new System.Drawing.Point(1111, 310);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(56, 17);
            this.label16.TabIndex = 51;
            this.label16.Text = "classe :";
            // 
            // dt_classe
            // 
            this.dt_classe.AutoSize = true;
            this.dt_classe.BackColor = System.Drawing.SystemColors.Window;
            this.dt_classe.Location = new System.Drawing.Point(1216, 310);
            this.dt_classe.Name = "dt_classe";
            this.dt_classe.Size = new System.Drawing.Size(48, 17);
            this.dt_classe.TabIndex = 52;
            this.dt_classe.Text = "classe";
            // 
            // Administration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1353, 541);
            this.Controls.Add(this.dt_classe);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.success);
            this.Controls.Add(this.erreur);
            this.Controls.Add(this.dt_aut_prelev);
            this.Controls.Add(this.dt_archive);
            this.Controls.Add(this.dt_dern_modif);
            this.Controls.Add(this.dt_tel_tuteur);
            this.Controls.Add(this.dt_tel);
            this.Controls.Add(this.dt_email);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.dt_nom);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dt_sexe);
            this.Controls.Add(this.dt_ddn);
            this.Controls.Add(this.dt_prenom);
            this.Controls.Add(this.dt_login);
            this.Controls.Add(this.dt_id);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fond1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Supprimer);
            this.Controls.Add(this.Ajouter);
            this.Controls.Add(this.Modifier);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.Deconnection);
            this.Controls.Add(this.Retour);
            this.Controls.Add(this.adherents);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Administration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "administrateur";
            this.Load += new System.EventHandler(this.administrateur_Load);
            ((System.ComponentModel.ISupportInitialize)(this.adherents)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView adherents;
        private System.Windows.Forms.Button Retour;
        private System.Windows.Forms.Button Deconnection;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button Modifier;
        private System.Windows.Forms.Button Ajouter;
        private System.Windows.Forms.Button Supprimer;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RichTextBox fond1;
        private System.Windows.Forms.Label dt_sexe;
        private System.Windows.Forms.Label dt_ddn;
        private System.Windows.Forms.Label dt_prenom;
        private System.Windows.Forms.Label dt_login;
        private System.Windows.Forms.Label dt_id;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label dt_nom;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label dt_aut_prelev;
        private System.Windows.Forms.Label dt_archive;
        private System.Windows.Forms.Label dt_dern_modif;
        private System.Windows.Forms.Label dt_tel_tuteur;
        private System.Windows.Forms.Label dt_tel;
        private System.Windows.Forms.Label dt_email;
        private System.Windows.Forms.Label erreur;
        public System.Windows.Forms.Label success;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label dt_classe;
    }
}