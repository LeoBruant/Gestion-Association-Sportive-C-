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
    public partial class ModificationDebit : Form
    {
        private string prelevementEffectueOuiNon;
        public ModificationDebit()
        {
            InitializeComponent();
        }

        private void annuler_Click(object sender, EventArgs e)
        {
            Comptabilite comptabilite = new Comptabilite();
            comptabilite.Show();
            this.Close();
        }

        private void ModificationDebit_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'gestionAssociationSportiveDataSet.ADHERENT'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.aDHERENTTableAdapter.Fill(this.gestionAssociationSportiveDataSet.ADHERENT);
            // TODO: cette ligne de code charge les données dans la table 'gestionAssociationSportiveDataSet.EVENEMENT'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.eVENEMENTTableAdapter.Fill(this.gestionAssociationSportiveDataSet.EVENEMENT);
            // TODO: cette ligne de code charge les données dans la table 'gestionAssociationSportiveDataSet.BUDGET'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.bUDGETTableAdapter.Fill(this.gestionAssociationSportiveDataSet.BUDGET);

        }
        private void oui_CheckedChanged(object sender, EventArgs e)
        {
            prelevementEffectueOuiNon = "1";
        }
        private void non_CheckedChanged(object sender, EventArgs e)
        {
            prelevementEffectueOuiNon = "2";
        }
        private void modifier_Click(object sender, EventArgs e)
        {
            Flux flux = Gestion.GetUnFlux(Convert.ToInt32(id.Text));
            var error = false;

            if (modificationNomDebitChamp.Text != "")
            {
                flux.Libelle = modificationNomDebitChamp.Text;
            }

            if (modificationDateDebitChamp.Text != "")
            {
                flux.DateFlux = Convert.ToDateTime(modificationDateDebitChamp.Text);
            }

            if (modificationMontantDebitChamp.Text != "" && Int32.TryParse(modificationMontantDebitChamp.Text, out int number))
            {
                flux.MontantFlux = Convert.ToInt32(modificationMontantDebitChamp.Text);
            }
            else
            {
                error = true;
            }

            if (prelevementEffectueOuiNon !="null")
            {
                flux.PrelevementEff = Convert.ToInt32(prelevementEffectueOuiNon);
            }

            if (modificationIdAdherentChamp.Text != "")
            {
                flux.IdAdherent = Convert.ToInt32(modificationIdAdherentChamp.SelectedValue.ToString());
            }

            if (modificationIdEvenementChamp.Text != "")
            {
                flux.IdEvenement = Convert.ToInt32(modificationIdEvenementChamp.SelectedValue.ToString());
            }

            if (modificationBudgetChamp.Text != "")
            {
                flux.IdBudget = Convert.ToInt32(modificationBudgetChamp.SelectedValue.ToString());
            }

            if (!error)
            {
                Gestion.ModifFlux(flux);
                success.Visible = true;
            }
        }
    }
}
