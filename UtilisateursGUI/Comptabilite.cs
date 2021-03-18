using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UtilisateursBLL;
using UtilisateursBO;

namespace UtilisateursGUI
{
    public partial class Comptabilite : Form
    {
        private static int rowId;
        public Comptabilite()
        {
            InitializeComponent();

            // Blocage de la génération automatique des colonnes
            debits.AutoGenerateColumns = false;

            // Création d'une en-tête de colonne pour la colonne 1
            DataGridViewTextBoxColumn IdColumn = new DataGridViewTextBoxColumn();
            IdColumn.DataPropertyName = "Id";
            IdColumn.HeaderText = "id";

            // Création d'une en-tête de colonne pour la colonne 2
            DataGridViewTextBoxColumn DateColumn = new DataGridViewTextBoxColumn();
            DateColumn.DataPropertyName = "DateFlux";
            DateColumn.HeaderText = "dateFlux";

            // Création d'une en-tête de colonne pour la colonne 3
            DataGridViewTextBoxColumn LibelleColumn = new DataGridViewTextBoxColumn();
            LibelleColumn.DataPropertyName = "Libelle";
            LibelleColumn.HeaderText = "libele";

            // Création d'une en-tête de colonne pour la colonne 4
            DataGridViewTextBoxColumn MontantColumn = new DataGridViewTextBoxColumn();
            MontantColumn.DataPropertyName = "MontantFlux";
            MontantColumn.HeaderText = "montantFlux";

            // Création d'une en-tête de colonne pour la colonne 5
            DataGridViewTextBoxColumn BudgetColumn = new DataGridViewTextBoxColumn();
            BudgetColumn.DataPropertyName = "LibelleBudget";
            BudgetColumn.HeaderText = "libelleBudget";

            // Ajout des 2 en-têtes de colonne au datagridview
            debits.Columns.Add(IdColumn);
            debits.Columns.Add(DateColumn);
            debits.Columns.Add(LibelleColumn);
            debits.Columns.Add(MontantColumn);
            debits.Columns.Add(BudgetColumn);

            // Définition du style apporté au datagridview
            debits.ColumnHeadersVisible = false;
            IdColumn.Width = 50;
            DateColumn.Width = 110;
            LibelleColumn.Width = 110;
            MontantColumn.Width = 110;
            BudgetColumn.Width = 110;

            var lesdebits = new List<Flux>();
            lesdebits = Gestion.GetDebits();
            debits.DataSource = lesdebits;

            float budgetEPS = Gestion.GetBudgetEPS();
            float budgetAS = Gestion.GetBudgetAS();

            EPSLabel.Text = budgetEPS.ToString() + '€';
            ASLabel.Text = budgetAS.ToString() + '€';
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Connexion connexion = new Connexion();
            connexion.Show();

            this.Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void modifEPS_Click(object sender, EventArgs e)
        {
            if (Int32.TryParse(EPSChamp.Text, out int number))
            {
                Gestion.ModifBudgetEPS(float.Parse(EPSChamp.Text));
                float budgetEPS = Gestion.GetBudgetEPS();
                EPSLabel.Text = budgetEPS.ToString() + '€';

                EPSError.Visible = false;
                EPSChamp.Text = "";
            }

            else
            {
                EPSError.Visible = true;
                EPSChamp.Text = "";
            }
        }

        private void modifAS_Click(object sender, EventArgs e)
        {
            if (Int32.TryParse(ASChamp.Text, out int number))
            {
                Gestion.ModifBudgetAS(float.Parse(ASChamp.Text));
                float budgetEPS = Gestion.GetBudgetAS();
                ASLabel.Text = budgetEPS.ToString() + '€';

                ASError.Visible = false;
                ASChamp.Text = "";
            }

            else
            {
                ASError.Visible = true;
                ASChamp.Text = "";
            }
        }

        private void retour_Click(object sender, EventArgs e)
        {
            ChoixAdmin choixAdmin = new ChoixAdmin();
            choixAdmin.Show();

            this.Close();
        }

        private void ajoutDebit_Click(object sender, EventArgs e)
        {
            AjoutDebit ajoutDebit = new AjoutDebit();
            ajoutDebit.Show();

            this.Close();
        }

        private void label25_Click(object sender, EventArgs e)
        {

        }

        private void boutonModifierDebit_Click(object sender, EventArgs e)
        {
            if (rowId != 0)
            {
                ModificationDebit modifierDebit = new ModificationDebit();

                modifierDebit.id.Text = rowId.ToString();

                modifierDebit.Show();

                this.Close();
            }

            else
            {
                erreurDebit.Visible = true;
            }
        }

        private void debits_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            erreurDebit.Visible = false;
            successDebit.Visible = false;

            int id = Convert.ToInt32(debits.Rows[e.RowIndex].Cells[0].Value);

            rowId = id;

            Flux flux = Gestion.GetUnFlux(id);

        }

        private void button12_Click(object sender, EventArgs e)
        {
            AjoutCredit ajoutCredit = new AjoutCredit();
            ajoutCredit.Show();

            this.Close();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (rowId != 0)
            {
                ModificationCredit modifierCredit = new ModificationCredit();

                modifierCredit.id.Text = rowId.ToString();

                modifierCredit.Show();

                this.Close();
            }

            else
            {
                erreurCredit.Visible = true;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // si une ligne a été selectionnée
            if (rowId != 0)
            {
                string message = "Vouslez-vous vraiment supprimer ce débit ?";
                string caption = "Suppression du débit";

                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result;

                // Affichage de la boîte de dialogue
                result = MessageBox.Show(message, caption, buttons);

                if (result == DialogResult.Yes)
                {
                    Gestion.SupprimeFlux(rowId);

                    Comptabilite comptabilite = new Comptabilite();
                    comptabilite.successDebit.Visible = true;
                    comptabilite.Show();

                    rowId = 0;

                    this.Close();
                }
            }

            else
            {
                erreurDebit.Visible = true;
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            // si une ligne a été selectionnée
            if (rowId != 0)
            {
                string message = "Vouslez-vous vraiment supprimer ce crédit ?";
                string caption = "Suppression du crédit";

                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result;

                // Affichage de la boîte de dialogue
                result = MessageBox.Show(message, caption, buttons);

                if (result == DialogResult.Yes)
                {
                    Gestion.SupprimeFlux(rowId);

                    Comptabilite comptabilite = new Comptabilite();
                    comptabilite.successDebit.Visible = true;
                    comptabilite.Show();

                    rowId = 0;

                    this.Close();
                }
            }

            else
            {
                erreurDebit.Visible = true;
            }
        }
    }
}
