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
    public partial class ModificationEleve : Form
    {
        private string prelevementEleveAutorise = "null";
        private string estArchive = "null";
        public ModificationEleve()
        {
            InitializeComponent();
        }

        private void annuler_Click(object sender, EventArgs e)
        {
            Administration administration = new Administration();
            administration.Show();
            this.Close();
        }

        private void modifier_Click(object sender, EventArgs e)
        {
            Adherent adherent = GestionUtilisateurs.GetUnAdherent(Convert.ToInt32(id.Text));

            if (modificationLoginChamp.Text != "")
            {
                adherent.Login = modificationLoginChamp.Text;
            }

            if (modificationNomChamp.Text != "")
            {
                adherent.Nom = modificationNomChamp.Text;
            }

            if (modificationPrenomChamp.Text != "")
            {
                adherent.Prenom = modificationPrenomChamp.Text;
            }

            if (modificationDateDeNaissanceChamp.Text != "")
            {
                adherent.DateNaissance = Convert.ToDateTime(modificationDateDeNaissanceChamp.Text);
            }

            if (modificationSexeChamp.Text != "")
            {
                adherent.Sexe = modificationSexeChamp.Text;
            }

            if (modificationEmailChamp.Text != "")
            {
                adherent.Email = modificationEmailChamp.Text;
            }

            if (modificationTelephoneChamp.Text != "")
            {
                adherent.NumTel = modificationTelephoneChamp.Text;
            }

            if (modificationTelephoneTuteurChamp.Text != "")
            {
                adherent.NumParent = modificationTelephoneTuteurChamp.Text;
            }

            if (prelevementEleveAutorise != "null")
            {
                adherent.AutorisePrelev = Convert.ToInt32(prelevementEleveAutorise);
            }

            if (modificationClasseChamp.Text != "")
            {
                adherent.Classe = GestionUtilisateurs.GetIdClasseAdherent(modificationClasseChamp.Text);
            }

            if (estArchive != "null")
            {
                adherent.EstArchive = Convert.ToInt32(estArchive);
            }

            GestionUtilisateurs.ModifAdherent(adherent);

            string LibelleClasse = GestionUtilisateurs.GetLibelleClasseAdherent(adherent.Classe);

            dt_id.Text = adherent.Id.ToString();
            dt_login.Text = adherent.Login;
            dt_nom.Text = adherent.Nom;
            dt_prenom.Text = adherent.Prenom;
            dt_ddn.Text = adherent.DateNaissance.ToString();
            dt_sexe.Text = adherent.Sexe;
            dt_email.Text = adherent.Email;
            dt_tel.Text = adherent.NumTel;
            dt_tel_tuteur.Text = adherent.NumParent;

            if (adherent.AutorisePrelev == 0)
            {
                dt_aut_prelev.Text = "non";
            }
            else
            {
                dt_aut_prelev.Text = "oui";
            }

            dt_classe.Text = LibelleClasse;

            if (adherent.EstArchive == 0)
            {
                dt_archive.Text = "non";
            }
            else
            {
                dt_archive.Text = "oui";
            }

            dt_dern_modif.Text = adherent.DateMaj.ToString();

            success.Visible = true;
        }

        private void oui_prelev_CheckedChanged(object sender, EventArgs e)
        {
            prelevementEleveAutorise = "1";
        }

        private void non_prelev_CheckedChanged(object sender, EventArgs e)
        {
            prelevementEleveAutorise = "0";
        }

        private void oui_archive_CheckedChanged(object sender, EventArgs e)
        {
            estArchive = "1";
        }

        private void non_archive_CheckedChanged(object sender, EventArgs e)
        {
            estArchive = "0";
        }

        private void ModificationEleve_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'gestionAssociationSportiveDataSet.CLASSE'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.cLASSETableAdapter.Fill(this.gestionAssociationSportiveDataSet.CLASSE);

            Adherent adherent = GestionUtilisateurs.GetUnAdherent(Convert.ToInt32(id.Text));

            string LibelleClasse = GestionUtilisateurs.GetLibelleClasseAdherent(adherent.Classe);

            dt_id.Text = adherent.Id.ToString();
            dt_login.Text = adherent.Login;
            dt_nom.Text = adherent.Nom;
            dt_prenom.Text = adherent.Prenom;
            dt_ddn.Text = adherent.DateNaissance.ToString();
            dt_sexe.Text = adherent.Sexe;
            dt_email.Text = adherent.Email;
            dt_tel.Text = adherent.NumTel;
            dt_tel_tuteur.Text = adherent.NumParent;

            if (adherent.AutorisePrelev == 0)
            {
                dt_aut_prelev.Text = "non";
            }
            else
            {
                dt_aut_prelev.Text = "oui";
            }

            dt_classe.Text = LibelleClasse;

            if (adherent.EstArchive == 0)
            {
                dt_archive.Text = "non";
            }
            else
            {
                dt_archive.Text = "oui";
            }

            dt_dern_modif.Text = adherent.DateMaj.ToString();

            success.Visible = false;
        }
    }
}
