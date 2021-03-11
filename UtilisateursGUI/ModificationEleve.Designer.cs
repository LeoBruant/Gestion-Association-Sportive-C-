namespace UtilisateursGUI
{
    partial class ModificationEleve
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
            this.nom = new System.Windows.Forms.Label();
            this.prenom = new System.Windows.Forms.Label();
            this.dateDeNaissance = new System.Windows.Forms.Label();
            this.sexe = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.Label();
            this.numTelEleve = new System.Windows.Forms.Label();
            this.numTelTuteur = new System.Windows.Forms.Label();
            this.prelevementAutorise = new System.Windows.Forms.Label();
            this.classeChamp = new System.Windows.Forms.Label();
            this.modificationLoginChamp = new System.Windows.Forms.TextBox();
            this.modificationMotDePasseChamp = new System.Windows.Forms.TextBox();
            this.modificationNomChamp = new System.Windows.Forms.TextBox();
            this.modificationPrenomChamp = new System.Windows.Forms.TextBox();
            this.modificationDateDeNaissanceChamp = new System.Windows.Forms.DateTimePicker();
            this.modificationEmailChamp = new System.Windows.Forms.TextBox();
            this.modificationTelephoneChamp = new System.Windows.Forms.TextBox();
            this.modificationTelephoneTuteurChamp = new System.Windows.Forms.TextBox();
            this.modificationAutoPrelevement = new System.Windows.Forms.GroupBox();
            this.non = new System.Windows.Forms.RadioButton();
            this.oui = new System.Windows.Forms.RadioButton();
            this.modificationClasseChamp = new System.Windows.Forms.ComboBox();
            this.cLASSEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gestionAssociationSportiveDataSet = new UtilisateursGUI.GestionAssociationSportiveDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.modificationArchiveChamp = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.annuler = new System.Windows.Forms.Button();
            this.ajouter = new System.Windows.Forms.Button();
            this.fond1 = new System.Windows.Forms.RichTextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dt_id = new System.Windows.Forms.Label();
            this.dt_login = new System.Windows.Forms.Label();
            this.dt_nom = new System.Windows.Forms.Label();
            this.dt_prenom = new System.Windows.Forms.Label();
            this.dt_ddn = new System.Windows.Forms.Label();
            this.dt_sexe = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.dt_dern_modif = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dt_email = new System.Windows.Forms.Label();
            this.dt_tel = new System.Windows.Forms.Label();
            this.dt_tel_tuteur = new System.Windows.Forms.Label();
            this.dt_aut_prelev = new System.Windows.Forms.Label();
            this.dt_archive = new System.Windows.Forms.Label();
            this.dt_classe = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.Label();
            this.success = new System.Windows.Forms.Label();
            this.cLASSETableAdapter = new UtilisateursGUI.GestionAssociationSportiveDataSetTableAdapters.CLASSETableAdapter();
            this.modificationSexeChamp = new System.Windows.Forms.ComboBox();
            this.modificationAutoPrelevement.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cLASSEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionAssociationSportiveDataSet)).BeginInit();
            this.modificationArchiveChamp.SuspendLayout();
            this.SuspendLayout();
            // 
            // login
            // 
            this.login.AutoSize = true;
            this.login.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login.Location = new System.Drawing.Point(15, 11);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(61, 24);
            this.login.TabIndex = 1;
            this.login.Text = "Login :";
            // 
            // motDePasse
            // 
            this.motDePasse.AutoSize = true;
            this.motDePasse.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.motDePasse.Location = new System.Drawing.Point(15, 47);
            this.motDePasse.Name = "motDePasse";
            this.motDePasse.Size = new System.Drawing.Size(129, 24);
            this.motDePasse.TabIndex = 2;
            this.motDePasse.Text = "Mot de passe :";
            // 
            // nom
            // 
            this.nom.AutoSize = true;
            this.nom.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nom.Location = new System.Drawing.Point(15, 84);
            this.nom.Name = "nom";
            this.nom.Size = new System.Drawing.Size(59, 24);
            this.nom.TabIndex = 4;
            this.nom.Text = "Nom :";
            // 
            // prenom
            // 
            this.prenom.AutoSize = true;
            this.prenom.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prenom.Location = new System.Drawing.Point(15, 118);
            this.prenom.Name = "prenom";
            this.prenom.Size = new System.Drawing.Size(83, 24);
            this.prenom.TabIndex = 5;
            this.prenom.Text = "Prénom :";
            // 
            // dateDeNaissance
            // 
            this.dateDeNaissance.AutoSize = true;
            this.dateDeNaissance.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateDeNaissance.Location = new System.Drawing.Point(15, 153);
            this.dateDeNaissance.Name = "dateDeNaissance";
            this.dateDeNaissance.Size = new System.Drawing.Size(165, 24);
            this.dateDeNaissance.TabIndex = 6;
            this.dateDeNaissance.Text = "Date de naissance :";
            // 
            // sexe
            // 
            this.sexe.AutoSize = true;
            this.sexe.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sexe.Location = new System.Drawing.Point(15, 190);
            this.sexe.Name = "sexe";
            this.sexe.Size = new System.Drawing.Size(56, 24);
            this.sexe.TabIndex = 7;
            this.sexe.Text = "Sexe :";
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email.Location = new System.Drawing.Point(516, 11);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(63, 24);
            this.email.TabIndex = 8;
            this.email.Text = "Email :";
            // 
            // numTelEleve
            // 
            this.numTelEleve.AutoSize = true;
            this.numTelEleve.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numTelEleve.Location = new System.Drawing.Point(516, 47);
            this.numTelEleve.Name = "numTelEleve";
            this.numTelEleve.Size = new System.Drawing.Size(102, 24);
            this.numTelEleve.TabIndex = 9;
            this.numTelEleve.Text = "Téléphone :";
            // 
            // numTelTuteur
            // 
            this.numTelTuteur.AutoSize = true;
            this.numTelTuteur.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numTelTuteur.Location = new System.Drawing.Point(516, 84);
            this.numTelTuteur.Name = "numTelTuteur";
            this.numTelTuteur.Size = new System.Drawing.Size(158, 24);
            this.numTelTuteur.TabIndex = 10;
            this.numTelTuteur.Text = "Téléphone tuteur :";
            // 
            // prelevementAutorise
            // 
            this.prelevementAutorise.AutoSize = true;
            this.prelevementAutorise.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prelevementAutorise.Location = new System.Drawing.Point(516, 118);
            this.prelevementAutorise.Name = "prelevementAutorise";
            this.prelevementAutorise.Size = new System.Drawing.Size(214, 24);
            this.prelevementAutorise.TabIndex = 11;
            this.prelevementAutorise.Text = "Autorise le prélèvement :";
            // 
            // classeChamp
            // 
            this.classeChamp.AutoSize = true;
            this.classeChamp.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.classeChamp.Location = new System.Drawing.Point(516, 153);
            this.classeChamp.Name = "classeChamp";
            this.classeChamp.Size = new System.Drawing.Size(70, 24);
            this.classeChamp.TabIndex = 33;
            this.classeChamp.Text = "Classe :";
            // 
            // modificationLoginChamp
            // 
            this.modificationLoginChamp.Font = new System.Drawing.Font("Calibri Light", 10.2F);
            this.modificationLoginChamp.Location = new System.Drawing.Point(89, 10);
            this.modificationLoginChamp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.modificationLoginChamp.Name = "modificationLoginChamp";
            this.modificationLoginChamp.Size = new System.Drawing.Size(191, 28);
            this.modificationLoginChamp.TabIndex = 34;
            // 
            // modificationMotDePasseChamp
            // 
            this.modificationMotDePasseChamp.Font = new System.Drawing.Font("Calibri Light", 10.2F);
            this.modificationMotDePasseChamp.Location = new System.Drawing.Point(159, 46);
            this.modificationMotDePasseChamp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.modificationMotDePasseChamp.Name = "modificationMotDePasseChamp";
            this.modificationMotDePasseChamp.Size = new System.Drawing.Size(191, 28);
            this.modificationMotDePasseChamp.TabIndex = 35;
            // 
            // modificationNomChamp
            // 
            this.modificationNomChamp.Font = new System.Drawing.Font("Calibri Light", 10.2F);
            this.modificationNomChamp.Location = new System.Drawing.Point(84, 82);
            this.modificationNomChamp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.modificationNomChamp.Name = "modificationNomChamp";
            this.modificationNomChamp.Size = new System.Drawing.Size(191, 28);
            this.modificationNomChamp.TabIndex = 36;
            // 
            // modificationPrenomChamp
            // 
            this.modificationPrenomChamp.Font = new System.Drawing.Font("Calibri Light", 10.2F);
            this.modificationPrenomChamp.Location = new System.Drawing.Point(111, 117);
            this.modificationPrenomChamp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.modificationPrenomChamp.Name = "modificationPrenomChamp";
            this.modificationPrenomChamp.Size = new System.Drawing.Size(191, 28);
            this.modificationPrenomChamp.TabIndex = 37;
            // 
            // modificationDateDeNaissanceChamp
            // 
            this.modificationDateDeNaissanceChamp.Font = new System.Drawing.Font("Calibri Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modificationDateDeNaissanceChamp.Location = new System.Drawing.Point(200, 153);
            this.modificationDateDeNaissanceChamp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.modificationDateDeNaissanceChamp.Name = "modificationDateDeNaissanceChamp";
            this.modificationDateDeNaissanceChamp.Size = new System.Drawing.Size(261, 28);
            this.modificationDateDeNaissanceChamp.TabIndex = 38;
            this.modificationDateDeNaissanceChamp.Value = new System.DateTime(2020, 12, 11, 0, 0, 0, 0);
            // 
            // modificationEmailChamp
            // 
            this.modificationEmailChamp.Font = new System.Drawing.Font("Calibri Light", 10.2F);
            this.modificationEmailChamp.Location = new System.Drawing.Point(593, 10);
            this.modificationEmailChamp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.modificationEmailChamp.Name = "modificationEmailChamp";
            this.modificationEmailChamp.Size = new System.Drawing.Size(191, 28);
            this.modificationEmailChamp.TabIndex = 40;
            // 
            // modificationTelephoneChamp
            // 
            this.modificationTelephoneChamp.Font = new System.Drawing.Font("Calibri Light", 10.2F);
            this.modificationTelephoneChamp.Location = new System.Drawing.Point(633, 46);
            this.modificationTelephoneChamp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.modificationTelephoneChamp.Name = "modificationTelephoneChamp";
            this.modificationTelephoneChamp.Size = new System.Drawing.Size(191, 28);
            this.modificationTelephoneChamp.TabIndex = 41;
            // 
            // modificationTelephoneTuteurChamp
            // 
            this.modificationTelephoneTuteurChamp.Font = new System.Drawing.Font("Calibri Light", 10.2F);
            this.modificationTelephoneTuteurChamp.Location = new System.Drawing.Point(684, 82);
            this.modificationTelephoneTuteurChamp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.modificationTelephoneTuteurChamp.Name = "modificationTelephoneTuteurChamp";
            this.modificationTelephoneTuteurChamp.Size = new System.Drawing.Size(191, 28);
            this.modificationTelephoneTuteurChamp.TabIndex = 42;
            // 
            // modificationAutoPrelevement
            // 
            this.modificationAutoPrelevement.Controls.Add(this.non);
            this.modificationAutoPrelevement.Controls.Add(this.oui);
            this.modificationAutoPrelevement.Location = new System.Drawing.Point(753, 118);
            this.modificationAutoPrelevement.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.modificationAutoPrelevement.Name = "modificationAutoPrelevement";
            this.modificationAutoPrelevement.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.modificationAutoPrelevement.Size = new System.Drawing.Size(135, 26);
            this.modificationAutoPrelevement.TabIndex = 43;
            this.modificationAutoPrelevement.TabStop = false;
            // 
            // non
            // 
            this.non.AutoSize = true;
            this.non.Font = new System.Drawing.Font("Calibri Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.non.Location = new System.Drawing.Point(67, 0);
            this.non.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.non.Name = "non";
            this.non.Size = new System.Drawing.Size(58, 25);
            this.non.TabIndex = 31;
            this.non.TabStop = true;
            this.non.Text = "non";
            this.non.UseVisualStyleBackColor = true;
            this.non.CheckedChanged += new System.EventHandler(this.non_prelev_CheckedChanged);
            // 
            // oui
            // 
            this.oui.AutoSize = true;
            this.oui.Font = new System.Drawing.Font("Calibri Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oui.Location = new System.Drawing.Point(7, 0);
            this.oui.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.oui.Name = "oui";
            this.oui.Size = new System.Drawing.Size(53, 25);
            this.oui.TabIndex = 0;
            this.oui.TabStop = true;
            this.oui.Text = "oui";
            this.oui.UseVisualStyleBackColor = true;
            this.oui.CheckedChanged += new System.EventHandler(this.oui_prelev_CheckedChanged);
            // 
            // modificationClasseChamp
            // 
            this.modificationClasseChamp.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.cLASSEBindingSource, "Libelle_classe", true));
            this.modificationClasseChamp.DataSource = this.cLASSEBindingSource;
            this.modificationClasseChamp.DisplayMember = "Libelle_classe";
            this.modificationClasseChamp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.modificationClasseChamp.Font = new System.Drawing.Font("Calibri Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modificationClasseChamp.FormattingEnabled = true;
            this.modificationClasseChamp.Location = new System.Drawing.Point(599, 151);
            this.modificationClasseChamp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.modificationClasseChamp.Name = "modificationClasseChamp";
            this.modificationClasseChamp.Size = new System.Drawing.Size(184, 29);
            this.modificationClasseChamp.TabIndex = 44;
            this.modificationClasseChamp.ValueMember = "Libelle_classe";
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(516, 190);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 24);
            this.label1.TabIndex = 46;
            this.label1.Text = "Est archivé :";
            // 
            // modificationArchiveChamp
            // 
            this.modificationArchiveChamp.Controls.Add(this.radioButton1);
            this.modificationArchiveChamp.Controls.Add(this.radioButton2);
            this.modificationArchiveChamp.Location = new System.Drawing.Point(639, 190);
            this.modificationArchiveChamp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.modificationArchiveChamp.Name = "modificationArchiveChamp";
            this.modificationArchiveChamp.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.modificationArchiveChamp.Size = new System.Drawing.Size(135, 26);
            this.modificationArchiveChamp.TabIndex = 44;
            this.modificationArchiveChamp.TabStop = false;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Calibri Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.Location = new System.Drawing.Point(67, 0);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(58, 25);
            this.radioButton1.TabIndex = 31;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "non";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.non_archive_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Calibri Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.Location = new System.Drawing.Point(7, 0);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(53, 25);
            this.radioButton2.TabIndex = 0;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "oui";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.oui_archive_CheckedChanged);
            // 
            // annuler
            // 
            this.annuler.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.annuler.Location = new System.Drawing.Point(969, 27);
            this.annuler.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.annuler.Name = "annuler";
            this.annuler.Size = new System.Drawing.Size(171, 63);
            this.annuler.TabIndex = 32;
            this.annuler.Text = "Retour";
            this.annuler.UseVisualStyleBackColor = true;
            this.annuler.Click += new System.EventHandler(this.annuler_Click);
            // 
            // ajouter
            // 
            this.ajouter.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ajouter.Location = new System.Drawing.Point(969, 114);
            this.ajouter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ajouter.Name = "ajouter";
            this.ajouter.Size = new System.Drawing.Size(171, 63);
            this.ajouter.TabIndex = 47;
            this.ajouter.Text = "Modifier";
            this.ajouter.UseVisualStyleBackColor = true;
            this.ajouter.Click += new System.EventHandler(this.modifier_Click);
            // 
            // fond1
            // 
            this.fond1.BackColor = System.Drawing.SystemColors.Window;
            this.fond1.Location = new System.Drawing.Point(16, 260);
            this.fond1.Margin = new System.Windows.Forms.Padding(4);
            this.fond1.Name = "fond1";
            this.fond1.ReadOnly = true;
            this.fond1.Size = new System.Drawing.Size(545, 190);
            this.fond1.TabIndex = 48;
            this.fond1.Text = "";
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.Window;
            this.richTextBox1.Location = new System.Drawing.Point(571, 260);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(567, 190);
            this.richTextBox1.TabIndex = 49;
            this.richTextBox1.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(29, 274);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 17);
            this.label2.TabIndex = 50;
            this.label2.Text = "Id :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(29, 304);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 17);
            this.label3.TabIndex = 51;
            this.label3.Text = "Login :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Location = new System.Drawing.Point(29, 335);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 17);
            this.label9.TabIndex = 52;
            this.label9.Text = "Nom :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(29, 366);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 17);
            this.label4.TabIndex = 53;
            this.label4.Text = "Prenom :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(29, 395);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 17);
            this.label5.TabIndex = 54;
            this.label5.Text = "Date de naissance :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(29, 428);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 17);
            this.label6.TabIndex = 55;
            this.label6.Text = "Sexe :";
            // 
            // dt_id
            // 
            this.dt_id.AutoSize = true;
            this.dt_id.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.dt_id.Location = new System.Drawing.Point(261, 274);
            this.dt_id.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dt_id.Name = "dt_id";
            this.dt_id.Size = new System.Drawing.Size(19, 17);
            this.dt_id.TabIndex = 56;
            this.dt_id.Text = "id";
            // 
            // dt_login
            // 
            this.dt_login.AutoSize = true;
            this.dt_login.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.dt_login.Location = new System.Drawing.Point(261, 304);
            this.dt_login.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dt_login.Name = "dt_login";
            this.dt_login.Size = new System.Drawing.Size(38, 17);
            this.dt_login.TabIndex = 57;
            this.dt_login.Text = "login";
            // 
            // dt_nom
            // 
            this.dt_nom.AutoSize = true;
            this.dt_nom.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.dt_nom.Location = new System.Drawing.Point(261, 335);
            this.dt_nom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dt_nom.Name = "dt_nom";
            this.dt_nom.Size = new System.Drawing.Size(35, 17);
            this.dt_nom.TabIndex = 58;
            this.dt_nom.Text = "nom";
            // 
            // dt_prenom
            // 
            this.dt_prenom.AutoSize = true;
            this.dt_prenom.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.dt_prenom.Location = new System.Drawing.Point(261, 366);
            this.dt_prenom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dt_prenom.Name = "dt_prenom";
            this.dt_prenom.Size = new System.Drawing.Size(56, 17);
            this.dt_prenom.TabIndex = 59;
            this.dt_prenom.Text = "prenom";
            // 
            // dt_ddn
            // 
            this.dt_ddn.AutoSize = true;
            this.dt_ddn.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.dt_ddn.Location = new System.Drawing.Point(261, 395);
            this.dt_ddn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dt_ddn.Name = "dt_ddn";
            this.dt_ddn.Size = new System.Drawing.Size(32, 17);
            this.dt_ddn.TabIndex = 60;
            this.dt_ddn.Text = "ddn";
            // 
            // dt_sexe
            // 
            this.dt_sexe.AutoSize = true;
            this.dt_sexe.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.dt_sexe.Location = new System.Drawing.Point(261, 428);
            this.dt_sexe.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dt_sexe.Name = "dt_sexe";
            this.dt_sexe.Size = new System.Drawing.Size(37, 17);
            this.dt_sexe.TabIndex = 61;
            this.dt_sexe.Text = "sexe";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label10.Location = new System.Drawing.Point(595, 274);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 17);
            this.label10.TabIndex = 62;
            this.label10.Text = "Email :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label11.Location = new System.Drawing.Point(595, 304);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(84, 17);
            this.label11.TabIndex = 63;
            this.label11.Text = "Telephone :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label12.Location = new System.Drawing.Point(595, 335);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(125, 17);
            this.label12.TabIndex = 64;
            this.label12.Text = "Telephone tuteur :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label13.Location = new System.Drawing.Point(979, 335);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(107, 17);
            this.label13.TabIndex = 65;
            this.label13.Text = "derniere modif :";
            // 
            // dt_dern_modif
            // 
            this.dt_dern_modif.AutoSize = true;
            this.dt_dern_modif.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.dt_dern_modif.Location = new System.Drawing.Point(979, 352);
            this.dt_dern_modif.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dt_dern_modif.Name = "dt_dern_modif";
            this.dt_dern_modif.Size = new System.Drawing.Size(99, 17);
            this.dt_dern_modif.TabIndex = 66;
            this.dt_dern_modif.Text = "derniere modif";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label14.Location = new System.Drawing.Point(595, 428);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(86, 17);
            this.label14.TabIndex = 67;
            this.label14.Text = "Est archivé :";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label15.Location = new System.Drawing.Point(595, 366);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(173, 17);
            this.label15.TabIndex = 68;
            this.label15.Text = "Autorisation prélèvement :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(595, 395);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 17);
            this.label7.TabIndex = 69;
            this.label7.Text = "Classe :";
            // 
            // dt_email
            // 
            this.dt_email.AutoSize = true;
            this.dt_email.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.dt_email.Location = new System.Drawing.Point(841, 274);
            this.dt_email.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dt_email.Name = "dt_email";
            this.dt_email.Size = new System.Drawing.Size(41, 17);
            this.dt_email.TabIndex = 70;
            this.dt_email.Text = "email";
            // 
            // dt_tel
            // 
            this.dt_tel.AutoSize = true;
            this.dt_tel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.dt_tel.Location = new System.Drawing.Point(841, 304);
            this.dt_tel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dt_tel.Name = "dt_tel";
            this.dt_tel.Size = new System.Drawing.Size(71, 17);
            this.dt_tel.TabIndex = 71;
            this.dt_tel.Text = "telephone\r\n";
            // 
            // dt_tel_tuteur
            // 
            this.dt_tel_tuteur.AutoSize = true;
            this.dt_tel_tuteur.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.dt_tel_tuteur.Location = new System.Drawing.Point(841, 335);
            this.dt_tel_tuteur.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dt_tel_tuteur.Name = "dt_tel_tuteur";
            this.dt_tel_tuteur.Size = new System.Drawing.Size(116, 17);
            this.dt_tel_tuteur.TabIndex = 72;
            this.dt_tel_tuteur.Text = "telephone tuteur ";
            // 
            // dt_aut_prelev
            // 
            this.dt_aut_prelev.AutoSize = true;
            this.dt_aut_prelev.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.dt_aut_prelev.Location = new System.Drawing.Point(841, 366);
            this.dt_aut_prelev.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dt_aut_prelev.Name = "dt_aut_prelev";
            this.dt_aut_prelev.Size = new System.Drawing.Size(164, 17);
            this.dt_aut_prelev.TabIndex = 73;
            this.dt_aut_prelev.Text = "autorisation prélèvement\r\n";
            // 
            // dt_archive
            // 
            this.dt_archive.AutoSize = true;
            this.dt_archive.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.dt_archive.Location = new System.Drawing.Point(841, 428);
            this.dt_archive.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dt_archive.Name = "dt_archive";
            this.dt_archive.Size = new System.Drawing.Size(77, 17);
            this.dt_archive.TabIndex = 74;
            this.dt_archive.Text = "est archivé";
            // 
            // dt_classe
            // 
            this.dt_classe.AutoSize = true;
            this.dt_classe.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.dt_classe.Location = new System.Drawing.Point(841, 395);
            this.dt_classe.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dt_classe.Name = "dt_classe";
            this.dt_classe.Size = new System.Drawing.Size(48, 17);
            this.dt_classe.TabIndex = 75;
            this.dt_classe.Text = "classe";
            // 
            // id
            // 
            this.id.AutoSize = true;
            this.id.Location = new System.Drawing.Point(400, 56);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(46, 17);
            this.id.TabIndex = 76;
            this.id.Text = "label8";
            this.id.Visible = false;
            // 
            // success
            // 
            this.success.AutoSize = true;
            this.success.Location = new System.Drawing.Point(374, 227);
            this.success.Name = "success";
            this.success.Size = new System.Drawing.Size(279, 17);
            this.success.TabIndex = 78;
            this.success.Text = "Les modifications ont bien été enregistrées";
            this.success.Visible = false;
            // 
            // cLASSETableAdapter
            // 
            this.cLASSETableAdapter.ClearBeforeFill = true;
            // 
            // modificationSexeChamp
            // 
            this.modificationSexeChamp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.modificationSexeChamp.FormattingEnabled = true;
            this.modificationSexeChamp.Items.AddRange(new object[] {
            "Homme",
            "Femme",
            "Autre"});
            this.modificationSexeChamp.Location = new System.Drawing.Point(89, 191);
            this.modificationSexeChamp.Name = "modificationSexeChamp";
            this.modificationSexeChamp.Size = new System.Drawing.Size(121, 24);
            this.modificationSexeChamp.TabIndex = 79;
            // 
            // ModificationEleve
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1155, 455);
            this.Controls.Add(this.modificationSexeChamp);
            this.Controls.Add(this.success);
            this.Controls.Add(this.id);
            this.Controls.Add(this.dt_classe);
            this.Controls.Add(this.dt_archive);
            this.Controls.Add(this.dt_aut_prelev);
            this.Controls.Add(this.dt_tel_tuteur);
            this.Controls.Add(this.dt_tel);
            this.Controls.Add(this.dt_email);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.dt_dern_modif);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dt_sexe);
            this.Controls.Add(this.dt_ddn);
            this.Controls.Add(this.dt_prenom);
            this.Controls.Add(this.dt_nom);
            this.Controls.Add(this.dt_login);
            this.Controls.Add(this.dt_id);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.fond1);
            this.Controls.Add(this.ajouter);
            this.Controls.Add(this.annuler);
            this.Controls.Add(this.modificationArchiveChamp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.modificationClasseChamp);
            this.Controls.Add(this.modificationAutoPrelevement);
            this.Controls.Add(this.modificationTelephoneTuteurChamp);
            this.Controls.Add(this.modificationTelephoneChamp);
            this.Controls.Add(this.modificationEmailChamp);
            this.Controls.Add(this.modificationDateDeNaissanceChamp);
            this.Controls.Add(this.modificationPrenomChamp);
            this.Controls.Add(this.modificationNomChamp);
            this.Controls.Add(this.modificationMotDePasseChamp);
            this.Controls.Add(this.modificationLoginChamp);
            this.Controls.Add(this.classeChamp);
            this.Controls.Add(this.prelevementAutorise);
            this.Controls.Add(this.numTelTuteur);
            this.Controls.Add(this.numTelEleve);
            this.Controls.Add(this.email);
            this.Controls.Add(this.sexe);
            this.Controls.Add(this.dateDeNaissance);
            this.Controls.Add(this.prenom);
            this.Controls.Add(this.nom);
            this.Controls.Add(this.motDePasse);
            this.Controls.Add(this.login);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "ModificationEleve";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modification Eleve";
            this.Load += new System.EventHandler(this.ModificationEleve_Load);
            this.modificationAutoPrelevement.ResumeLayout(false);
            this.modificationAutoPrelevement.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cLASSEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionAssociationSportiveDataSet)).EndInit();
            this.modificationArchiveChamp.ResumeLayout(false);
            this.modificationArchiveChamp.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label login;
        private System.Windows.Forms.Label motDePasse;
        private System.Windows.Forms.Label nom;
        private System.Windows.Forms.Label prenom;
        private System.Windows.Forms.Label dateDeNaissance;
        private System.Windows.Forms.Label sexe;
        private System.Windows.Forms.Label email;
        private System.Windows.Forms.Label numTelEleve;
        private System.Windows.Forms.Label numTelTuteur;
        private System.Windows.Forms.Label prelevementAutorise;
        private System.Windows.Forms.Label classeChamp;
        private System.Windows.Forms.TextBox modificationLoginChamp;
        private System.Windows.Forms.TextBox modificationMotDePasseChamp;
        private System.Windows.Forms.TextBox modificationNomChamp;
        private System.Windows.Forms.TextBox modificationPrenomChamp;
        private System.Windows.Forms.DateTimePicker modificationDateDeNaissanceChamp;
        private System.Windows.Forms.TextBox modificationEmailChamp;
        private System.Windows.Forms.TextBox modificationTelephoneChamp;
        private System.Windows.Forms.TextBox modificationTelephoneTuteurChamp;
        private System.Windows.Forms.GroupBox modificationAutoPrelevement;
        private System.Windows.Forms.RadioButton non;
        private System.Windows.Forms.RadioButton oui;
        private System.Windows.Forms.ComboBox modificationClasseChamp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox modificationArchiveChamp;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Button annuler;
        private System.Windows.Forms.Button ajouter;
        private System.Windows.Forms.RichTextBox fond1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label dt_id;
        private System.Windows.Forms.Label dt_login;
        private System.Windows.Forms.Label dt_nom;
        private System.Windows.Forms.Label dt_prenom;
        private System.Windows.Forms.Label dt_ddn;
        private System.Windows.Forms.Label dt_sexe;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label dt_dern_modif;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label dt_email;
        private System.Windows.Forms.Label dt_tel;
        private System.Windows.Forms.Label dt_tel_tuteur;
        private System.Windows.Forms.Label dt_aut_prelev;
        private System.Windows.Forms.Label dt_archive;
        private System.Windows.Forms.Label dt_classe;
        public System.Windows.Forms.Label id;
        private System.Windows.Forms.Label success;
        private GestionAssociationSportiveDataSet gestionAssociationSportiveDataSet;
        private System.Windows.Forms.BindingSource cLASSEBindingSource;
        private GestionAssociationSportiveDataSetTableAdapters.CLASSETableAdapter cLASSETableAdapter;
        private System.Windows.Forms.ComboBox modificationSexeChamp;
    }
}