namespace UtilisateursGUI
{
    partial class ModificationDebit
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
            this.modificationBudgetChamp = new System.Windows.Forms.ComboBox();
            this.bUDGETBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gestionAssociationSportiveDataSet = new UtilisateursGUI.GestionAssociationSportiveDataSet();
            this.modificationIdEvenementChamp = new System.Windows.Forms.ComboBox();
            this.eVENEMENTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.modificationIdAdherentChamp = new System.Windows.Forms.ComboBox();
            this.aDHERENTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.modificationPrelevementEffectueChamp = new System.Windows.Forms.GroupBox();
            this.non = new System.Windows.Forms.RadioButton();
            this.oui = new System.Windows.Forms.RadioButton();
            this.modificationDateDebitChamp = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.success = new System.Windows.Forms.Label();
            this.modifier = new System.Windows.Forms.Button();
            this.annuler = new System.Windows.Forms.Button();
            this.modificationMontantDebitChamp = new System.Windows.Forms.TextBox();
            this.modificationNomDebitChamp = new System.Windows.Forms.TextBox();
            this.idBudget = new System.Windows.Forms.Label();
            this.idEvenement = new System.Windows.Forms.Label();
            this.idAdherent = new System.Windows.Forms.Label();
            this.prelevementEffectue = new System.Windows.Forms.Label();
            this.montantDebit = new System.Windows.Forms.Label();
            this.dateDebit = new System.Windows.Forms.Label();
            this.libelleDebit = new System.Windows.Forms.Label();
            this.bUDGETTableAdapter = new UtilisateursGUI.GestionAssociationSportiveDataSetTableAdapters.BUDGETTableAdapter();
            this.eVENEMENTTableAdapter = new UtilisateursGUI.GestionAssociationSportiveDataSetTableAdapters.EVENEMENTTableAdapter();
            this.aDHERENTTableAdapter = new UtilisateursGUI.GestionAssociationSportiveDataSetTableAdapters.ADHERENTTableAdapter();
            this.id = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bUDGETBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionAssociationSportiveDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eVENEMENTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aDHERENTBindingSource)).BeginInit();
            this.modificationPrelevementEffectueChamp.SuspendLayout();
            this.SuspendLayout();
            // 
            // modificationBudgetChamp
            // 
            this.modificationBudgetChamp.DataSource = this.bUDGETBindingSource;
            this.modificationBudgetChamp.DisplayMember = "Libelle_budget";
            this.modificationBudgetChamp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.modificationBudgetChamp.Font = new System.Drawing.Font("Calibri Light", 12F);
            this.modificationBudgetChamp.FormattingEnabled = true;
            this.modificationBudgetChamp.Location = new System.Drawing.Point(460, 156);
            this.modificationBudgetChamp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.modificationBudgetChamp.Name = "modificationBudgetChamp";
            this.modificationBudgetChamp.Size = new System.Drawing.Size(131, 27);
            this.modificationBudgetChamp.TabIndex = 65;
            this.modificationBudgetChamp.ValueMember = "Id_budget";
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
            // modificationIdEvenementChamp
            // 
            this.modificationIdEvenementChamp.DataSource = this.eVENEMENTBindingSource;
            this.modificationIdEvenementChamp.DisplayMember = "Libelle_evenement";
            this.modificationIdEvenementChamp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.modificationIdEvenementChamp.Font = new System.Drawing.Font("Calibri Light", 12F);
            this.modificationIdEvenementChamp.FormattingEnabled = true;
            this.modificationIdEvenementChamp.Location = new System.Drawing.Point(487, 109);
            this.modificationIdEvenementChamp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.modificationIdEvenementChamp.Name = "modificationIdEvenementChamp";
            this.modificationIdEvenementChamp.Size = new System.Drawing.Size(131, 27);
            this.modificationIdEvenementChamp.TabIndex = 64;
            this.modificationIdEvenementChamp.ValueMember = "Id_evenement";
            // 
            // eVENEMENTBindingSource
            // 
            this.eVENEMENTBindingSource.DataMember = "EVENEMENT";
            this.eVENEMENTBindingSource.DataSource = this.gestionAssociationSportiveDataSet;
            // 
            // modificationIdAdherentChamp
            // 
            this.modificationIdAdherentChamp.DataSource = this.aDHERENTBindingSource;
            this.modificationIdAdherentChamp.DisplayMember = "Nom_adherent";
            this.modificationIdAdherentChamp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.modificationIdAdherentChamp.Font = new System.Drawing.Font("Calibri Light", 12F);
            this.modificationIdAdherentChamp.FormattingEnabled = true;
            this.modificationIdAdherentChamp.Location = new System.Drawing.Point(474, 70);
            this.modificationIdAdherentChamp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.modificationIdAdherentChamp.Name = "modificationIdAdherentChamp";
            this.modificationIdAdherentChamp.Size = new System.Drawing.Size(131, 27);
            this.modificationIdAdherentChamp.TabIndex = 63;
            this.modificationIdAdherentChamp.ValueMember = "Id_adherent";
            // 
            // aDHERENTBindingSource
            // 
            this.aDHERENTBindingSource.DataMember = "ADHERENT";
            this.aDHERENTBindingSource.DataSource = this.gestionAssociationSportiveDataSet;
            // 
            // modificationPrelevementEffectueChamp
            // 
            this.modificationPrelevementEffectueChamp.Controls.Add(this.non);
            this.modificationPrelevementEffectueChamp.Controls.Add(this.oui);
            this.modificationPrelevementEffectueChamp.Location = new System.Drawing.Point(191, 198);
            this.modificationPrelevementEffectueChamp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.modificationPrelevementEffectueChamp.Name = "modificationPrelevementEffectueChamp";
            this.modificationPrelevementEffectueChamp.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.modificationPrelevementEffectueChamp.Size = new System.Drawing.Size(101, 21);
            this.modificationPrelevementEffectueChamp.TabIndex = 62;
            this.modificationPrelevementEffectueChamp.TabStop = false;
            // 
            // non
            // 
            this.non.AutoSize = true;
            this.non.Font = new System.Drawing.Font("Calibri Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.non.Location = new System.Drawing.Point(50, 2);
            this.non.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.non.Name = "non";
            this.non.Size = new System.Drawing.Size(47, 21);
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
            this.oui.Location = new System.Drawing.Point(5, 0);
            this.oui.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.oui.Name = "oui";
            this.oui.Size = new System.Drawing.Size(43, 21);
            this.oui.TabIndex = 0;
            this.oui.TabStop = true;
            this.oui.Text = "oui";
            this.oui.UseVisualStyleBackColor = true;
            this.oui.CheckedChanged += new System.EventHandler(this.oui_CheckedChanged);
            // 
            // modificationDateDebitChamp
            // 
            this.modificationDateDebitChamp.Font = new System.Drawing.Font("Calibri Light", 12F);
            this.modificationDateDebitChamp.Location = new System.Drawing.Point(114, 111);
            this.modificationDateDebitChamp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.modificationDateDebitChamp.Name = "modificationDateDebitChamp";
            this.modificationDateDebitChamp.Size = new System.Drawing.Size(217, 27);
            this.modificationDateDebitChamp.TabIndex = 61;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri Light", 22F);
            this.label1.Location = new System.Drawing.Point(9, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 37);
            this.label1.TabIndex = 60;
            this.label1.Text = "Modifier un Débit :";
            // 
            // success
            // 
            this.success.AutoSize = true;
            this.success.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.success.Location = new System.Drawing.Point(338, 197);
            this.success.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.success.Name = "success";
            this.success.Size = new System.Drawing.Size(183, 19);
            this.success.TabIndex = 59;
            this.success.Text = "Le débit a bien été modifié";
            this.success.Visible = false;
            // 
            // modifier
            // 
            this.modifier.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifier.Location = new System.Drawing.Point(638, 86);
            this.modifier.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.modifier.Name = "modifier";
            this.modifier.Size = new System.Drawing.Size(128, 51);
            this.modifier.TabIndex = 57;
            this.modifier.Text = "Modifier";
            this.modifier.UseVisualStyleBackColor = true;
            this.modifier.Click += new System.EventHandler(this.modifier_Click);
            // 
            // annuler
            // 
            this.annuler.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.annuler.Location = new System.Drawing.Point(638, 27);
            this.annuler.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.annuler.Name = "annuler";
            this.annuler.Size = new System.Drawing.Size(128, 51);
            this.annuler.TabIndex = 56;
            this.annuler.Text = "Retour";
            this.annuler.UseVisualStyleBackColor = true;
            this.annuler.Click += new System.EventHandler(this.annuler_Click);
            // 
            // modificationMontantDebitChamp
            // 
            this.modificationMontantDebitChamp.Font = new System.Drawing.Font("Calibri Light", 12F);
            this.modificationMontantDebitChamp.Location = new System.Drawing.Point(137, 152);
            this.modificationMontantDebitChamp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.modificationMontantDebitChamp.Name = "modificationMontantDebitChamp";
            this.modificationMontantDebitChamp.Size = new System.Drawing.Size(132, 27);
            this.modificationMontantDebitChamp.TabIndex = 55;
            // 
            // modificationNomDebitChamp
            // 
            this.modificationNomDebitChamp.Font = new System.Drawing.Font("Calibri Light", 12F);
            this.modificationNomDebitChamp.Location = new System.Drawing.Point(114, 72);
            this.modificationNomDebitChamp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.modificationNomDebitChamp.Name = "modificationNomDebitChamp";
            this.modificationNomDebitChamp.Size = new System.Drawing.Size(135, 27);
            this.modificationNomDebitChamp.TabIndex = 54;
            // 
            // idBudget
            // 
            this.idBudget.AutoSize = true;
            this.idBudget.Font = new System.Drawing.Font("Calibri Light", 12F);
            this.idBudget.Location = new System.Drawing.Point(338, 158);
            this.idBudget.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.idBudget.Name = "idBudget";
            this.idBudget.Size = new System.Drawing.Size(127, 19);
            this.idBudget.TabIndex = 53;
            this.idBudget.Text = "Budget concerné :";
            // 
            // idEvenement
            // 
            this.idEvenement.AutoSize = true;
            this.idEvenement.Font = new System.Drawing.Font("Calibri Light", 12F);
            this.idEvenement.Location = new System.Drawing.Point(338, 111);
            this.idEvenement.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.idEvenement.Name = "idEvenement";
            this.idEvenement.Size = new System.Drawing.Size(154, 19);
            this.idEvenement.TabIndex = 52;
            this.idEvenement.Text = "Evenement concerné :";
            // 
            // idAdherent
            // 
            this.idAdherent.AutoSize = true;
            this.idAdherent.Font = new System.Drawing.Font("Calibri Light", 12F);
            this.idAdherent.Location = new System.Drawing.Point(338, 72);
            this.idAdherent.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.idAdherent.Name = "idAdherent";
            this.idAdherent.Size = new System.Drawing.Size(141, 19);
            this.idAdherent.TabIndex = 51;
            this.idAdherent.Text = "Adhérent concerné :";
            // 
            // prelevementEffectue
            // 
            this.prelevementEffectue.AutoSize = true;
            this.prelevementEffectue.Font = new System.Drawing.Font("Calibri Light", 12F);
            this.prelevementEffectue.Location = new System.Drawing.Point(12, 198);
            this.prelevementEffectue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.prelevementEffectue.Name = "prelevementEffectue";
            this.prelevementEffectue.Size = new System.Drawing.Size(189, 19);
            this.prelevementEffectue.TabIndex = 50;
            this.prelevementEffectue.Text = "Prélèvement déja effectué :";
            // 
            // montantDebit
            // 
            this.montantDebit.AutoSize = true;
            this.montantDebit.Font = new System.Drawing.Font("Calibri Light", 12F);
            this.montantDebit.Location = new System.Drawing.Point(12, 154);
            this.montantDebit.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.montantDebit.Name = "montantDebit";
            this.montantDebit.Size = new System.Drawing.Size(130, 19);
            this.montantDebit.TabIndex = 49;
            this.montantDebit.Text = "Montant du débit :";
            // 
            // dateDebit
            // 
            this.dateDebit.AutoSize = true;
            this.dateDebit.Font = new System.Drawing.Font("Calibri Light", 12F);
            this.dateDebit.Location = new System.Drawing.Point(12, 116);
            this.dateDebit.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.dateDebit.Name = "dateDebit";
            this.dateDebit.Size = new System.Drawing.Size(105, 19);
            this.dateDebit.TabIndex = 48;
            this.dateDebit.Text = "Date du débit :";
            // 
            // libelleDebit
            // 
            this.libelleDebit.AutoSize = true;
            this.libelleDebit.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.libelleDebit.Location = new System.Drawing.Point(12, 75);
            this.libelleDebit.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.libelleDebit.Name = "libelleDebit";
            this.libelleDebit.Size = new System.Drawing.Size(105, 19);
            this.libelleDebit.TabIndex = 47;
            this.libelleDebit.Text = "Nom du débit :";
            // 
            // bUDGETTableAdapter
            // 
            this.bUDGETTableAdapter.ClearBeforeFill = true;
            // 
            // eVENEMENTTableAdapter
            // 
            this.eVENEMENTTableAdapter.ClearBeforeFill = true;
            // 
            // aDHERENTTableAdapter
            // 
            this.aDHERENTTableAdapter.ClearBeforeFill = true;
            // 
            // id
            // 
            this.id.AutoSize = true;
            this.id.Location = new System.Drawing.Point(670, 47);
            this.id.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(35, 13);
            this.id.TabIndex = 77;
            this.id.Text = "label8";
            this.id.Visible = false;
            // 
            // ModificationDebit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 366);
            this.Controls.Add(this.modificationBudgetChamp);
            this.Controls.Add(this.modificationIdEvenementChamp);
            this.Controls.Add(this.modificationIdAdherentChamp);
            this.Controls.Add(this.modificationPrelevementEffectueChamp);
            this.Controls.Add(this.modificationDateDebitChamp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.success);
            this.Controls.Add(this.modifier);
            this.Controls.Add(this.annuler);
            this.Controls.Add(this.modificationMontantDebitChamp);
            this.Controls.Add(this.modificationNomDebitChamp);
            this.Controls.Add(this.idBudget);
            this.Controls.Add(this.idEvenement);
            this.Controls.Add(this.idAdherent);
            this.Controls.Add(this.prelevementEffectue);
            this.Controls.Add(this.montantDebit);
            this.Controls.Add(this.dateDebit);
            this.Controls.Add(this.libelleDebit);
            this.Controls.Add(this.id);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ModificationDebit";
            this.Text = "ModificationDebit";
            this.Load += new System.EventHandler(this.ModificationDebit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bUDGETBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionAssociationSportiveDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eVENEMENTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aDHERENTBindingSource)).EndInit();
            this.modificationPrelevementEffectueChamp.ResumeLayout(false);
            this.modificationPrelevementEffectueChamp.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox modificationBudgetChamp;
        private System.Windows.Forms.ComboBox modificationIdEvenementChamp;
        private System.Windows.Forms.ComboBox modificationIdAdherentChamp;
        private System.Windows.Forms.GroupBox modificationPrelevementEffectueChamp;
        private System.Windows.Forms.RadioButton non;
        private System.Windows.Forms.RadioButton oui;
        private System.Windows.Forms.DateTimePicker modificationDateDebitChamp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label success;
        private System.Windows.Forms.Button modifier;
        private System.Windows.Forms.Button annuler;
        private System.Windows.Forms.TextBox modificationMontantDebitChamp;
        private System.Windows.Forms.TextBox modificationNomDebitChamp;
        private System.Windows.Forms.Label idBudget;
        private System.Windows.Forms.Label idEvenement;
        private System.Windows.Forms.Label idAdherent;
        private System.Windows.Forms.Label prelevementEffectue;
        private System.Windows.Forms.Label montantDebit;
        private System.Windows.Forms.Label dateDebit;
        private System.Windows.Forms.Label libelleDebit;
        private GestionAssociationSportiveDataSet gestionAssociationSportiveDataSet;
        private System.Windows.Forms.BindingSource bUDGETBindingSource;
        private GestionAssociationSportiveDataSetTableAdapters.BUDGETTableAdapter bUDGETTableAdapter;
        private System.Windows.Forms.BindingSource eVENEMENTBindingSource;
        private GestionAssociationSportiveDataSetTableAdapters.EVENEMENTTableAdapter eVENEMENTTableAdapter;
        private System.Windows.Forms.BindingSource aDHERENTBindingSource;
        private GestionAssociationSportiveDataSetTableAdapters.ADHERENTTableAdapter aDHERENTTableAdapter;
        public System.Windows.Forms.Label id;
    }
}