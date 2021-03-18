using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using UtilisateursBO;

namespace UtilisateursDAL
{
    public class GestionDAO
    {
        private static GestionDAO unUtilisateurDAO;

        // Accesseur en lecture, renvoi une instance
        public static GestionDAO GetunUtilisateurDAO()
        {
            if (unUtilisateurDAO == null)
            {
                unUtilisateurDAO = new GestionDAO();
            }

            return unUtilisateurDAO;
        }

        // Méthode qui retourne vrai si les informations de connexion sont les bonnes
        public static bool EstConnecte(string login, string mdp)
        {
            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();

            // Requette sql
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText = " SELECT Login_utilisateur, Mdp_utilisateur FROM UTILISATEUR";

            // Lecture des données
            SqlDataReader monReader = cmd.ExecuteReader();

            while (monReader.Read())
            {
                if (monReader["Login_utilisateur"].ToString() == login && monReader["Mdp_utilisateur"].ToString() == mdp)
                {
                    monReader.Close();

                    return true;
                }
            }
            monReader.Close();
            maConnexion.Close();

            return false;
        }

        // Méthode qui retourne vrai si l'utilisateur connecté est un administrateur
        public static bool EstAdmin(string login)
        {
            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();

            // Requette sql
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText = " SELECT Droit_utilisateur FROM UTILISATEUR WHERE Login_utilisateur = @login";

            // Ajout des paramètres
            cmd.Parameters.AddWithValue("@login", login);

            // Lecture des données
            SqlDataReader monReader = cmd.ExecuteReader();

            while (monReader.Read())
            {
                if (monReader["Droit_utilisateur"].ToString() == "1")
                {
                    monReader.Close();

                    return true;
                }
            }
            monReader.Close();
            maConnexion.Close();

            return false;
        }

        // Méthode qui retourne la liste des adhérents
        public static List<Adherent> GetAdherents()
        {
            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();

            // Requette sql
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText = "SELECT Id_adherent, Nom_adherent, Prenom_adherent FROM ADHERENT";

            // Lecture des données
            SqlDataReader monReader = cmd.ExecuteReader();

            var lesAdherents = new List<Adherent>();

            while (monReader.Read())
            {
                Adherent adherent = new Adherent(Convert.ToInt32(monReader["Id_adherent"]), monReader["Nom_adherent"].ToString(), monReader["Prenom_adherent"].ToString());

                lesAdherents.Add(adherent);
            }
            monReader.Close();
            maConnexion.Close();

            return lesAdherents;
        }

        // Méthode qui retourne un adhérent
        public static Adherent GetUnAdherent(int id)
        {
            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();

            // Requette sql
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText = "SELECT * FROM ADHERENT WHERE Id_adherent = @id";

            // Ajout des paramètres
            cmd.Parameters.AddWithValue("@id", id);

            // Lecture des données
            SqlDataReader monReader = cmd.ExecuteReader();

            while (monReader.Read())
            {
                Adherent adherent = new Adherent(Convert.ToInt32(monReader["Id_adherent"]), monReader["Nom_adherent"].ToString(), monReader["Prenom_adherent"].ToString(), Convert.ToDateTime(monReader["Ddn_adherent"]), monReader["Numtel_adherent"].ToString(), monReader["Email_adherent"].ToString(), monReader["Numparent_adherent"].ToString(), Convert.ToInt32(monReader["Autprelev_adherent"]), monReader["Sexe_adherent"].ToString(), monReader["Login_adherent"].ToString(), Convert.ToDateTime(monReader["Datemaj_adherent"]), Convert.ToInt32(monReader["Archive_adherent"]), Convert.ToInt32(monReader["#Id_classe"]));

                return adherent;
            }

            monReader.Close();
            maConnexion.Close();

            return null;
        }

