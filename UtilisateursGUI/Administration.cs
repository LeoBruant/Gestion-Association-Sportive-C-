using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UtilisateursBLL;
using UtilisateursBO;

namespace UtilisateursGUI
{
    public partial class Administration : Form
    {
        private static int rowId;
        public Administration()
        {
            InitializeComponent();

            // Blocage de la génération automatique des colonnes
            adherents.AutoGenerateColumns = false;
            
            // Création d'une en-tête de colonne pour la colonne 1
            DataGridViewTextBoxColumn IdColumn = new DataGridViewTextBoxColumn();
            IdColumn.DataPropertyName = "Id";
            IdColumn.HeaderText = "id";
            
            // Création d'une en-tête de colonne pour la colonne 2
            DataGridViewTextBoxColumn NomColumn = new DataGridViewTextBoxColumn();
            NomColumn.DataPropertyName = "Nom";
            NomColumn.HeaderText = "nom";

            // Création d'une en-tête de colonne pour la colonne 3
            DataGridViewTextBoxColumn PrenomColumn = new DataGridViewTextBoxColumn();
            PrenomColumn.DataPropertyName = "Prenom";
            PrenomColumn.HeaderText = "prenom";

            // Ajout des 2 en-têtes de colonne au datagridview
            adherents.Columns.Add(IdColumn);
            adherents.Columns.Add(NomColumn);
            adherents.Columns.Add(PrenomColumn);

            // Définition du style apporté au datagridview
            adherents.ColumnHeadersVisible = false;
            IdColumn.Width = 140;
            NomColumn.Width = 140;
            PrenomColumn.Width = 140;

            var lesAdherents = new List<Adherent>();

            lesAdherents = GestionUtilisateurs.GetAdherents();

            adherents.DataSource = lesAdherents;
        }

        internal static void Open()
        {
            throw new NotImplementedException();
        }

        private void Ajouter_Click(object sender, EventArgs e)
        {
            AjoutEleve ajoutEleve = new AjoutEleve();
            ajoutEleve.Show();

            this.Close();
        }

        private void administrateur_Load(object sender, EventArgs e)
        {
            
        }

        private void Supprimer_Click(object sender, EventArgs e)
        {
            // si une ligne a été selectionnée
            if (rowId != 0)
            {
                string message = "Vouslez-vous vraiment supprimer cet adhérent ?";
                string caption = "Suppression d'adhérent";

                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result;

                // Affichage de la boîte de dialogue
                result = MessageBox.Show(message, caption, buttons);

                if (result == DialogResult.Yes)
                {
                    GestionUtilisateurs.SupprimeAdherent(rowId);

                    Administration administration = new Administration();
                    administration.success.Visible = true;
                    administration.Show();

                    rowId = 0;

                    this.Close();
                }
            }

            else
            {
                erreur.Visible = true;
            }
        }

        private void Retour_Click(object sender, EventArgs e)
        {
            ChoixAdmin choixAdmin = new ChoixAdmin();
            choixAdmin.Show();

            this.Close();
        }

        private void Modifier_Click(object sender, EventArgs e)
        {
            if (rowId != 0)
            {
                ModificationEleve modifierAdherent = new ModificationEleve();

                modifierAdherent.id.Text = rowId.ToString();

                modifierAdherent.Show();

                this.Close();
            }

            else
            {
                erreur.Visible = true;
            }
        }

        private void Deconnexion_click(object sender, EventArgs e)
        {
            Connexion connexion = new Connexion();
            connexion.Show();

            this.Close();
        }

        private void adherents_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            erreur.Visible = false;
            success.Visible = false;

            int id = Convert.ToInt32(adherents.Rows[e.RowIndex].Cells[0].Value);

            rowId = id;

            Adherent adherent = GestionUtilisateurs.GetUnAdherent(id);

            dt_id.Text = adherent.Id.ToString();
            dt_id.Visible = true;

            dt_login.Text = adherent.Login;
            dt_login.Visible = true;

            dt_nom.Text = adherent.Nom;
            dt_nom.Visible = true;

            dt_prenom.Text = adherent.Prenom;
            dt_prenom.Visible = true;

            dt_ddn.Text = adherent.DateNaissance.ToString();
            dt_ddn.Visible = true;

            dt_sexe.Text = adherent.Sexe;
            dt_sexe.Visible = true;

            dt_email.Text = adherent.Email;
            dt_email.Visible = true;

            dt_tel.Text = adherent.NumTel;
            dt_tel.Visible = true;

            dt_tel_tuteur.Text = adherent.NumParent;
            dt_tel_tuteur.Visible = true;

            dt_dern_modif.Text = adherent.DateMaj.ToString();
            dt_dern_modif.Visible = true;

            if (adherent.EstArchive == 1)
            {
                dt_archive.Text = "oui";
            }
            else
            {
                dt_archive.Text = "non";
            }
            dt_archive.Visible = true;

            if (adherent.AutorisePrelev == 1)
            {
                dt_aut_prelev.Text = "oui";
            }
            else
            {
                dt_aut_prelev.Text = "non";
            }
            dt_aut_prelev.Visible = true;

            dt_classe.Text = GestionUtilisateurs.GetLibelleClasseAdherent(adherent.Classe);
            dt_classe.Visible = true;
        }
    }
}
