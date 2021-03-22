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
    public partial class AjoutEleve : Form
    {
        private string prelevementEleveAutorise = "null";

        public AjoutEleve()
        {
            InitializeComponent();
        }

        private void AjoutEleve_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'gestionAssociationSportiveDataSet.CLASSE'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.cLASSETableAdapter.Fill(this.gestionAssociationSportiveDataSet.CLASSE);
        }

        private void annuler_Click(object sender, EventArgs e)
        {
            Administration administration = new Administration();
            administration.Show();
            this.Close();
        }
        private void oui_CheckedChanged(object sender, EventArgs e)
        {
            prelevementEleveAutorise = "1";
        }
        private void non_CheckedChanged(object sender, EventArgs e)
        {
            prelevementEleveAutorise = "0";
        }

        private void ajouter_Click(object sender, EventArgs e)
        {
            // vérification que les champs ne sont pas vides
            if(ajoutLoginChamp.Text == string.Empty || ajoutMotDePasseChamp.Text == string.Empty || ajoutNomChamp.Text == string.Empty || ajoutPrenomChamp.Text == string.Empty || ajoutDateDeNaissanceChamp.Text == string.Empty || ajoutSexeChamp.Text == string.Empty || ajoutEmailChamp.Text == string.Empty || ajoutTelephoneChamp.Text == string.Empty || ajoutTelephoneTuteurChamp.Text == string.Empty || prelevementEleveAutorise == "null")
            {
                erreurChampsVides.Visible = true;
            }

            // si ils ne sont pas vides
            else
            {
                erreurChampsVides.Visible = false;

                // vérification de l'existence du login
                if (!Gestion.ExisteAdherent(ajoutLoginChamp.Text))
                {
                    // Ajout de l'élève
                    if (erreurChampsVides.Visible == false)
                    {
                        int idClasse = Gestion.GetIdClasseAdherent(classeChamp.Text);

                        Adherent adherent = new Adherent(ajoutNomChamp.Text, ajoutPrenomChamp.Text, Convert.ToDateTime(ajoutDateDeNaissanceChamp.Text), ajoutTelephoneChamp.Text, ajoutEmailChamp.Text, ajoutTelephoneTuteurChamp.Text, Convert.ToInt32(prelevementEleveAutorise), ajoutSexeChamp.Text, ajoutLoginChamp.Text, ajoutMotDePasseChamp.Text, idClasse);

                        Gestion.AddAdherent(adherent);

                        existe.Visible = false;
                        success.Visible = true;
                    }
                }

                else
                {
                    success.Visible = false;
                    existe.Visible = true;
                }
            }
        }
    }
}
