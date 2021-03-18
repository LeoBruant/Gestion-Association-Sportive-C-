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

namespace UtilisateursGUI
{
    public partial class Comptabilite : Form
    {
        public Comptabilite()
        {
            InitializeComponent();
            float budgetEPS = GestionUtilisateurs.GetBudgetEPS();
            float budgetAS = GestionUtilisateurs.GetBudgetAS();

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
                GestionUtilisateurs.ModifBudgetEPS(float.Parse(EPSChamp.Text));
                float budgetEPS = GestionUtilisateurs.GetBudgetEPS();
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
                GestionUtilisateurs.ModifBudgetAS(float.Parse(ASChamp.Text));
                float budgetEPS = GestionUtilisateurs.GetBudgetAS();
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
