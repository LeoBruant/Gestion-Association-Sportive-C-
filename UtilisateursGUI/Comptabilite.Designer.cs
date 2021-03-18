namespace UtilisateursGUI
{
    partial class Comptabilite
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
            this.button1 = new System.Windows.Forms.Button();
            this.EPSChamp = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.modifEPS = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.EPSLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ASChamp = new System.Windows.Forms.TextBox();
            this.modifAS = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.ASLabel = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.ajoutDebit = new System.Windows.Forms.Button();
            this.boutonModifierDebit = new System.Windows.Forms.Button();
            this.debits = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.domainUpDown1 = new System.Windows.Forms.DomainUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.label13 = new System.Windows.Forms.Label();
            this.login = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label19 = new System.Windows.Forms.Label();
            this.EPSError = new System.Windows.Forms.Label();
            this.ASError = new System.Windows.Forms.Label();
            this.retour = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.erreurDebit = new System.Windows.Forms.Label();
            this.successDebit = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.debits)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(841, 16);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(171, 63);
            this.button1.TabIndex = 1;
            this.button1.Text = "Déconnexion";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // EPSChamp
            // 
            this.EPSChamp.Font = new System.Drawing.Font("Calibri Light", 10.2F);
            this.EPSChamp.Location = new System.Drawing.Point(213, 50);
            this.EPSChamp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EPSChamp.Name = "EPSChamp";
            this.EPSChamp.Size = new System.Drawing.Size(157, 28);
            this.EPSChamp.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AccessibleName = "";
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 24);
            this.label1.TabIndex = 15;
            this.label1.Text = "Budjet Annuel EPS : ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // modifEPS
            // 
            this.modifEPS.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifEPS.Location = new System.Drawing.Point(393, 50);
            this.modifEPS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.modifEPS.Name = "modifEPS";
            this.modifEPS.Size = new System.Drawing.Size(131, 31);
            this.modifEPS.TabIndex = 16;
            this.modifEPS.Text = "enregistrer";
            this.modifEPS.UseVisualStyleBackColor = true;
            this.modifEPS.Click += new System.EventHandler(this.modifEPS_Click);
            // 
            // label2
            // 
            this.label2.AccessibleName = "";
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(549, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 24);
            this.label2.TabIndex = 17;
            this.label2.Text = "Budjet Annuel EPS : ";
            // 
            // EPSLabel
            // 
            this.EPSLabel.AccessibleName = "";
            this.EPSLabel.AutoSize = true;
            this.EPSLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EPSLabel.Location = new System.Drawing.Point(733, 52);
            this.EPSLabel.Name = "EPSLabel";
            this.EPSLabel.Size = new System.Drawing.Size(60, 24);
            this.EPSLabel.TabIndex = 18;
            this.EPSLabel.Text = "XXXX€";
            // 
            // label4
            // 
            this.label4.AccessibleName = "";
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(171, 24);
            this.label4.TabIndex = 19;
            this.label4.Text = "Budjet Annuel AS : ";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // ASChamp
            // 
            this.ASChamp.Font = new System.Drawing.Font("Calibri Light", 10.2F);
            this.ASChamp.Location = new System.Drawing.Point(213, 116);
            this.ASChamp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ASChamp.Name = "ASChamp";
            this.ASChamp.Size = new System.Drawing.Size(157, 28);
            this.ASChamp.TabIndex = 20;
            // 
            // modifAS
            // 
            this.modifAS.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifAS.Location = new System.Drawing.Point(393, 116);
            this.modifAS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.modifAS.Name = "modifAS";
            this.modifAS.Size = new System.Drawing.Size(131, 31);
            this.modifAS.TabIndex = 21;
            this.modifAS.Text = "enregistrer";
            this.modifAS.UseVisualStyleBackColor = true;
            this.modifAS.Click += new System.EventHandler(this.modifAS_Click);
            // 
            // label5
            // 
            this.label5.AccessibleName = "";
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(549, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(171, 24);
            this.label5.TabIndex = 22;
            this.label5.Text = "Budjet Annuel AS : ";
            // 
            // ASLabel
            // 
            this.ASLabel.AccessibleName = "";
            this.ASLabel.AutoSize = true;
            this.ASLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ASLabel.Location = new System.Drawing.Point(733, 119);
            this.ASLabel.Name = "ASLabel";
            this.ASLabel.Size = new System.Drawing.Size(60, 24);
            this.ASLabel.TabIndex = 23;
            this.ASLabel.Text = "XXXX€";
            this.ASLabel.Click += new System.EventHandler(this.label6_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(1057, 279);
            this.button5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(131, 31);
            this.button5.TabIndex = 25;
            this.button5.Text = "Supprimer";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // ajoutDebit
            // 
            this.ajoutDebit.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ajoutDebit.Location = new System.Drawing.Point(1057, 228);
            this.ajoutDebit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ajoutDebit.Name = "ajoutDebit";
            this.ajoutDebit.Size = new System.Drawing.Size(131, 31);
            this.ajoutDebit.TabIndex = 26;
            this.ajoutDebit.Text = "Ajouter";
            this.ajoutDebit.UseVisualStyleBackColor = true;
            this.ajoutDebit.Click += new System.EventHandler(this.ajoutDebit_Click);
            // 
            // boutonModifierDebit
            // 
            this.boutonModifierDebit.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boutonModifierDebit.Location = new System.Drawing.Point(1057, 175);
            this.boutonModifierDebit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.boutonModifierDebit.Name = "boutonModifierDebit";
            this.boutonModifierDebit.Size = new System.Drawing.Size(131, 31);
            this.boutonModifierDebit.TabIndex = 27;
            this.boutonModifierDebit.Text = "Modifier";
            this.boutonModifierDebit.UseVisualStyleBackColor = true;
            this.boutonModifierDebit.Click += new System.EventHandler(this.boutonModifierDebit_Click);
            // 
            // debits
            // 
            this.debits.AllowUserToResizeColumns = false;
            this.debits.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.debits.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.debits.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.debits.Location = new System.Drawing.Point(1237, 119);
            this.debits.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.debits.Name = "debits";
            this.debits.ReadOnly = true;
            this.debits.RowHeadersWidth = 51;
            this.debits.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.debits.RowTemplate.Height = 24;
            this.debits.Size = new System.Drawing.Size(740, 194);
            this.debits.TabIndex = 31;
            this.debits.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.debits_CellClick);
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(1239, 410);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(739, 279);
            this.dataGridView2.TabIndex = 32;
            // 
            // button11
            // 
            this.button11.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button11.Location = new System.Drawing.Point(1057, 554);
            this.button11.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(131, 31);
            this.button11.TabIndex = 35;
            this.button11.Text = "Modifier";
            this.button11.UseVisualStyleBackColor = true;
            // 
            // button12
            // 
            this.button12.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button12.Location = new System.Drawing.Point(1057, 607);
            this.button12.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(131, 31);
            this.button12.TabIndex = 34;
            this.button12.Text = "Ajouter";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // button13
            // 
            this.button13.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button13.Location = new System.Drawing.Point(1057, 658);
            this.button13.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(131, 31);
            this.button13.TabIndex = 33;
            this.button13.Text = "Supprimer";
            this.button13.UseVisualStyleBackColor = true;
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(520, 228);
            this.dataGridView3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersWidth = 51;
            this.dataGridView3.RowTemplate.Height = 24;
            this.dataGridView3.Size = new System.Drawing.Size(303, 208);
            this.dataGridView3.TabIndex = 36;
            // 
            // label7
            // 
            this.label7.AccessibleName = "";
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(516, 196);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 24);
            this.label7.TabIndex = 37;
            this.label7.Text = "Résultats";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AccessibleName = "";
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 196);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 24);
            this.label8.TabIndex = 38;
            this.label8.Text = "Filtre Élève";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Calibri Light", 10.2F);
            this.textBox2.Location = new System.Drawing.Point(16, 235);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(368, 28);
            this.textBox2.TabIndex = 39;
            // 
            // label9
            // 
            this.label9.AccessibleName = "";
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(11, 282);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 24);
            this.label9.TabIndex = 40;
            this.label9.Text = "Classe";
            // 
            // domainUpDown1
            // 
            this.domainUpDown1.Location = new System.Drawing.Point(111, 286);
            this.domainUpDown1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.domainUpDown1.Name = "domainUpDown1";
            this.domainUpDown1.Size = new System.Drawing.Size(147, 22);
            this.domainUpDown1.TabIndex = 41;
            this.domainUpDown1.Text = "Classe";
            // 
            // label10
            // 
            this.label10.AccessibleName = "";
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(12, 329);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(115, 24);
            this.label10.TabIndex = 42;
            this.label10.Text = "Prélèvement";
            // 
            // label11
            // 
            this.label11.AccessibleName = "";
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(12, 370);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(106, 24);
            this.label11.TabIndex = 43;
            this.label11.Text = "Autorisé    :";
            // 
            // label12
            // 
            this.label12.AccessibleName = "";
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(12, 410);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(106, 24);
            this.label12.TabIndex = 44;
            this.label12.Text = "Sweet pris :";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(151, 370);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(49, 21);
            this.checkBox1.TabIndex = 45;
            this.checkBox1.Text = "oui";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(213, 370);
            this.checkBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(54, 21);
            this.checkBox2.TabIndex = 46;
            this.checkBox2.Text = "non";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(151, 414);
            this.checkBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(49, 21);
            this.checkBox4.TabIndex = 48;
            this.checkBox4.Text = "oui";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(213, 415);
            this.checkBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(54, 21);
            this.checkBox3.TabIndex = 49;
            this.checkBox3.Text = "non";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AccessibleName = "";
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(11, 459);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(118, 24);
            this.label13.TabIndex = 50;
            this.label13.Text = "Informations";
            // 
            // login
            // 
            this.login.AutoSize = true;
            this.login.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login.Location = new System.Drawing.Point(12, 502);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(59, 24);
            this.login.TabIndex = 51;
            this.login.Text = "Nom :";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(11, 532);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(83, 24);
            this.label14.TabIndex = 52;
            this.label14.Text = "Prénom :";
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(11, 561);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(70, 24);
            this.label15.TabIndex = 53;
            this.label15.Text = "Classe :";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(11, 628);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(104, 24);
            this.label16.TabIndex = 54;
            this.label16.Text = "Sweet pris :";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(12, 658);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(198, 24);
            this.label17.TabIndex = 55;
            this.label17.Text = "Montant prélèvement :";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(11, 594);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(193, 24);
            this.label18.TabIndex = 56;
            this.label18.Text = "Prélèvement autorisé :";
            // 
            // dataGridView4
            // 
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.Type,
            this.dataGridViewTextBoxColumn10});
            this.dataGridView4.Location = new System.Drawing.Point(348, 502);
            this.dataGridView4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.RowHeadersWidth = 51;
            this.dataGridView4.RowTemplate.Height = 24;
            this.dataGridView4.Size = new System.Drawing.Size(628, 198);
            this.dataGridView4.TabIndex = 57;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "Date";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 125;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.HeaderText = "Libellé";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 125;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.HeaderText = "Montant";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Width = 75;
            // 
            // Type
            // 
            this.Type.HeaderText = "Type";
            this.Type.MinimumWidth = 6;
            this.Type.Name = "Type";
            this.Type.Width = 125;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.HeaderText = "Prélèvement éffectué ou non";
            this.dataGridViewTextBoxColumn10.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.Width = 125;
            // 
            // label19
            // 
            this.label19.AccessibleName = "";
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(344, 459);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(93, 24);
            this.label19.TabIndex = 58;
            this.label19.Text = "Flux élève";
            this.label19.Click += new System.EventHandler(this.label19_Click);
            // 
            // EPSError
            // 
            this.EPSError.AutoSize = true;
            this.EPSError.ForeColor = System.Drawing.Color.Red;
            this.EPSError.Location = new System.Drawing.Point(211, 16);
            this.EPSError.Name = "EPSError";
            this.EPSError.Size = new System.Drawing.Size(207, 17);
            this.EPSError.TabIndex = 59;
            this.EPSError.Text = "Veuillez saisir un nombre valide";
            this.EPSError.Visible = false;
            // 
            // ASError
            // 
            this.ASError.AutoSize = true;
            this.ASError.ForeColor = System.Drawing.Color.Red;
            this.ASError.Location = new System.Drawing.Point(211, 85);
            this.ASError.Name = "ASError";
            this.ASError.Size = new System.Drawing.Size(207, 17);
            this.ASError.TabIndex = 60;
            this.ASError.Text = "Veuillez saisir un nombre valide";
            this.ASError.Visible = false;
            // 
            // retour
            // 
            this.retour.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.retour.Location = new System.Drawing.Point(1017, 16);
            this.retour.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.retour.Name = "retour";
            this.retour.Size = new System.Drawing.Size(171, 63);
            this.retour.TabIndex = 24;
            this.retour.Text = "Retour";
            this.retour.UseVisualStyleBackColor = true;
            this.retour.Click += new System.EventHandler(this.retour_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1420, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 17);
            this.label3.TabIndex = 61;
            this.label3.Text = "Date";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1420, 375);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 17);
            this.label6.TabIndex = 62;
            this.label6.Text = "Date";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(1917, -198);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(49, 17);
            this.label20.TabIndex = 63;
            this.label20.Text = "Libelle";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(1559, 85);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(49, 17);
            this.label21.TabIndex = 64;
            this.label21.Text = "Libelle";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(1697, 85);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(59, 17);
            this.label22.TabIndex = 66;
            this.label22.Text = "Montant";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(1559, 375);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(49, 17);
            this.label23.TabIndex = 65;
            this.label23.Text = "Libelle";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(1697, 372);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(59, 17);
            this.label24.TabIndex = 67;
            this.label24.Text = "Montant";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(1828, 85);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(106, 17);
            this.label25.TabIndex = 68;
            this.label25.Text = "Budget impacté";
            this.label25.Click += new System.EventHandler(this.label25_Click);
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(1828, 375);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(106, 17);
            this.label26.TabIndex = 69;
            this.label26.Text = "Budget impacté";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(1235, 46);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(77, 29);
            this.label27.TabIndex = 70;
            this.label27.Text = "Débit";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.Location = new System.Drawing.Point(1235, 338);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(86, 29);
            this.label28.TabIndex = 71;
            this.label28.Text = "Crédit";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(1321, 85);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(19, 17);
            this.label29.TabIndex = 72;
            this.label29.Text = "Id";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(1321, 375);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(19, 17);
            this.label30.TabIndex = 73;
            this.label30.Text = "Id";
            // 
            // erreurDebit
            // 
            this.erreurDebit.AutoSize = true;
            this.erreurDebit.Font = new System.Drawing.Font("Calibri Light", 12F);
            this.erreurDebit.ForeColor = System.Drawing.Color.Red;
            this.erreurDebit.Location = new System.Drawing.Point(1467, 329);
            this.erreurDebit.Name = "erreurDebit";
            this.erreurDebit.Size = new System.Drawing.Size(247, 24);
            this.erreurDebit.TabIndex = 74;
            this.erreurDebit.Text = "Aucun débit n\'est séléctionné";
            this.erreurDebit.Visible = false;
            // 
            // successDebit
            // 
            this.successDebit.AutoSize = true;
            this.successDebit.Font = new System.Drawing.Font("Calibri Light", 12F);
            this.successDebit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.successDebit.Location = new System.Drawing.Point(973, 329);
            this.successDebit.Name = "successDebit";
            this.successDebit.Size = new System.Drawing.Size(235, 24);
            this.successDebit.TabIndex = 75;
            this.successDebit.Text = "le débit a bien été supprimé";
            this.successDebit.Visible = false;
            // 
            // Comptabilite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1920, 711);
            this.Controls.Add(this.successDebit);
            this.Controls.Add(this.erreurDebit);
            this.Controls.Add(this.label30);
            this.Controls.Add(this.label29);
            this.Controls.Add(this.label28);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ASError);
            this.Controls.Add(this.EPSError);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.dataGridView4);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.login);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox4);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.domainUpDown1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.debits);
            this.Controls.Add(this.boutonModifierDebit);
            this.Controls.Add(this.ajoutDebit);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.retour);
            this.Controls.Add(this.ASLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.modifAS);
            this.Controls.Add(this.ASChamp);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.EPSLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.modifEPS);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EPSChamp);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "Comptabilite";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Comptabilite";
            ((System.ComponentModel.ISupportInitialize)(this.debits)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox EPSChamp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button modifEPS;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label EPSLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ASChamp;
        private System.Windows.Forms.Button modifAS;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label ASLabel;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button ajoutDebit;
        private System.Windows.Forms.Button boutonModifierDebit;
        private System.Windows.Forms.DataGridView debits;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DomainUpDown domainUpDown1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label login;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label EPSError;
        private System.Windows.Forms.Label ASError;
        private System.Windows.Forms.Button retour;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label erreurDebit;
        public System.Windows.Forms.Label successDebit;
    }
}