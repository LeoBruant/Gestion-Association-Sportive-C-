namespace UtilisateursGUI
{
    partial class ajoutDebit
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
            this.libelleDebit = new System.Windows.Forms.Label();
            this.dateDebit = new System.Windows.Forms.Label();
            this.montantDebit = new System.Windows.Forms.Label();
            this.prelevementEffectue = new System.Windows.Forms.Label();
            this.idAdherent = new System.Windows.Forms.Label();
            this.idEvenement = new System.Windows.Forms.Label();
            this.idBudget = new System.Windows.Forms.Label();
            this.ajoutNomDebitChamp = new System.Windows.Forms.TextBox();
            this.ajoutMontantDebitChamp = new System.Windows.Forms.TextBox();
            this.success = new System.Windows.Forms.Label();
            this.erreurChampsVides = new System.Windows.Forms.Label();
            this.ajouter = new System.Windows.Forms.Button();
            this.annuler = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ajoutDateDebitChamp = new System.Windows.Forms.DateTimePicker();
            this.ajoutPrelevementEfectueChamp = new System.Windows.Forms.GroupBox();
            this.non = new System.Windows.Forms.RadioButton();
            this.oui = new System.Windows.Forms.RadioButton();
            this.ajoutIdAdherentChamp = new System.Windows.Forms.ComboBox();
            this.gestionAssociationSportiveDataSet = new UtilisateursGUI.GestionAssociationSportiveDataSet();
            this.gestionAssociationSportiveDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aDHERENTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aDHERENTTableAdapter = new UtilisateursGUI.GestionAssociationSportiveDataSetTableAdapters.ADHERENTTableAdapter();
            this.aDHERENTBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.ajoutIdEvenementChamp = new System.Windows.Forms.ComboBox();
            this.eVENEMENTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eVENEMENTTableAdapter = new UtilisateursGUI.GestionAssociationSportiveDataSetTableAdapters.EVENEMENTTableAdapter();
            this.ajoutBudgetChamp = new System.Windows.Forms.ComboBox();
            this.bUDGETBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bUDGETTableAdapter = new UtilisateursGUI.GestionAssociationSportiveDataSetTableAdapters.BUDGETTableAdapter();
            this.ajoutPrelevementEfectueChamp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gestionAssociationSportiveDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionAssociationSportiveDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aDHERENTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aDHERENTBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eVENEMENTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bUDGETBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // libelleDebit
            // 
            this.libelleDebit.AutoSize = true;
            this.libelleDebit.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.libelleDebit.Location = new System.Drawing.Point(31, 87);
            this.libelleDebit.Name = "libelleDebit";
            this.libelleDebit.Size = new System.Drawing.Size(130, 24);
            this.libelleDebit.TabIndex = 0;
            this.libelleDebit.Text = "Nom du débit :";
            // 
            // dateDebit
            // 
            this.dateDebit.AutoSize = true;
            this.dateDebit.Font = new System.Drawing.Font("Calibri Light", 12F);
            this.dateDebit.Location = new System.Drawing.Point(31, 136);
            this.dateDebit.Name = "dateDebit";
            this.dateDebit.Size = new System.Drawing.Size(129, 24);
            this.dateDebit.TabIndex = 1;
            this.dateDebit.Text = "Date du débit :";
            // 
            // montantDebit
            // 
            this.montantDebit.AutoSize = true;
            this.montantDebit.Font = new System.Drawing.Font("Calibri Light", 12F);
            this.montantDebit.Location = new System.Drawing.Point(31, 185);
            this.montantDebit.Name = "montantDebit";
            this.montantDebit.Size = new System.Drawing.Size(161, 24);
            this.montantDebit.TabIndex = 2;
            this.montantDebit.Text = "Montant du débit :";
            // 
            // prelevementEffectue
            // 
            this.prelevementEffectue.AutoSize = true;
            this.prelevementEffectue.Font = new System.Drawing.Font("Calibri Light", 12F);
            this.prelevementEffectue.Location = new System.Drawing.Point(31, 238);
            this.prelevementEffectue.Name = "prelevementEffectue";
            this.prelevementEffectue.Size = new System.Drawing.Size(233, 24);
            this.prelevementEffectue.TabIndex = 3;
            this.prelevementEffectue.Text = "Prélèvement déja effectué :";
            // 
            // idAdherent
            // 
            this.idAdherent.AutoSize = true;
            this.idAdherent.Font = new System.Drawing.Font("Calibri Light", 12F);
            this.idAdherent.Location = new System.Drawing.Point(31, 290);
            this.idAdherent.Name = "idAdherent";
            this.idAdherent.Size = new System.Drawing.Size(175, 24);
            this.idAdherent.TabIndex = 4;
            this.idAdherent.Text = "Adhérent concerné :";
            // 
            // idEvenement
            // 
            this.idEvenement.AutoSize = true;
            this.idEvenement.Font = new System.Drawing.Font("Calibri Light", 12F);
            this.idEvenement.Location = new System.Drawing.Point(31, 344);
            this.idEvenement.Name = "idEvenement";
            this.idEvenement.Size = new System.Drawing.Size(192, 24);
            this.idEvenement.TabIndex = 5;
            this.idEvenement.Text = "Evenement concerné :";
            // 
            // idBudget
            // 
            this.idBudget.AutoSize = true;
            this.idBudget.Font = new System.Drawing.Font("Calibri Light", 12F);
            this.idBudget.Location = new System.Drawing.Point(31, 391);
            this.idBudget.Name = "idBudget";
            this.idBudget.Size = new System.Drawing.Size(157, 24);
            this.idBudget.TabIndex = 6;
            this.idBudget.Text = "Budget concerné :";
            // 
            // ajoutNomDebitChamp
            // 
            this.ajoutNomDebitChamp.Font = new System.Drawing.Font("Calibri Light", 12F);
            this.ajoutNomDebitChamp.Location = new System.Drawing.Point(167, 84);
            this.ajoutNomDebitChamp.Name = "ajoutNomDebitChamp";
            this.ajoutNomDebitChamp.Size = new System.Drawing.Size(179, 32);
            this.ajoutNomDebitChamp.TabIndex = 7;
            // 
            // ajoutMontantDebitChamp
            // 
            this.ajoutMontantDebitChamp.Font = new System.Drawing.Font("Calibri Light", 12F);
            this.ajoutMontantDebitChamp.Location = new System.Drawing.Point(198, 182);
            this.ajoutMontantDebitChamp.Name = "ajoutMontantDebitChamp";
            this.ajoutMontantDebitChamp.Size = new System.Drawing.Size(174, 32);
            this.ajoutMontantDebitChamp.TabIndex = 9;
            // 
            // success
            // 
            this.success.AutoSize = true;
            this.success.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.success.Location = new System.Drawing.Point(532, 251);
            this.success.Name = "success";
            this.success.Size = new System.Drawing.Size(215, 24);
            this.success.TabIndex = 40;
            this.success.Text = "Le débit a bien été ajouté";
            this.success.Visible = false;
            // 
            // erreurChampsVides
            // 
            this.erreurChampsVides.AutoSize = true;
            this.erreurChampsVides.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.erreurChampsVides.ForeColor = System.Drawing.Color.Red;
            this.erreurChampsVides.Location = new System.Drawing.Point(501, 215);
            this.erreurChampsVides.Name = "erreurChampsVides";
            this.erreurChampsVides.Size = new System.Drawing.Size(267, 24);
            this.erreurChampsVides.TabIndex = 39;
            this.erreurChampsVides.Text = "Veuillez remplir tous les champs";
            this.erreurChampsVides.Visible = false;
            // 
            // ajouter
            // 
            this.ajouter.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ajouter.Location = new System.Drawing.Point(579, 127);
            this.ajouter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ajouter.Name = "ajouter";
            this.ajouter.Size = new System.Drawing.Size(171, 63);
            this.ajouter.TabIndex = 38;
            this.ajouter.Text = "Ajouter";
            this.ajouter.UseVisualStyleBackColor = true;
            this.ajouter.Click += new System.EventHandler(this.ajouter_Click);
            // 
            // annuler
            // 
            this.annuler.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.annuler.Location = new System.Drawing.Point(579, 32);
            this.annuler.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.annuler.Name = "annuler";
            this.annuler.Size = new System.Drawing.Size(171, 63);
            this.annuler.TabIndex = 37;
            this.annuler.Text = "Retour";
            this.annuler.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri Light", 22F);
            this.label1.Location = new System.Drawing.Point(27, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(282, 45);
            this.label1.TabIndex = 41;
            this.label1.Text = "Ajouter un Débit :";
            // 
            // ajoutDateDebitChamp
            // 
            this.ajoutDateDebitChamp.Font = new System.Drawing.Font("Calibri Light", 12F);
            this.ajoutDateDebitChamp.Location = new System.Drawing.Point(166, 130);
            this.ajoutDateDebitChamp.Name = "ajoutDateDebitChamp";
            this.ajoutDateDebitChamp.Size = new System.Drawing.Size(288, 32);
            this.ajoutDateDebitChamp.TabIndex = 42;
            // 
            // ajoutPrelevementEfectueChamp
            // 
            this.ajoutPrelevementEfectueChamp.Controls.Add(this.non);
            this.ajoutPrelevementEfectueChamp.Controls.Add(this.oui);
            this.ajoutPrelevementEfectueChamp.Location = new System.Drawing.Point(270, 238);
            this.ajoutPrelevementEfectueChamp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ajoutPrelevementEfectueChamp.Name = "ajoutPrelevementEfectueChamp";
            this.ajoutPrelevementEfectueChamp.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ajoutPrelevementEfectueChamp.Size = new System.Drawing.Size(135, 26);
            this.ajoutPrelevementEfectueChamp.TabIndex = 43;
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
            this.non.CheckedChanged += new System.EventHandler(this.non_CheckedChanged);
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
            this.oui.CheckedChanged += new System.EventHandler(this.oui_CheckedChanged);
            // 
            // ajoutIdAdherentChamp
            // 
            this.ajoutIdAdherentChamp.DataSource = this.aDHERENTBindingSource1;
            this.ajoutIdAdherentChamp.DisplayMember = "Nom_adherent";
            this.ajoutIdAdherentChamp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ajoutIdAdherentChamp.Font = new System.Drawing.Font("Calibri Light", 12F);
            this.ajoutIdAdherentChamp.FormattingEnabled = true;
            this.ajoutIdAdherentChamp.Location = new System.Drawing.Point(212, 287);
            this.ajoutIdAdherentChamp.Name = "ajoutIdAdherentChamp";
            this.ajoutIdAdherentChamp.Size = new System.Drawing.Size(173, 32);
            this.ajoutIdAdherentChamp.TabIndex = 44;
            this.ajoutIdAdherentChamp.ValueMember = "Id_adherent";
            // 
            // gestionAssociationSportiveDataSet
            // 
            this.gestionAssociationSportiveDataSet.DataSetName = "GestionAssociationSportiveDataSet";
            this.gestionAssociationSportiveDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gestionAssociationSportiveDataSetBindingSource
            // 
            this.gestionAssociationSportiveDataSetBindingSource.DataSource = this.gestionAssociationSportiveDataSet;
            this.gestionAssociationSportiveDataSetBindingSource.Position = 0;
            // 
            // aDHERENTBindingSource
            // 
            this.aDHERENTBindingSource.DataMember = "ADHERENT";
            this.aDHERENTBindingSource.DataSource = this.gestionAssociationSportiveDataSet;
            // 
            // aDHERENTTableAdapter
            // 
            this.aDHERENTTableAdapter.ClearBeforeFill = true;
            // 
            // aDHERENTBindingSource1
            // 
            this.aDHERENTBindingSource1.DataMember = "ADHERENT";
            this.aDHERENTBindingSource1.DataSource = this.gestionAssociationSportiveDataSetBindingSource;
            // 
            // ajoutIdEvenementChamp
            // 
            this.ajoutIdEvenementChamp.DataSource = this.eVENEMENTBindingSource;
            this.ajoutIdEvenementChamp.DisplayMember = "Libelle_evenement";
            this.ajoutIdEvenementChamp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ajoutIdEvenementChamp.Font = new System.Drawing.Font("Calibri Light", 12F);
            this.ajoutIdEvenementChamp.FormattingEnabled = true;
            this.ajoutIdEvenementChamp.Location = new System.Drawing.Point(229, 341);
            this.ajoutIdEvenementChamp.Name = "ajoutIdEvenementChamp";
            this.ajoutIdEvenementChamp.Size = new System.Drawing.Size(173, 32);
            this.ajoutIdEvenementChamp.TabIndex = 45;
            this.ajoutIdEvenementChamp.ValueMember = "Id_evenement";
            // 
            // eVENEMENTBindingSource
            // 
            this.eVENEMENTBindingSource.DataMember = "EVENEMENT";
            this.eVENEMENTBindingSource.DataSource = this.gestionAssociationSportiveDataSetBindingSource;
            // 
            // eVENEMENTTableAdapter
            // 
            this.eVENEMENTTableAdapter.ClearBeforeFill = true;
            // 
            // ajoutBudgetChamp
            // 
            this.ajoutBudgetChamp.DataSource = this.bUDGETBindingSource;
            this.ajoutBudgetChamp.DisplayMember = "Libelle_budget";
            this.ajoutBudgetChamp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ajoutBudgetChamp.Font = new System.Drawing.Font("Calibri Light", 12F);
            this.ajoutBudgetChamp.FormattingEnabled = true;
            this.ajoutBudgetChamp.Location = new System.Drawing.Point(194, 388);
            this.ajoutBudgetChamp.Name = "ajoutBudgetChamp";
            this.ajoutBudgetChamp.Size = new System.Drawing.Size(173, 32);
            this.ajoutBudgetChamp.TabIndex = 46;
            this.ajoutBudgetChamp.ValueMember = "Id_budget";
            // 
            // bUDGETBindingSource
            // 
            this.bUDGETBindingSource.DataMember = "BUDGET";
            this.bUDGETBindingSource.DataSource = this.gestionAssociationSportiveDataSetBindingSource;
            // 
            // bUDGETTableAdapter
            // 
            this.bUDGETTableAdapter.ClearBeforeFill = true;
            // 
            // ajoutDebit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ajoutBudgetChamp);
            this.Controls.Add(this.ajoutIdEvenementChamp);
            this.Controls.Add(this.ajoutIdAdherentChamp);
            this.Controls.Add(this.ajoutPrelevementEfectueChamp);
            this.Controls.Add(this.ajoutDateDebitChamp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.success);
            this.Controls.Add(this.erreurChampsVides);
            this.Controls.Add(this.ajouter);
            this.Controls.Add(this.annuler);
            this.Controls.Add(this.ajoutMontantDebitChamp);
            this.Controls.Add(this.ajoutNomDebitChamp);
            this.Controls.Add(this.idBudget);
            this.Controls.Add(this.idEvenement);
            this.Controls.Add(this.idAdherent);
            this.Controls.Add(this.prelevementEffectue);
            this.Controls.Add(this.montantDebit);
            this.Controls.Add(this.dateDebit);
            this.Controls.Add(this.libelleDebit);
            this.Name = "ajoutDebit";
            this.Text = "ajoutDebit";
            this.Load += new System.EventHandler(this.ajoutDebit_Load);
            this.ajoutPrelevementEfectueChamp.ResumeLayout(false);
            this.ajoutPrelevementEfectueChamp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gestionAssociationSportiveDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionAssociationSportiveDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aDHERENTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aDHERENTBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eVENEMENTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bUDGETBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label libelleDebit;
        private System.Windows.Forms.Label dateDebit;
        private System.Windows.Forms.Label montantDebit;
        private System.Windows.Forms.Label prelevementEffectue;
        private System.Windows.Forms.Label idAdherent;
        private System.Windows.Forms.Label idEvenement;
        private System.Windows.Forms.Label idBudget;
        private System.Windows.Forms.TextBox ajoutNomDebitChamp;
        private System.Windows.Forms.TextBox ajoutMontantDebitChamp;
        private System.Windows.Forms.Label success;
        private System.Windows.Forms.Label erreurChampsVides;
        private System.Windows.Forms.Button ajouter;
        private System.Windows.Forms.Button annuler;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker ajoutDateDebitChamp;
        private System.Windows.Forms.GroupBox ajoutPrelevementEfectueChamp;
        private System.Windows.Forms.RadioButton non;
        private System.Windows.Forms.RadioButton oui;
        private System.Windows.Forms.ComboBox ajoutIdAdherentChamp;
        private System.Windows.Forms.BindingSource gestionAssociationSportiveDataSetBindingSource;
        private GestionAssociationSportiveDataSet gestionAssociationSportiveDataSet;
        private System.Windows.Forms.BindingSource aDHERENTBindingSource;
        private GestionAssociationSportiveDataSetTableAdapters.ADHERENTTableAdapter aDHERENTTableAdapter;
        private System.Windows.Forms.BindingSource aDHERENTBindingSource1;
        private System.Windows.Forms.ComboBox ajoutIdEvenementChamp;
        private System.Windows.Forms.BindingSource eVENEMENTBindingSource;
        private GestionAssociationSportiveDataSetTableAdapters.EVENEMENTTableAdapter eVENEMENTTableAdapter;
        private System.Windows.Forms.ComboBox ajoutBudgetChamp;
        private System.Windows.Forms.BindingSource bUDGETBindingSource;
        private GestionAssociationSportiveDataSetTableAdapters.BUDGETTableAdapter bUDGETTableAdapter;
    }
}