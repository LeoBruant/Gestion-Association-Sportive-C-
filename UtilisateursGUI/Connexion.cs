using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UtilisateursBLL;

namespace UtilisateursGUI
{
    public partial class Connexion : Form
    {
        public Connexion()
        {
            InitializeComponent();

            Gestion.SetchaineConnexion(ConfigurationManager.ConnectionStrings["Utilisateur"]);
        }

        private void boutonConnexion_Click(object sender, EventArgs e)
        {
            bool vide = false;

            // vérification du remplissage des champs

            if (nomUtilisateurChamp.Text == string.Empty)
            {
                erreurNomUtilisateur.Visible = true;
                vide = true;
            }
            else
            {
                erreurNomUtilisateur.Visible = false;
            }

            if (motDePasseChamp.Text == string.Empty)
            {
                erreurMotDePasse.Visible = true;
                vide = true;
            }
            else
            {
                erreurMotDePasse.Visible = false;
            }

            // vérification des informations de connexion

            if (!Gestion.EstConnecte(nomUtilisateurChamp.Text, motDePasseChamp.Text))
            {
                if(vide)
                {
                    erreurIdentification.Visible = false;
                }
                else
                {
                    erreurIdentification.Visible = true;
                }
            }

            // changement de page suite à la connexion réussie

            else
            {
                if(vide != true)
                {
                    if (Gestion.EstAdmin(nomUtilisateurChamp.Text))
                    {
                        ChoixAdmin choixAdmin = new ChoixAdmin();
                        choixAdmin.Show();
                    }

                    else
                    {
                        Comptabilite comptabilite = new Comptabilite();
                        comptabilite.Show();
                    }

                    this.Hide();
                }
            }
        }

        private void quitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Connexion_Load(object sender, EventArgs e)
        {

        }
    }
}