        // Méthode qui ajoute un adhérent dans la base de données
        public static void AddAdherent(Adherent adherent)
        {
            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();

            // Requette sql
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText = "INSERT INTO ADHERENT (Nom_adherent, Prenom_adherent, Ddn_adherent, Numtel_adherent, Email_adherent, Numparent_adherent, Autprelev_adherent, Sexe_adherent, Login_adherent, Mdp_adherent, Datemaj_adherent, Archive_adherent, #Id_classe) VALUES (@Nom_adherent, @Prenom_adherent, @Ddn_adherent, @Numtel_adherent, @Email_adherent, @Numparent_adherent, @Autprelev_adherent, @Sexe_adherent, @Login_adherent, @Mdp_adherent, @Datemaj_adherent, @Archive_adherent, @Id_classe)";

            // Ajout des paramètres
            cmd.Parameters.AddWithValue("@Nom_adherent", adherent.Nom);
            cmd.Parameters.AddWithValue("@Prenom_adherent", adherent.Prenom);
            cmd.Parameters.AddWithValue("@Ddn_adherent", adherent.DateNaissance);
            cmd.Parameters.AddWithValue("@Numtel_adherent", adherent.NumTel);
            cmd.Parameters.AddWithValue("@Email_adherent", adherent.Email);
            cmd.Parameters.AddWithValue("@Numparent_adherent", adherent.NumParent);
            cmd.Parameters.AddWithValue("@Autprelev_adherent", adherent.AutorisePrelev);
            cmd.Parameters.AddWithValue("@Sexe_adherent", adherent.Sexe);
            cmd.Parameters.AddWithValue("@Login_adherent", adherent.Login);
            cmd.Parameters.AddWithValue("@Mdp_adherent", adherent.Mdp);
            cmd.Parameters.AddWithValue("@Datemaj_adherent", DateTime.Now);
            cmd.Parameters.AddWithValue("@Archive_adherent", 0);
            cmd.Parameters.AddWithValue("@Id_classe", adherent.Classe);

            // Execution de la requete
            cmd.ExecuteNonQuery();

            maConnexion.Close();
        }

        // méthode qui retourne l'id qui correspond au libelle de la classe de l'adhérent
        public static int GetIdClasseAdherent(string libelle)
        {
            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();

            // Requette sql
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText = "SELECT Id_classe FROM CLASSE WHERE Libelle_classe = @libelle";

            // Ajout des paramètres
            cmd.Parameters.AddWithValue("@libelle", libelle);

            // Lecture des données
            SqlDataReader monReader = cmd.ExecuteReader();

            var idClasse = new List<int>();

            while (monReader.Read())
            {
                return Convert.ToInt32(monReader["Id_classe"]);
            }

            monReader.Close();
            maConnexion.Close();

            return 0;
        }

        // méthode qui supprime un adhérent de la base de données
        public static void SupprimeAdherent(int id)
        {
            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();

            // Requette sql
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText = "DELETE FROM ADHERENT WHERE Id_adherent = @id";

            // Ajout des paramètres
            cmd.Parameters.AddWithValue("@id", id);

            // Execution de la requete
            cmd.ExecuteNonQuery();

            maConnexion.Close();
        }

        // Méthode qui modifie un adhérent dans la base de données
        public static void ModifAdherent(Adherent adherent)
        {
            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();

            // Requette sql
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText = "UPDATE ADHERENT SET Nom_adherent = @Nom_adherent, Prenom_adherent = @Prenom_adherent, Ddn_adherent = @Ddn_adherent, Numtel_adherent = @Numtel_adherent, Email_adherent = @Email_adherent, Numparent_adherent = @Numparent_adherent, Autprelev_adherent = @Autprelev_adherent, Sexe_adherent = @Sexe_adherent, Login_adherent = @Login_adherent, Datemaj_adherent = @Datemaj_adherent, Archive_adherent = @Archive_adherent, #Id_classe = @Id_classe WHERE Id_adherent = @id";

            // Ajout des paramètres
            cmd.Parameters.AddWithValue("@id", Convert.ToInt32(adherent.Id));
            cmd.Parameters.AddWithValue("@Nom_adherent", adherent.Nom);
            cmd.Parameters.AddWithValue("@Prenom_adherent", adherent.Prenom);
            cmd.Parameters.AddWithValue("@Ddn_adherent", adherent.DateNaissance);
            cmd.Parameters.AddWithValue("@Numtel_adherent", adherent.NumTel);
            cmd.Parameters.AddWithValue("@Email_adherent", adherent.Email);
            cmd.Parameters.AddWithValue("@Numparent_adherent", adherent.NumParent);
            cmd.Parameters.AddWithValue("@Autprelev_adherent", adherent.AutorisePrelev);
            cmd.Parameters.AddWithValue("@Sexe_adherent", adherent.Sexe);
            cmd.Parameters.AddWithValue("@Login_adherent", adherent.Login);
            cmd.Parameters.AddWithValue("@Datemaj_adherent", DateTime.Now);
            cmd.Parameters.AddWithValue("@Archive_adherent", adherent.EstArchive);
            cmd.Parameters.AddWithValue("@Id_classe", adherent.Classe);

            // Execution de la requete
            cmd.ExecuteNonQuery();

            maConnexion.Close();
        }

