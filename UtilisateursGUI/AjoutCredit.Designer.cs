namespace UtilisateursGUI
{
    partial class AjoutCredit
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
            this.ajoutBudgetChamp = new System.Windows.Forms.ComboBox();
            this.bUDGETBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gestionAssociationSportiveDataSet = new UtilisateursGUI.GestionAssociationSportiveDataSet();
            this.ajoutIdEvenementChamp = new System.Windows.Forms.ComboBox();
            this.eVENEMENTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ajoutIdAdherentChamp = new System.Windows.Forms.ComboBox();
            this.aDHERENTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ajoutPrelevementEfectueChamp = new System.Windows.Forms.GroupBox();
            this.non = new System.Windows.Forms.RadioButton();
            this.oui = new System.Windows.Forms.RadioButton();
            this.ajoutDateCreditChamp = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.success = new System.Windows.Forms.Label();
            this.erreurChampsVides = new System.Windows.Forms.Label();
            this.ajouter = new System.Windows.Forms.Button();
            this.annuler = new System.Windows.Forms.Button();
            this.ajoutMontantCreditChamp = new System.Windows.Forms.TextBox();
            this.ajoutNomCreditChamp = new System.Windows.Forms.TextBox();
            this.idBudget = new System.Windows.Forms.Label();
            this.idEvenement = new System.Windows.Forms.Label();
            this.idAdherent = new System.Windows.Forms.Label();
            this.prelevementEffectue = new System.Windows.Forms.Label();
            this.montantCredit = new System.Windows.Forms.Label();
            this.dateCredit = new System.Windows.Forms.Label();
            this.libelleCredit = new System.Windows.Forms.Label();
            this.aDHERENTTableAdapter = new UtilisateursGUI.GestionAssociationSportiveDataSetTableAdapters.ADHERENTTableAdapter();
            this.eVENEMENTTableAdapter = new UtilisateursGUI.GestionAssociationSportiveDataSetTableAdapters.EVENEMENTTableAdapter();
            this.bUDGETTableAdapter = new UtilisateursGUI.GestionAssociationSportiveDataSetTableAdapters.BUDGETTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.bUDGETBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionAssociationSportiveDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eVENEMENTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aDHERENTBindingSource)).BeginInit();
            this.ajoutPrelevementEfectueChamp.SuspendLayout();
            this.SuspendLayout();
            // 
            // ajoutBudgetChamp
            // 
            this.ajoutBudgetChamp.DataSource = this.bUDGETBindingSource;
            this.ajoutBudgetChamp.DisplayMember = "Libelle_budget";
            this.ajoutBudgetChamp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ajoutBudgetChamp.Font = new System.Drawing.Font("Calibri Light", 12F);
            this.ajoutBudgetChamp.FormattingEnabled = true;
            this.ajoutBudgetChamp.Location = new System.Drawing.Point(197, 393);
            this.ajoutBudgetChamp.Name = "ajoutBudgetChamp";
            this.ajoutBudgetChamp.Size = new System.Drawing.Size(173, 32);
            this.ajoutBudgetChamp.TabIndex = 65;
            this.ajoutBudgetChamp.ValueMember = "Id_budget";
            // 
            // bUDGETBindingSource
            // 
            this.bUDGETBindingSource.DataMember = "BUDGET";
            this.bUDGETBindingSource.DataSource = this.gestionAssociationSportiveDataSet;
            // 
            // gestionAssociationSportiveDataSet
            // 
            this.gestionAssociationSportiveDataSet.DataSetName = "GestionAssociationSportiveDataSet";
            this.gestionAssociationSportiveDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ajoutIdEvenementChamp
            // 
            this.ajoutIdEvenementChamp.DataSource = this.eVENEMENTBindingSource;
            this.ajoutIdEvenementChamp.DisplayMember = "Libelle_evenement";
            this.ajoutIdEvenementChamp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ajoutIdEvenementChamp.Font = new System.Drawing.Font("Calibri Light", 12F);
            this.ajoutIdEvenementChamp.FormattingEnabled = true;
            this.ajoutIdEvenementChamp.Location = new System.Drawing.Point(232, 346);
            this.ajoutIdEvenementChamp.Name = "ajoutIdEvenementChamp";
            this.ajoutIdEvenementChamp.Size = new System.Drawing.Size(173, 32);
            this.ajoutIdEvenementChamp.TabIndex = 64;
            this.ajoutIdEvenementChamp.ValueMember = "Id_evenement";
            // 
            // eVENEMENTBindingSource
            // 
            this.eVENEMENTBindingSource.DataMember = "EVENEMENT";
            this.eVENEMENTBindingSource.DataSource = this.gestionAssociationSportiveDataSet;
            // 
            // ajoutIdAdherentChamp
            // 
            this.ajoutIdAdherentChamp.DataSource = this.aDHERENTBindingSource;
            this.ajoutIdAdherentChamp.DisplayMember = "Nom_adherent";
            this.ajoutIdAdherentChamp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ajoutIdAdherentChamp.Font = new System.Drawing.Font("Calibri Light", 12F);
            this.ajoutIdAdherentChamp.FormattingEnabled = true;
            this.ajoutIdAdherentChamp.Location = new System.Drawing.Point(215, 292);
            this.ajoutIdAdherentChamp.Name = "ajoutIdAdherentChamp";
            this.ajoutIdAdherentChamp.Size = new System.Drawing.Size(173, 32);
            this.ajoutIdAdherentChamp.TabIndex = 63;
            this.ajoutIdAdherentChamp.ValueMember = "Id_adherent";
            // 
            // aDHERENTBindingSource
            // 
            this.aDHERENTBindingSource.DataMember = "ADHERENT";
            this.aDHERENTBindingSource.DataSource = this.gestionAssociationSportiveDataSet;
            // 
            // ajoutPrelevementEfectueChamp
            // 
            this.ajoutPrelevementEfectueChamp.Controls.Add(this.non);
            this.ajoutPrelevementEfectueChamp.Controls.Add(this.oui);
            this.ajoutPrelevementEfectueChamp.Location = new System.Drawing.Point(273, 243);
            this.ajoutPrelevementEfectueChamp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ajoutPrelevementEfectueChamp.Name = "ajoutPrelevementEfectueChamp";
            this.ajoutPrelevementEfectueChamp.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ajoutPrelevementEfectueChamp.Size = new System.Drawing.Size(135, 26);
            this.ajoutPrelevementEfectueChamp.TabIndex = 62;
            this.ajoutPrelevementEfectueChamp.TabStop = false;
            // 
            // non
            // 
            this.non.AutoSize = true;
            this.non.Font = new System.Drawing.Font("Calibri Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.non.Location = new System.Drawing.Point(67, 2);
            this.non.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.non.Name = "non";
            this.non.Size = new System.Drawing.Size(58, 25);
            this.non.TabIndex = 31;
            this.non.TabStop = true;
            this.non.Text = "non";
            this.non.UseVisualStyleBackColor = true;
            this.non.CheckedChanged += new System.EventHandler(this.non_CheckedChanged_1);
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
            this.oui.CheckedChanged += new System.EventHandler(this.oui_CheckedChanged_1);
            // 
            // ajoutDateCreditChamp
            // 
            this.ajoutDateCreditChamp.Font = new System.Drawing.Font("Calibri Light", 12F);
            this.ajoutDateCreditChamp.Location = new System.Drawing.Point(169, 135);
            this.ajoutDateCreditChamp.Name = "ajoutDateCreditChamp";
            this.ajoutDateCreditChamp.Size = new System.Drawing.Size(288, 32);
            this.ajoutDateCreditChamp.TabIndex = 61;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri Light", 22F);
            this.label1.Location = new System.Drawing.Point(30, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(292, 45);
            this.label1.TabIndex = 60;
            this.label1.Text = "Ajouter un Crédit :";
            // 
            // success
            // 
            this.success.AutoSize = true;
            this.success.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.success.Location = new System.Drawing.Point(535, 256);
            this.success.Name = "success";
            this.success.Size = new System.Drawing.Size(221, 24);
            this.success.TabIndex = 59;
            this.success.Text = "Le crédit a bien été ajouté";
            this.success.Visible = false;
            // 
            // erreurChampsVides
            // 
            this.erreurChampsVides.AutoSize = true;
            this.erreurChampsVides.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.erreurChampsVides.ForeColor = System.Drawing.Color.Red;
            this.erreurChampsVides.Location = new System.Drawing.Point(504, 220);
            this.erreurChampsVides.Name = "erreurChampsVides";
            this.erreurChampsVides.Size = new System.Drawing.Size(267, 24);
            this.erreurChampsVides.TabIndex = 58;
            this.erreurChampsVides.Text = "Veuillez remplir tous les champs";
            this.erreurChampsVides.Visible = false;
            // 
            // ajouter
            // 
            this.ajouter.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ajouter.Location = new System.Drawing.Point(582, 132);
            this.ajouter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ajouter.Name = "ajouter";
            this.ajouter.Size = new System.Drawing.Size(171, 63);
            this.ajouter.TabIndex = 57;
            this.ajouter.Text = "Ajouter";
            this.ajouter.UseVisualStyleBackColor = true;
            this.ajouter.Click += new System.EventHandler(this.ajouter_Click);
            // 
            // annuler
            // 
            this.annuler.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.annuler.Location = new System.Drawing.Point(582, 37);
            this.annuler.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.annuler.Name = "annuler";
            this.annuler.Size = new System.Drawing.Size(171, 63);
            this.annuler.TabIndex = 56;
            this.annuler.Text = "Retour";
            this.annuler.UseVisualStyleBackColor = true;
            this.annuler.Click += new System.EventHandler(this.annuler_Click);
            // 
            // ajoutMontantCreditChamp
            // 
            this.ajoutMontantCreditChamp.Font = new System.Drawing.Font("Calibri Light", 12F);
            this.ajoutMontantCreditChamp.Location = new System.Drawing.Point(201, 187);
            this.ajoutMontantCreditChamp.Name = "ajoutMontantCreditChamp";
            this.ajoutMontantCreditChamp.Size = new System.Drawing.Size(174, 32);
            this.ajoutMontantCreditChamp.TabIndex = 55;
            // 
            // ajoutNomCreditChamp
            // 
            this.ajoutNomCreditChamp.Font = new System.Drawing.Font("Calibri Light", 12F);
            this.ajoutNomCreditChamp.Location = new System.Drawing.Point(170, 89);
            this.ajoutNomCreditChamp.Name = "ajoutNomCreditChamp";
            this.ajoutNomCreditChamp.Size = new System.Drawing.Size(179, 32);
            this.ajoutNomCreditChamp.TabIndex = 54;
            // 
            // idBudget
            // 
            this.idBudget.AutoSize = true;
            this.idBudget.Font = new System.Drawing.Font("Calibri Light", 12F);
            this.idBudget.Location = new System.Drawing.Point(34, 396);
            this.idBudget.Name = "idBudget";
            this.idBudget.Size = new System.Drawing.Size(157, 24);
            this.idBudget.TabIndex = 53;
            this.idBudget.Text = "Budget concerné :";
            // 
            // idEvenement
            // 
            this.idEvenement.AutoSize = true;
            this.idEvenement.Font = new System.Drawing.Font("Calibri Light", 12F);
            this.idEvenement.Location = new System.Drawing.Point(34, 349);
            this.idEvenement.Name = "idEvenement";
            this.idEvenement.Size = new System.Drawing.Size(192, 24);
            this.idEvenement.TabIndex = 52;
            this.idEvenement.Text = "Evenement concerné :";
            // 
            // idAdherent
            // 
            this.idAdherent.AutoSize = true;
            this.idAdherent.Font = new System.Drawing.Font("Calibri Light", 12F);
            this.idAdherent.Location = new System.Drawing.Point(34, 295);
            this.idAdherent.Name = "idAdherent";
            this.idAdherent.Size = new System.Drawing.Size(175, 24);
            this.idAdherent.TabIndex = 51;
            this.idAdherent.Text = "Adhérent concerné :";
            // 
            // prelevementEffectue
            // 
            this.prelevementEffectue.AutoSize = true;
            this.prelevementEffectue.Font = new System.Drawing.Font("Calibri Light", 12F);
            this.prelevementEffectue.Location = new System.Drawing.Point(34, 243);
            this.prelevementEffectue.Name = "prelevementEffectue";
            this.prelevementEffectue.Size = new System.Drawing.Size(233, 24);
            this.prelevementEffectue.TabIndex = 50;
            this.prelevementEffectue.Text = "Prélèvement déja effectué :";
            // 
            // montantCredit
            // 
            this.montantCredit.AutoSize = true;
            this.montantCredit.Font = new System.Drawing.Font("Calibri Light", 12F);
            this.montantCredit.Location = new System.Drawing.Point(34, 190);
            this.montantCredit.Name = "montantCredit";
            this.montantCredit.Size = new System.Drawing.Size(167, 24);
            this.montantCredit.TabIndex = 49;
            this.montantCredit.Text = "Montant du crédit :";
            // 
            // dateCredit
            // 
            this.dateCredit.AutoSize = true;
            this.dateCredit.Font = new System.Drawing.Font("Calibri Light", 12F);
            this.dateCredit.Location = new System.Drawing.Point(34, 141);
            this.dateCredit.Name = "dateCredit";
            this.dateCredit.Size = new System.Drawing.Size(135, 24);
            this.dateCredit.TabIndex = 48;
            this.dateCredit.Text = "Date du crédit :";
            // 
            // libelleCredit
            // 
            this.libelleCredit.AutoSize = true;
            this.libelleCredit.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.libelleCredit.Location = new System.Drawing.Point(34, 92);
            this.libelleCredit.Name = "libelleCredit";
            this.libelleCredit.Size = new System.Drawing.Size(136, 24);
            this.libelleCredit.TabIndex = 47;
            this.libelleCredit.Text = "Nom du crédit :";
            // 
            // aDHERENTTableAdapter
            // 
            this.aDHERENTTableAdapter.ClearBeforeFill = true;
            // 
            // eVENEMENTTableAdapter
            // 
            this.eVENEMENTTableAdapter.ClearBeforeFill = true;
            // 
            // bUDGETTableAdapter
            // 
            this.bUDGETTableAdapter.ClearBeforeFill = true;
            // 
            // AjoutCredit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ajoutBudgetChamp);
            this.Controls.Add(this.ajoutIdEvenementChamp);
            this.Controls.Add(this.ajoutIdAdherentChamp);
            this.Controls.Add(this.ajoutPrelevementEfectueChamp);
            this.Controls.Add(this.ajoutDateCreditChamp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.success);
            this.Controls.Add(this.erreurChampsVides);
            this.Controls.Add(this.ajouter);
            this.Controls.Add(this.annuler);
            this.Controls.Add(this.ajoutMontantCreditChamp);
            this.Controls.Add(this.ajoutNomCreditChamp);
            this.Controls.Add(this.idBudget);
            this.Controls.Add(this.idEvenement);
            this.Controls.Add(this.idAdherent);
            this.Controls.Add(this.prelevementEffectue);
            this.Controls.Add(this.montantCredit);
            this.Controls.Add(this.dateCredit);
            this.Controls.Add(this.libelleCredit);
            this.Name = "AjoutCredit";
            this.Text = "AjoutCredit";
            this.Load += new System.EventHandler(this.AjoutCredit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bUDGETBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionAssociationSportiveDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eVENEMENTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aDHERENTBindingSource)).EndInit();
            this.ajoutPrelevementEfectueChamp.ResumeLayout(false);
            this.ajoutPrelevementEfectueChamp.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ajoutBudgetChamp;
        private System.Windows.Forms.ComboBox ajoutIdEvenementChamp;
        private System.Windows.Forms.ComboBox ajoutIdAdherentChamp;
        private System.Windows.Forms.GroupBox ajoutPrelevementEfectueChamp;
        private System.Windows.Forms.RadioButton non;
        private System.Windows.Forms.RadioButton oui;
        private System.Windows.Forms.DateTimePicker ajoutDateCreditChamp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label success;
        private System.Windows.Forms.Label erreurChampsVides;
        private System.Windows.Forms.Button ajouter;
        private System.Windows.Forms.Button annuler;
        private System.Windows.Forms.TextBox ajoutMontantCreditChamp;
        private System.Windows.Forms.TextBox ajoutNomCreditChamp;
        private System.Windows.Forms.Label idBudget;
        private System.Windows.Forms.Label idEvenement;
        private System.Windows.Forms.Label idAdherent;
        private System.Windows.Forms.Label prelevementEffectue;
        private System.Windows.Forms.Label montantCredit;
        private System.Windows.Forms.Label dateCredit;
        private System.Windows.Forms.Label libelleCredit;
        private GestionAssociationSportiveDataSet gestionAssociationSportiveDataSet;
        private System.Windows.Forms.BindingSource aDHERENTBindingSource;
        private GestionAssociationSportiveDataSetTableAdapters.ADHERENTTableAdapter aDHERENTTableAdapter;
        private System.Windows.Forms.BindingSource eVENEMENTBindingSource;
        private GestionAssociationSportiveDataSetTableAdapters.EVENEMENTTableAdapter eVENEMENTTableAdapter;
        private System.Windows.Forms.BindingSource bUDGETBindingSource;
        private GestionAssociationSportiveDataSetTableAdapters.BUDGETTableAdapter bUDGETTableAdapter;
    }
}