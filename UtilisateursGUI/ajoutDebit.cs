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
    public partial class AjoutDebit : Form
    {
        private string prelevementEffectueOuiNon = "null";
        private int typeFlux = 1;
        public AjoutDebit()
        {
            InitializeComponent();
        }

        private void ajoutDebit_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'gestionAssociationSportiveDataSet.BUDGET'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.bUDGETTableAdapter.Fill(this.gestionAssociationSportiveDataSet.BUDGET);
            // TODO: cette ligne de code charge les données dans la table 'gestionAssociationSportiveDataSet.EVENEMENT'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.eVENEMENTTableAdapter.Fill(this.gestionAssociationSportiveDataSet.EVENEMENT);
            // TODO: cette ligne de code charge les données dans la table 'gestionAssociationSportiveDataSet.ADHERENT'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.aDHERENTTableAdapter.Fill(this.gestionAssociationSportiveDataSet.ADHERENT);
        }
        private void oui_CheckedChanged(object sender, EventArgs e)
        {
            prelevementEffectueOuiNon = "1";
        }

        private void non_CheckedChanged(object sender, EventArgs e)
        {
            prelevementEffectueOuiNon = "2";
        }

        private void ajouter_Click(object sender, EventArgs e)
        {
            // vérification que les champs ne sont pas vides
            if (ajoutNomDebitChamp.Text == string.Empty || ajoutDateDebitChamp.Text == string.Empty ||ajoutMontantDebitChamp.Text == string.Empty || prelevementEffectueOuiNon == "null" || ajoutIdAdherentChamp.Text == string.Empty || ajoutIdEvenementChamp.Text == string.Empty|| ajoutBudgetChamp.Text == string.Empty || !Int32.TryParse(ajoutMontantDebitChamp.Text, out int number))
            {
                erreurChampsVides.Visible = true;
            }
            else
            {
                erreurChampsVides.Visible = false;

                Flux flux = new Flux(ajoutNomDebitChamp.Text, Convert.ToDateTime(ajoutDateDebitChamp.Text),float.Parse(ajoutMontantDebitChamp.Text), Convert.ToInt32(prelevementEffectueOuiNon), Convert.ToInt32(ajoutIdAdherentChamp.SelectedValue.ToString()), typeFlux ,Convert.ToInt32(ajoutIdEvenementChamp.SelectedValue.ToString()), Convert.ToInt32(ajoutBudgetChamp.SelectedValue.ToString()));

                Gestion.AddFlux(flux);

                success.Visible = true;
            }
            
        }

        private void annuler_Click(object sender, EventArgs e)
        {
            Comptabilite comptabilite = new Comptabilite();
            comptabilite.Show();
            this.Close();
        }
    }
}
