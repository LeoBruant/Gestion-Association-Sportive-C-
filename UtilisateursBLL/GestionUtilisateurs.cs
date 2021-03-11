using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UtilisateursDAL;
using UtilisateursBO;

namespace UtilisateursBLL
{
    public class GestionUtilisateurs
    {
        private static GestionUtilisateurs uneGestionUtilisateurs; // objet BLL

        // Accesseur en lecture
        public static GestionUtilisateurs GetGestionUtilisateurs()
        {
            if (uneGestionUtilisateurs == null)
            {
                uneGestionUtilisateurs = new GestionUtilisateurs();
            }

            return uneGestionUtilisateurs;
        }

        // Définit la chaîne de connexion grâce à la méthode SetchaineConnexion de la DAL
        public static void SetchaineConnexion(ConnectionStringSettings chset)
        {
            string chaine = chset.ConnectionString;
            ConnexionBD.GetConnexionBD().SetchaineConnexion(chaine);
        }

        // Méthode qui retourne vrai si les informations de connexion sont les bonnes
        public static bool EstConnecte(string login, string mdp)
        {
            return UtilisateurDAO.EstConnecte(login, mdp);
        }

        // Méthode qui retourne vrai si l'utilisateur connecté est un administrateur
        public static bool EstAdmin(string login)
        {
            return UtilisateurDAO.EstAdmin(login);

        }

        // Méthode qui retourne la liste des adhérents
        public static List<Adherent> GetAdherents()
        {
            return UtilisateurDAO.GetAdherents();
        }

        // Méthode qui retourne une liste contenant un adhérent
        public static Adherent GetUnAdherent(int id)
        {
            return UtilisateurDAO.GetUnAdherent(id);
        }

        // Méthode qui ajoute un adhérent dans la base de données
        public static void AddAdherent(Adherent adherent)
        {
            UtilisateurDAO.AddAdherent(adherent);
        }

        // méthode qui retourne l'id qui correspond au libelle de la classe de l'adhérent
        public static int GetIdClasseAdherent(string libelle)
        {
            return UtilisateurDAO.GetIdClasseAdherent(libelle);
        }

        // méthode qui supprime un adhérent de la base de données
        public static void SupprimeAdherent(int id)
        {
            UtilisateurDAO.SupprimeAdherent(id);
        }

        // Méthode qui modifie un adhérent dans la base de données
        public static void ModifAdherent(Adherent adherent)
        {
            UtilisateurDAO.ModifAdherent(adherent);
        }

        // méthode qui retourne le libellé qui correspond à l'id de la classe de l'adhérent
        public static string GetLibelleClasseAdherent(int id)
        {
            return UtilisateurDAO.GetLibelleClasseAdherent(id);
        }

        // Méthode qui retourne vrai si le login d'un adhérent existe déjà
        public static bool ExisteAdherent(string login)
        {
            return UtilisateurDAO.ExisteAdherent(login);
        }
    }
}