        // méthode qui retourne une liste qui contient le libellé qui correspond à l'id de la classe de l'adhérent
        public static string GetLibelleClasseAdherent(int id)
        {
            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();

            // Requette sql
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText = "SELECT Libelle_classe FROM CLASSE WHERE Id_classe = @id";

            // Ajout des paramètres
            cmd.Parameters.AddWithValue("@id", id);

            // Lecture des données
            SqlDataReader monReader = cmd.ExecuteReader();

            while (monReader.Read())
            {
                return monReader["Libelle_classe"].ToString();
            }

            monReader.Close();
            maConnexion.Close();

            return null;
        }

        // Méthode qui retourne vrai si le login d'un adhérent existe déjà
        public static bool ExisteAdherent(string login)
        {
            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();

            // Requette sql
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText = "SELECT COUNT(Login_adherent) AS Login FROM ADHERENT WHERE Login_adherent = @login";

            // Ajout des paramètres
            cmd.Parameters.AddWithValue("@login", login);

            // Lecture des données
            SqlDataReader monReader = cmd.ExecuteReader();

            while (monReader.Read())
            {
                if (Convert.ToInt32(monReader["Login"]) == 0)
                {
                    return false;
                }
            }

            monReader.Close();
            maConnexion.Close();

            return true;
        }

        // Méthode qui retourne le montant du budget EPS
        public static float GetBudgetEPS()
        {
            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();

            // Requette sql
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText = "SELECT Montantinitial_budget FROM BUDGET WHERE Libelle_budget = 'EPS'";

            // Lecture des données
            SqlDataReader monReader = cmd.ExecuteReader();

            while (monReader.Read())
            {
                return float.Parse(monReader["Montantinitial_budget"].ToString());
            }

            monReader.Close();
            maConnexion.Close();

            return 0;
        }

        // Méthode qui retourne le montant du budget EPS
        public static float GetBudgetAS()
        {
            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();

            // Requette sql
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText = "SELECT Montantinitial_budget FROM BUDGET WHERE Libelle_budget = 'AS'";

            // Lecture des données
            SqlDataReader monReader = cmd.ExecuteReader();

            while (monReader.Read())
            {
                return Convert.ToInt32(monReader["Montantinitial_budget"]);
            }

            monReader.Close();
            maConnexion.Close();

            return 0;
        }

        // Méthode qui modifie le budget EPS dans la base de données
        public static void ModifBudgetEPS(float valeur)
        {
            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();

            // Requette sql
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText = "UPDATE BUDGET SET Montantinitial_budget = @valeur WHERE Libelle_budget = 'EPS'";

            // Ajout des paramètres
            cmd.Parameters.AddWithValue("@valeur", valeur);

            // Execution de la requete
            cmd.ExecuteNonQuery();

            maConnexion.Close();
        }

        // Méthode qui modifie le budget AS dans la base de données
        public static void ModifBudgetAS(float valeur)
        {
            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();

            // Requette sql
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText = "UPDATE BUDGET SET Montantinitial_budget = @valeur WHERE Libelle_budget = 'AS'";

            // Ajout des paramètres
            cmd.Parameters.AddWithValue("@valeur", valeur);

            // Execution de la requete
            cmd.ExecuteNonQuery();

            maConnexion.Close();
        }

        // Méthode qui ajoute un Flux dans la base de données
        public static void AddFlux(Flux flux)
        {
            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();

            // Requette sql
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText = "INSERT INTO FLUX (Libelle_flux, Date_flux, Montant_flux, Prelevemment_eff_flux, Id_adherent, Id_type_flux, Id_evenement, Id_budget)";

            // Ajout des paramètres
            cmd.Parameters.AddWithValue("@Libelle_flux", flux.Libelle);
            cmd.Parameters.AddWithValue("@Date_flux", flux.DateFlux);
            cmd.Parameters.AddWithValue("@Montant_flux", flux.MontantFlux);
            cmd.Parameters.AddWithValue("@Prelevemment_eff_flux", flux.PrelevementEff);
            cmd.Parameters.AddWithValue("@Id_adherent", flux.IdAdherent);
            cmd.Parameters.AddWithValue("@Id_type_flux", flux.IdTypeFlux);
            cmd.Parameters.AddWithValue("@Id_evenement", flux.IdEvenement);
            cmd.Parameters.AddWithValue("@Id_budget", flux.IdBudget);

            // Execution de la requete
            cmd.ExecuteNonQuery();

            maConnexion.Close();
        }
    }
}
