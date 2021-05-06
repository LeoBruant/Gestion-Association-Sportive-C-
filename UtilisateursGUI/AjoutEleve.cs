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
        private string prendSweat = "null";

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
        private void ouiSweat_CheckedChanged(object sender, EventArgs e)
        {
            prendSweat = "1";
        }

        private void nonSweat_CheckedChanged(object sender, EventArgs e)
        {
            prendSweat = "0";
        }

        private void ajouter_Click(object sender, EventArgs e)
        {
            // vérification que les champs ne sont pas vides
            if(ajoutLoginChamp.Text == string.Empty || ajoutMotDePasseChamp.Text == string.Empty || ajoutNomChamp.Text == string.Empty || ajoutPrenomChamp.Text == string.Empty || ajoutDateDeNaissanceChamp.Text == string.Empty || ajoutSexeChamp.Text == string.Empty || ajoutEmailChamp.Text == string.Empty || ajoutTelephoneChamp.Text == string.Empty || ajoutTelephoneTuteurChamp.Text == string.Empty || prelevementEleveAutorise == "null" || prendSweat == "null")
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

                        Adherent adherent = new Adherent(ajoutNomChamp.Text, ajoutPrenomChamp.Text, Convert.ToDateTime(ajoutDateDeNaissanceChamp.Text), ajoutTelephoneChamp.Text, ajoutEmailChamp.Text, ajoutTelephoneTuteurChamp.Text, Convert.ToInt32(prelevementEleveAutorise),Convert.ToInt32(prendSweat), ajoutSexeChamp.Text, ajoutLoginChamp.Text, ajoutMotDePasseChamp.Text, idClasse);

                        Gestion.AddAdherent(adherent);

                        existe.Visible = false;
                        success.Visible = true;

                        if (prendSweat == "0")
                        {
                            if (prelevementEleveAutorise == "0")
                            {
                                Flux flux = new Flux("Adhesion", DateTime.Now, 10, 0, Gestion.GetDernierIdAdherent(), 2, 1);
                                Gestion.AddFluxInscription(flux);
                            }
                            if (prelevementEleveAutorise == "1")
                            {
                                Flux flux = new Flux("Adhesion", DateTime.Now, 10, 1, Gestion.GetDernierIdAdherent(), 2, 1);
                                Gestion.AddFluxInscription(flux);
                            }
                        }
                        if (prendSweat == "1")
                        {
                            if (prelevementEleveAutorise == "0")
                            {
                                Flux flux = new Flux("Adhesion", DateTime.Now, 25, 0, Gestion.GetDernierIdAdherent(), 2, 1);
                                Gestion.AddFluxInscription(flux);
                            }
                            if (prelevementEleveAutorise == "1")
                            {
                                Flux flux = new Flux("Adhesion", DateTime.Now, 25, 1, Gestion.GetDernierIdAdherent(), 2, 1);
                                Gestion.AddFluxInscription(flux);
                            }
                        }
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
