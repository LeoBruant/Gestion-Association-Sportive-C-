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
        private static int rowIdDebit;
        private static int rowIdCredit;
        int autorise = 2;
        int sweat = 2;

        public Comptabilite()
        {
            InitializeComponent();

            // Tableau des debits //

                // Blocage de la génération automatique des colonnes
                debits.AutoGenerateColumns = false;

                // Création d'une en-tête de colonne pour la colonne 1
                DataGridViewTextBoxColumn IdColumnDebit = new DataGridViewTextBoxColumn();
                IdColumnDebit.DataPropertyName = "Id";
                IdColumnDebit.HeaderText = "id";

                // Création d'une en-tête de colonne pour la colonne 2
                DataGridViewTextBoxColumn DateColumnDebit = new DataGridViewTextBoxColumn();
                DateColumnDebit.DataPropertyName = "DateFlux";
                DateColumnDebit.HeaderText = "dateFlux";

                // Création d'une en-tête de colonne pour la colonne 3
                DataGridViewTextBoxColumn LibelleColumnDebit = new DataGridViewTextBoxColumn();
                LibelleColumnDebit.DataPropertyName = "Libelle";
                LibelleColumnDebit.HeaderText = "libele";

                // Création d'une en-tête de colonne pour la colonne 4
                DataGridViewTextBoxColumn MontantColumnDebit = new DataGridViewTextBoxColumn();
                MontantColumnDebit.DataPropertyName = "MontantFlux";
                MontantColumnDebit.HeaderText = "montantFlux";

                // Création d'une en-tête de colonne pour la colonne 5
                DataGridViewTextBoxColumn BudgetColumnDebit = new DataGridViewTextBoxColumn();
                BudgetColumnDebit.DataPropertyName = "LibelleBudget";
                BudgetColumnDebit.HeaderText = "libelleBudget";

            // Tableau des credits //

                // Blocage de la génération automatique des colonnes
                credits.AutoGenerateColumns = false;

                // Création d'une en-tête de colonne pour la colonne 1
                DataGridViewTextBoxColumn IdColumnCredit = new DataGridViewTextBoxColumn();
                IdColumnCredit.DataPropertyName = "Id";
                IdColumnCredit.HeaderText = "id";

                // Création d'une en-tête de colonne pour la colonne 2
                DataGridViewTextBoxColumn DateColumnCredit = new DataGridViewTextBoxColumn();
                DateColumnCredit.DataPropertyName = "DateFlux";
                DateColumnCredit.HeaderText = "dateFlux";

                // Création d'une en-tête de colonne pour la colonne 3
                DataGridViewTextBoxColumn LibelleColumnCredit = new DataGridViewTextBoxColumn();
                LibelleColumnCredit.DataPropertyName = "Libelle";
                LibelleColumnCredit.HeaderText = "libele";

                // Création d'une en-tête de colonne pour la colonne 4
                DataGridViewTextBoxColumn MontantColumnCredit = new DataGridViewTextBoxColumn();
                MontantColumnCredit.DataPropertyName = "MontantFlux";
                MontantColumnCredit.HeaderText = "montantFlux";

                // Création d'une en-tête de colonne pour la colonne 5
                DataGridViewTextBoxColumn BudgetColumnCredit = new DataGridViewTextBoxColumn();
                BudgetColumnCredit.DataPropertyName = "LibelleBudget";
                BudgetColumnCredit.HeaderText = "libelleBudget";

            // Tableau des resultats

                // Blocage de la génération automatique des colonnes
                resultats.AutoGenerateColumns = false;

                // Création d'une en-tête de colonne pour la colonne 1
                DataGridViewTextBoxColumn NomEleve = new DataGridViewTextBoxColumn();
                IdColumnCredit.DataPropertyName = "Nom";
                IdColumnCredit.HeaderText = "nom";

                // Création d'une en-tête de colonne pour la colonne 2
                DataGridViewTextBoxColumn PrenomEleve = new DataGridViewTextBoxColumn();
                DateColumnCredit.DataPropertyName = "Prenom";
                DateColumnCredit.HeaderText = "prenom";

            // Ajout des en-têtes de colonne pour les débits
            debits.Columns.Add(IdColumnDebit);
            debits.Columns.Add(DateColumnDebit);
            debits.Columns.Add(LibelleColumnDebit);
            debits.Columns.Add(MontantColumnDebit);
            debits.Columns.Add(BudgetColumnDebit);

            // Ajout des en-têtes de colonne pour les crédits
            credits.Columns.Add(IdColumnCredit);
            credits.Columns.Add(DateColumnCredit);
            credits.Columns.Add(LibelleColumnCredit);
            credits.Columns.Add(MontantColumnCredit);
            credits.Columns.Add(BudgetColumnCredit);

            // Ajout des en-têtes de colonne pour les resultats
            resultats.Columns.Add(NomEleve);
            resultats.Columns.Add(PrenomEleve);

            // Définition du style apporté au datagridview des debits
            debits.ColumnHeadersVisible = false;
            IdColumnDebit.Width = 50;
            DateColumnDebit.Width = 110;
            LibelleColumnDebit.Width = 110;
            MontantColumnDebit.Width = 110;
            BudgetColumnDebit.Width = 110;

            // Définition du style apporté au datagridview des credits
            credits.ColumnHeadersVisible = false;
            IdColumnCredit.Width = 50;
            DateColumnCredit.Width = 110;
            LibelleColumnCredit.Width = 110;
            MontantColumnCredit.Width = 110;
            BudgetColumnCredit.Width = 110;

            // Définition du style apporté au datagridview des resultats
            resultats.ColumnHeadersVisible = false;
            NomEleve.Width = 190;
            PrenomEleve.Width = 190;

            // Récupération des débits
            var lesDebits = new List<Flux>();
            lesDebits = Gestion.GetDebits();
            debits.DataSource = lesDebits;

            // Récupération des crédits
            var lesCredits = new List<Flux>();
            lesCredits = Gestion.GetCredits();
            credits.DataSource = lesCredits;

            // Récupération des budgets
            Gestion.CalculerBudgetAS();
            Gestion.CalculerBudgetEPS();
            float budgetEPS = Gestion.CalculerBudgetEPS();
            float budgetAS = Gestion.CalculerBudgetAS();

            EPSLabel.Text = budgetEPS.ToString() + '€';
            ASLabel.Text = budgetAS.ToString() + '€';
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Connexion connexion = new Connexion();
            connexion.Show();

            this.Close();
        }

        private void modifEPS_Click(object sender, EventArgs e)
        {
            if (Int32.TryParse(EPSChamp.Text, out int number))
            {
                Gestion.ModifBudgetEPS(float.Parse(EPSChamp.Text));
                Gestion.CalculerBudgetEPS();
                float budgetEPS = Gestion.CalculerBudgetEPS();
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
                Gestion.CalculerBudgetAS();
                float budgetEPS = Gestion.CalculerBudgetAS();
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

        private void boutonModifierDebit_Click(object sender, EventArgs e)
        {
            if (rowIdDebit != 0)
            {
                ModificationDebit modifierDebit = new ModificationDebit();

                modifierDebit.id.Text = rowIdDebit.ToString();

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

            rowIdDebit = id;

            Flux flux = Gestion.GetUnFlux(id);

        }

        private void credits_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            erreurCredit.Visible = false;
            successCredit.Visible = false;

            int id = Convert.ToInt32(credits.Rows[e.RowIndex].Cells[0].Value);

            rowIdCredit = id;

            Flux flux = Gestion.GetUnFlux(id);
        }

        private void SupprimerDebit_Click(object sender, EventArgs e)
        {
            // si une ligne a été selectionnée
            if (rowIdDebit != 0)
            {
                string message = "Vouslez-vous vraiment supprimer ce débit ?";
                string caption = "Suppression du débit";

                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result;

                // Affichage de la boîte de dialogue
                result = MessageBox.Show(message, caption, buttons);

                if (result == DialogResult.Yes)
                {
                    Gestion.SupprimeFlux(rowIdDebit);

                    Comptabilite comptabilite = new Comptabilite();
                    comptabilite.successDebit.Visible = true;
                    comptabilite.Show();

                    rowIdDebit = 0;

                    this.Close();
                }
            }

            else
            {
                erreurDebit.Visible = true;
            }
        }

        private void ModifCredit_Click(object sender, EventArgs e)
        {
            if (rowIdCredit != 0)
            {
                ModificationCredit modifierCredit = new ModificationCredit();
                modifierCredit.id.Text = rowIdCredit.ToString();
                modifierCredit.Show();
                this.Close();
            }

            else
            {
                erreurCredit.Visible = true;
            }
        }

        private void AjoutCredit_Click(object sender, EventArgs e)
        {
            AjoutCredit ajoutCredit = new AjoutCredit();
            ajoutCredit.Show();

            this.Close();
        }

        private void SupprimerCredit_Click(object sender, EventArgs e)
        {
            // si une ligne a été selectionnée
            if (rowIdCredit != 0)
            {
                string message = "Voulez-vous vraiment supprimer ce crédit ?";
                string caption = "Suppression du crédit";

                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result;

                // Affichage de la boîte de dialogue
                result = MessageBox.Show(message, caption, buttons);

                if (result == DialogResult.Yes)
                {
                    Gestion.SupprimeFlux(rowIdCredit);

                    Comptabilite comptabilite = new Comptabilite();
                    comptabilite.successCredit.Visible = true;
                    comptabilite.Show();

                    rowIdCredit = 0;

                    this.Close();
                }
            }

            else
            {
                erreurCredit.Visible = true;
            }
        }

        private void Comptabilite_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'gestionAssociationSportiveDataSet.CLASSE'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.cLASSETableAdapter.Fill(this.gestionAssociationSportiveDataSet.CLASSE);

        }

        private void nonAutorise_CheckedChanged(object sender, EventArgs e)
        {
            autorise = 0;
        }

        private void ouiAutorise_CheckedChanged(object sender, EventArgs e)
        {
            autorise = 1;
        }

        private void nonSweat_CheckedChanged(object sender, EventArgs e)
        {
            sweat = 0;
        }

        private void ouiSweat_CheckedChanged(object sender, EventArgs e)
        {
            sweat = 1;
        }

        private void validerFiltre_Click(object sender, EventArgs e)
        {
            int classeId = -1;

            if (classe.SelectedValue.ToString() != "")
            {
                classeId = Convert.ToInt32(classe.SelectedValue.ToString());
            }
            
            string eleveTexte = eleve.Text;

            List<Adherent> adherents = Gestion.getAdherentsFiltres(classeId, eleveTexte, autorise, sweat);

            resultats.DataSource = adherents;
        }
    }
}
