namespace UtilisateursGUI
{
    partial class AjoutEleve
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
            this.components = new System.ComponentModel.Container();
            this.login = new System.Windows.Forms.Label();
            this.motDePasse = new System.Windows.Forms.Label();
            this.prenom = new System.Windows.Forms.Label();
            this.nom = new System.Windows.Forms.Label();
            this.dateDeNaissance = new System.Windows.Forms.Label();
            this.sexe = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.Label();
            this.numTelEleve = new System.Windows.Forms.Label();
            this.numTelTuteur = new System.Windows.Forms.Label();
            this.prelevementAutorise = new System.Windows.Forms.Label();
            this.annuler = new System.Windows.Forms.Button();
            this.ajouter = new System.Windows.Forms.Button();
            this.ajoutLoginChamp = new System.Windows.Forms.TextBox();
            this.ajoutMotDePasseChamp = new System.Windows.Forms.TextBox();
            this.ajoutNomChamp = new System.Windows.Forms.TextBox();
            this.ajoutPrenomChamp = new System.Windows.Forms.TextBox();
            this.ajoutEmailChamp = new System.Windows.Forms.TextBox();
            this.ajoutTelephoneChamp = new System.Windows.Forms.TextBox();
            this.ajoutTelephoneTuteurChamp = new System.Windows.Forms.TextBox();
            this.erreurChampsVides = new System.Windows.Forms.Label();
            this.ajoutDateDeNaissanceChamp = new System.Windows.Forms.DateTimePicker();
            this.oui = new System.Windows.Forms.RadioButton();
            this.non = new System.Windows.Forms.RadioButton();
            this.ajoutAutoPrelevement = new System.Windows.Forms.GroupBox();
            this.classe = new System.Windows.Forms.Label();
            this.classeChamp = new System.Windows.Forms.ComboBox();
            this.cLASSEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gestionAssociationSportiveDataSet = new UtilisateursGUI.GestionAssociationSportiveDataSet();
            this.success = new System.Windows.Forms.Label();
            this.ajoutSexeChamp = new System.Windows.Forms.ComboBox();
            this.existe = new System.Windows.Forms.Label();
            this.cLASSETableAdapter = new UtilisateursGUI.GestionAssociationSportiveDataSetTableAdapters.CLASSETableAdapter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nonSweat = new System.Windows.Forms.RadioButton();
            this.ouiSweat = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.ajoutAutoPrelevement.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cLASSEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionAssociationSportiveDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // login
            // 
            this.login.AutoSize = true;
            this.login.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login.Location = new System.Drawing.Point(5, 7);
            this.login.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(52, 19);
            this.login.TabIndex = 0;
            this.login.Text = "Login :";
            // 
            // motDePasse
            // 
            this.motDePasse.AutoSize = true;
            this.motDePasse.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.motDePasse.Location = new System.Drawing.Point(9, 34);
            this.motDePasse.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.motDePasse.Name = "motDePasse";
            this.motDePasse.Size = new System.Drawing.Size(104, 19);
            this.motDePasse.TabIndex = 1;
            this.motDePasse.Text = "Mot de passe :";
            // 
            // prenom
            // 
            this.prenom.AutoSize = true;
            this.prenom.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prenom.Location = new System.Drawing.Point(9, 96);
            this.prenom.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.prenom.Name = "prenom";
            this.prenom.Size = new System.Drawing.Size(68, 19);
            this.prenom.TabIndex = 2;
            this.prenom.Text = "Prénom :";
            // 
            // nom
            // 
            this.nom.AutoSize = true;
            this.nom.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nom.Location = new System.Drawing.Point(9, 65);
            this.nom.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nom.Name = "nom";
            this.nom.Size = new System.Drawing.Size(48, 19);
            this.nom.TabIndex = 3;
            this.nom.Text = "Nom :";
            // 
            // dateDeNaissance
            // 
            this.dateDeNaissance.AutoSize = true;
            this.dateDeNaissance.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateDeNaissance.Location = new System.Drawing.Point(9, 128);
            this.dateDeNaissance.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.dateDeNaissance.Name = "dateDeNaissance";
            this.dateDeNaissance.Size = new System.Drawing.Size(135, 19);
            this.dateDeNaissance.TabIndex = 4;
            this.dateDeNaissance.Text = "Date de naissance :";
            // 
            // sexe
            // 
            this.sexe.AutoSize = true;
            this.sexe.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sexe.Location = new System.Drawing.Point(9, 158);
            this.sexe.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.sexe.Name = "sexe";
            this.sexe.Size = new System.Drawing.Size(47, 19);
            this.sexe.TabIndex = 5;
            this.sexe.Text = "Sexe :";
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email.Location = new System.Drawing.Point(8, 193);
            this.email.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(54, 19);
            this.email.TabIndex = 6;
            this.email.Text = "Email :";
            // 
            // numTelEleve
            // 
            this.numTelEleve.AutoSize = true;
            this.numTelEleve.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numTelEleve.Location = new System.Drawing.Point(8, 228);
            this.numTelEleve.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.numTelEleve.Name = "numTelEleve";
            this.numTelEleve.Size = new System.Drawing.Size(84, 19);
            this.numTelEleve.TabIndex = 7;
            this.numTelEleve.Text = "Téléphone :";
            // 
            // numTelTuteur
            // 
            this.numTelTuteur.AutoSize = true;
            this.numTelTuteur.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numTelTuteur.Location = new System.Drawing.Point(9, 262);
            this.numTelTuteur.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.numTelTuteur.Name = "numTelTuteur";
            this.numTelTuteur.Size = new System.Drawing.Size(128, 19);
            this.numTelTuteur.TabIndex = 8;
            this.numTelTuteur.Text = "Téléphone tuteur :";
            // 
            // prelevementAutorise
            // 
            this.prelevementAutorise.AutoSize = true;
            this.prelevementAutorise.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prelevementAutorise.Location = new System.Drawing.Point(9, 291);
            this.prelevementAutorise.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.prelevementAutorise.Name = "prelevementAutorise";
            this.prelevementAutorise.Size = new System.Drawing.Size(174, 19);
            this.prelevementAutorise.TabIndex = 9;
            this.prelevementAutorise.Text = "Autorise le prélèvement :";
            // 
            // annuler
            // 
            this.annuler.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.annuler.Location = new System.Drawing.Point(439, 19);
            this.annuler.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.annuler.Name = "annuler";
            this.annuler.Size = new System.Drawing.Size(128, 51);
            this.annuler.TabIndex = 11;
            this.annuler.Text = "Retour";
            this.annuler.UseVisualStyleBackColor = true;
            this.annuler.Click += new System.EventHandler(this.annuler_Click);
            // 
            // ajouter
            // 
            this.ajouter.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ajouter.Location = new System.Drawing.Point(439, 96);
            this.ajouter.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ajouter.Name = "ajouter";
            this.ajouter.Size = new System.Drawing.Size(128, 51);
            this.ajouter.TabIndex = 12;
            this.ajouter.Text = "Ajouter";
            this.ajouter.UseVisualStyleBackColor = true;
            this.ajouter.Click += new System.EventHandler(this.ajouter_Click);
            // 
            // ajoutLoginChamp
            // 
            this.ajoutLoginChamp.Font = new System.Drawing.Font("Calibri Light", 10.2F);
            this.ajoutLoginChamp.Location = new System.Drawing.Point(61, 6);
            this.ajoutLoginChamp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ajoutLoginChamp.Name = "ajoutLoginChamp";
            this.ajoutLoginChamp.Size = new System.Drawing.Size(144, 24);
            this.ajoutLoginChamp.TabIndex = 13;
            // 
            // ajoutMotDePasseChamp
            // 
            this.ajoutMotDePasseChamp.Font = new System.Drawing.Font("Calibri Light", 10.2F);
            this.ajoutMotDePasseChamp.Location = new System.Drawing.Point(117, 33);
            this.ajoutMotDePasseChamp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ajoutMotDePasseChamp.Name = "ajoutMotDePasseChamp";
            this.ajoutMotDePasseChamp.Size = new System.Drawing.Size(144, 24);
            this.ajoutMotDePasseChamp.TabIndex = 14;
            // 
            // ajoutNomChamp
            // 
            this.ajoutNomChamp.Font = new System.Drawing.Font("Calibri Light", 10.2F);
            this.ajoutNomChamp.Location = new System.Drawing.Point(61, 64);
            this.ajoutNomChamp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ajoutNomChamp.Name = "ajoutNomChamp";
            this.ajoutNomChamp.Size = new System.Drawing.Size(144, 24);
            this.ajoutNomChamp.TabIndex = 15;
            // 
            // ajoutPrenomChamp
            // 
            this.ajoutPrenomChamp.Font = new System.Drawing.Font("Calibri Light", 10.2F);
            this.ajoutPrenomChamp.Location = new System.Drawing.Point(81, 93);
            this.ajoutPrenomChamp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ajoutPrenomChamp.Name = "ajoutPrenomChamp";
            this.ajoutPrenomChamp.Size = new System.Drawing.Size(144, 24);
            this.ajoutPrenomChamp.TabIndex = 16;
            // 
            // ajoutEmailChamp
            // 
            this.ajoutEmailChamp.Font = new System.Drawing.Font("Calibri Light", 10.2F);
            this.ajoutEmailChamp.Location = new System.Drawing.Point(66, 192);
            this.ajoutEmailChamp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ajoutEmailChamp.Name = "ajoutEmailChamp";
            this.ajoutEmailChamp.Size = new System.Drawing.Size(144, 24);
            this.ajoutEmailChamp.TabIndex = 19;
            // 
            // ajoutTelephoneChamp
            // 
            this.ajoutTelephoneChamp.Font = new System.Drawing.Font("Calibri Light", 10.2F);
            this.ajoutTelephoneChamp.Location = new System.Drawing.Point(96, 227);
            this.ajoutTelephoneChamp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ajoutTelephoneChamp.Name = "ajoutTelephoneChamp";
            this.ajoutTelephoneChamp.Size = new System.Drawing.Size(144, 24);
            this.ajoutTelephoneChamp.TabIndex = 20;
            // 
            // ajoutTelephoneTuteurChamp
            // 
            this.ajoutTelephoneTuteurChamp.Font = new System.Drawing.Font("Calibri Light", 10.2F);
            this.ajoutTelephoneTuteurChamp.Location = new System.Drawing.Point(141, 261);
            this.ajoutTelephoneTuteurChamp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ajoutTelephoneTuteurChamp.Name = "ajoutTelephoneTuteurChamp";
            this.ajoutTelephoneTuteurChamp.Size = new System.Drawing.Size(144, 24);
            this.ajoutTelephoneTuteurChamp.TabIndex = 21;
            // 
            // erreurChampsVides
            // 
            this.erreurChampsVides.AutoSize = true;
            this.erreurChampsVides.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.erreurChampsVides.ForeColor = System.Drawing.Color.Red;
            this.erreurChampsVides.Location = new System.Drawing.Point(380, 167);
            this.erreurChampsVides.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.erreurChampsVides.Name = "erreurChampsVides";
            this.erreurChampsVides.Size = new System.Drawing.Size(219, 19);
            this.erreurChampsVides.TabIndex = 24;
            this.erreurChampsVides.Text = "Veuillez remplir tous les champs";
            this.erreurChampsVides.Visible = false;
            // 
            // ajoutDateDeNaissanceChamp
            // 
            this.ajoutDateDeNaissanceChamp.Font = new System.Drawing.Font("Calibri Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ajoutDateDeNaissanceChamp.Location = new System.Drawing.Point(148, 124);
            this.ajoutDateDeNaissanceChamp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ajoutDateDeNaissanceChamp.Name = "ajoutDateDeNaissanceChamp";
            this.ajoutDateDeNaissanceChamp.Size = new System.Drawing.Size(197, 24);
            this.ajoutDateDeNaissanceChamp.TabIndex = 29;
            this.ajoutDateDeNaissanceChamp.Value = new System.DateTime(2020, 12, 11, 0, 0, 0, 0);
            // 
            // oui
            // 
            this.oui.AutoSize = true;
            this.oui.Font = new System.Drawing.Font("Calibri Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oui.Location = new System.Drawing.Point(0, 0);
            this.oui.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.oui.Name = "oui";
            this.oui.Size = new System.Drawing.Size(43, 21);
            this.oui.TabIndex = 0;
            this.oui.TabStop = true;
            this.oui.Text = "oui";
            this.oui.UseVisualStyleBackColor = true;
            this.oui.CheckedChanged += new System.EventHandler(this.oui_CheckedChanged);
            // 
            // non
            // 
            this.non.AutoSize = true;
            this.non.Font = new System.Drawing.Font("Calibri Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.non.Location = new System.Drawing.Point(47, 0);
            this.non.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.non.Name = "non";
            this.non.Size = new System.Drawing.Size(47, 21);
            this.non.TabIndex = 31;
            this.non.TabStop = true;
            this.non.Text = "non";
            this.non.UseVisualStyleBackColor = true;
            this.non.CheckedChanged += new System.EventHandler(this.non_CheckedChanged);
            // 
            // ajoutAutoPrelevement
            // 
            this.ajoutAutoPrelevement.Controls.Add(this.non);
            this.ajoutAutoPrelevement.Controls.Add(this.oui);
            this.ajoutAutoPrelevement.Location = new System.Drawing.Point(187, 291);
            this.ajoutAutoPrelevement.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ajoutAutoPrelevement.Name = "ajoutAutoPrelevement";
            this.ajoutAutoPrelevement.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ajoutAutoPrelevement.Size = new System.Drawing.Size(87, 21);
            this.ajoutAutoPrelevement.TabIndex = 30;
            this.ajoutAutoPrelevement.TabStop = false;
            // 
            // classe
            // 
            this.classe.AutoSize = true;
            this.classe.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.classe.Location = new System.Drawing.Point(8, 365);
            this.classe.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.classe.Name = "classe";
            this.classe.Size = new System.Drawing.Size(58, 19);
            this.classe.TabIndex = 32;
            this.classe.Text = "Classe :";
            // 
            // classeChamp
            // 
            this.classeChamp.DataSource = this.cLASSEBindingSource;
            this.classeChamp.DisplayMember = "Libelle_classe";
            this.classeChamp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.classeChamp.FormattingEnabled = true;
            this.classeChamp.Location = new System.Drawing.Point(71, 366);
            this.classeChamp.Name = "classeChamp";
            this.classeChamp.Size = new System.Drawing.Size(121, 21);
            this.classeChamp.TabIndex = 33;
            this.classeChamp.ValueMember = "Id_classe";
            // 
            // cLASSEBindingSource
            // 
            this.cLASSEBindingSource.DataMember = "CLASSE";
            this.cLASSEBindingSource.DataSource = this.gestionAssociationSportiveDataSet;
            // 
            // gestionAssociationSportiveDataSet
            // 
            this.gestionAssociationSportiveDataSet.DataSetName = "GestionAssociationSportiveDataSet";
            this.gestionAssociationSportiveDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // success
            // 
            this.success.AutoSize = true;
            this.success.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.success.Location = new System.Drawing.Point(404, 197);
            this.success.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.success.Name = "success";
            this.success.Size = new System.Drawing.Size(192, 19);
            this.success.TabIndex = 34;
            this.success.Text = "L\'adhérent a bien été ajouté";
            this.success.Visible = false;
            // 
            // ajoutSexeChamp
            // 
            this.ajoutSexeChamp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ajoutSexeChamp.FormattingEnabled = true;
            this.ajoutSexeChamp.Items.AddRange(new object[] {
            "Homme",
            "Femme",
            "Autre"});
            this.ajoutSexeChamp.Location = new System.Drawing.Point(60, 158);
            this.ajoutSexeChamp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ajoutSexeChamp.Name = "ajoutSexeChamp";
            this.ajoutSexeChamp.Size = new System.Drawing.Size(92, 21);
            this.ajoutSexeChamp.TabIndex = 35;
            // 
            // existe
            // 
            this.existe.AutoSize = true;
            this.existe.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.existe.Location = new System.Drawing.Point(348, 228);
            this.existe.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.existe.Name = "existe";
            this.existe.Size = new System.Drawing.Size(253, 19);
            this.existe.TabIndex = 36;
            this.existe.Text = "Un adhérent avec ce login existe déjà";
            this.existe.Visible = false;
            // 
            // cLASSETableAdapter
            // 
            this.cLASSETableAdapter.ClearBeforeFill = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nonSweat);
            this.groupBox1.Controls.Add(this.ouiSweat);
            this.groupBox1.Location = new System.Drawing.Point(126, 328);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(89, 21);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            // 
            // nonSweat
            // 
            this.nonSweat.AutoSize = true;
            this.nonSweat.Font = new System.Drawing.Font("Calibri Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nonSweat.Location = new System.Drawing.Point(47, 0);
            this.nonSweat.Margin = new System.Windows.Forms.Padding(2);
            this.nonSweat.Name = "nonSweat";
            this.nonSweat.Size = new System.Drawing.Size(47, 21);
            this.nonSweat.TabIndex = 31;
            this.nonSweat.TabStop = true;
            this.nonSweat.Text = "non";
            this.nonSweat.UseVisualStyleBackColor = true;
            this.nonSweat.CheckedChanged += new System.EventHandler(this.nonSweat_CheckedChanged);
            // 
            // ouiSweat
            // 
            this.ouiSweat.AutoSize = true;
            this.ouiSweat.Font = new System.Drawing.Font("Calibri Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ouiSweat.Location = new System.Drawing.Point(0, 0);
            this.ouiSweat.Margin = new System.Windows.Forms.Padding(2);
            this.ouiSweat.Name = "ouiSweat";
            this.ouiSweat.Size = new System.Drawing.Size(43, 21);
            this.ouiSweat.TabIndex = 0;
            this.ouiSweat.TabStop = true;
            this.ouiSweat.Text = "oui";
            this.ouiSweat.UseVisualStyleBackColor = true;
            this.ouiSweat.CheckedChanged += new System.EventHandler(this.ouiSweat_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 328);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 19);
            this.label1.TabIndex = 37;
            this.label1.Text = "Prend le sweat :";
            // 
            // AjoutEleve
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 393);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.existe);
            this.Controls.Add(this.ajoutSexeChamp);
            this.Controls.Add(this.success);
            this.Controls.Add(this.classeChamp);
            this.Controls.Add(this.classe);
            this.Controls.Add(this.ajoutAutoPrelevement);
            this.Controls.Add(this.ajoutDateDeNaissanceChamp);
            this.Controls.Add(this.erreurChampsVides);
            this.Controls.Add(this.ajoutTelephoneTuteurChamp);
            this.Controls.Add(this.ajoutTelephoneChamp);
            this.Controls.Add(this.ajoutEmailChamp);
            this.Controls.Add(this.ajoutPrenomChamp);
            this.Controls.Add(this.ajoutNomChamp);
            this.Controls.Add(this.ajoutMotDePasseChamp);
            this.Controls.Add(this.ajoutLoginChamp);
            this.Controls.Add(this.ajouter);
            this.Controls.Add(this.annuler);
            this.Controls.Add(this.prelevementAutorise);
            this.Controls.Add(this.numTelTuteur);
            this.Controls.Add(this.numTelEleve);
            this.Controls.Add(this.email);
            this.Controls.Add(this.sexe);
            this.Controls.Add(this.dateDeNaissance);
            this.Controls.Add(this.nom);
            this.Controls.Add(this.prenom);
            this.Controls.Add(this.motDePasse);
            this.Controls.Add(this.login);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "AjoutEleve";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AjoutEleve";
            this.Load += new System.EventHandler(this.AjoutEleve_Load);
            this.ajoutAutoPrelevement.ResumeLayout(false);
            this.ajoutAutoPrelevement.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cLASSEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionAssociationSportiveDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label login;
        private System.Windows.Forms.Label motDePasse;
        private System.Windows.Forms.Label prenom;
        private System.Windows.Forms.Label nom;
        private System.Windows.Forms.Label dateDeNaissance;
        private System.Windows.Forms.Label sexe;
        private System.Windows.Forms.Label email;
        private System.Windows.Forms.Label numTelEleve;
        private System.Windows.Forms.Label numTelTuteur;
        private System.Windows.Forms.Label prelevementAutorise;
        private System.Windows.Forms.Button annuler;
        private System.Windows.Forms.Button ajouter;
        private System.Windows.Forms.TextBox ajoutLoginChamp;
        private System.Windows.Forms.TextBox ajoutMotDePasseChamp;
        private System.Windows.Forms.TextBox ajoutNomChamp;
        private System.Windows.Forms.TextBox ajoutPrenomChamp;
        private System.Windows.Forms.TextBox ajoutEmailChamp;
        private System.Windows.Forms.TextBox ajoutTelephoneChamp;
        private System.Windows.Forms.TextBox ajoutTelephoneTuteurChamp;
        private System.Windows.Forms.Label erreurChampsVides;
        private System.Windows.Forms.DateTimePicker ajoutDateDeNaissanceChamp;
        private System.Windows.Forms.RadioButton oui;
        private System.Windows.Forms.RadioButton non;
        private System.Windows.Forms.GroupBox ajoutAutoPrelevement;
        private System.Windows.Forms.Label classe;
        private System.Windows.Forms.ComboBox classeChamp;
        private System.Windows.Forms.Label success;
        private System.Windows.Forms.ComboBox ajoutSexeChamp;
        private System.Windows.Forms.Label existe;
        private GestionAssociationSportiveDataSet gestionAssociationSportiveDataSet1;
        private GestionAssociationSportiveDataSetTableAdapters.CLASSETableAdapter cLASSETableAdapter1;
        private GestionAssociationSportiveDataSet gestionAssociationSportiveDataSet;
        private System.Windows.Forms.BindingSource cLASSEBindingSource;
        private GestionAssociationSportiveDataSetTableAdapters.CLASSETableAdapter cLASSETableAdapter;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton nonSweat;
        private System.Windows.Forms.RadioButton ouiSweat;
        private System.Windows.Forms.Label label1;
    }
}