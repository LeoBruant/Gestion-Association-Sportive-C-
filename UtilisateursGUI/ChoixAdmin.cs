using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UtilisateursGUI
{
    public partial class ChoixAdmin : Form
    {
        public ChoixAdmin()
        {
            InitializeComponent();
        }

        private void deconnexion_Click(object sender, EventArgs e)
        {
            Connexion connexion = new Connexion();
            connexion.Show();

            this.Close();
        }

        private void accesAdministrateur_Click(object sender, EventArgs e)
        {
            Administration administration = new Administration();
            administration.Show();
            this.Close();
        }

        private void accesComptabilite_Click(object sender, EventArgs e)
        {
            Comptabilite comptabilite = new Comptabilite();
            comptabilite.Show();
            this.Close();
        }
    }
}
