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
    public class Gestion
    {
        private static Gestion uneGestionUtilisateurs; // objet BLL

        // Accesseur en lecture
        public static Gestion GetGestionUtilisateurs()
        {
            if (uneGestionUtilisateurs == null)
            {
                uneGestionUtilisateurs = new Gestion();
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
            return GestionDAO.EstConnecte(login, mdp);
        }

        // Méthode qui retourne vrai si l'utilisateur connecté est un administrateur
        public static bool EstAdmin(string login)
        {
            return GestionDAO.EstAdmin(login);

        }

        // Méthode qui retourne la liste des adhérents
        public static List<Adherent> GetAdherents()
        {
            return GestionDAO.GetAdherents();
        }

        // Méthode qui retourne une liste contenant un adhérent
        public static Adherent GetUnAdherent(int id)
        {
            return GestionDAO.GetUnAdherent(id);
        }

        // Méthode qui ajoute un adhérent dans la base de données
        public static void AddAdherent(Adherent adherent)
        {
            GestionDAO.AddAdherent(adherent);
        }

        // méthode qui retourne l'id qui correspond au libelle de la classe de l'adhérent
        public static int GetIdClasseAdherent(string libelle)
        {
            return GestionDAO.GetIdClasseAdherent(libelle);
        }

        // méthode qui supprime un adhérent de la base de données
        public static void SupprimeAdherent(int id)
        {
            GestionDAO.SupprimeAdherent(id);
        }

        // Méthode qui modifie un adhérent dans la base de données
        public static void ModifAdherent(Adherent adherent)
        {
            GestionDAO.ModifAdherent(adherent);
        }

        // méthode qui retourne le libellé qui correspond à l'id de la classe de l'adhérent
        public static string GetLibelleClasseAdherent(int id)
        {
            return GestionDAO.GetLibelleClasseAdherent(id);
        }

        // Méthode qui retourne vrai si le login d'un adhérent existe déjà
        public static bool ExisteAdherent(string login)
        {
            return GestionDAO.ExisteAdherent(login);
        }

        // Méthode qui retourne le montant du budget EPS
        public static float GetBudgetEPS()
        {
            return GestionDAO.GetBudgetEPS();
        }

        // Méthode qui retourne le montant du budget EPS
        public static float GetBudgetAS()
        {
            return GestionDAO.GetBudgetAS();
        }

        // Méthode qui met à jour le montant du budget EPS
        public static void ModifBudgetEPS(float valeur)
        {
            GestionDAO.ModifBudgetEPS(valeur);
        }

        // Méthode qui met à jour le montant du budget AS
        public static void ModifBudgetAS(float valeur)
        {
            GestionDAO.ModifBudgetAS(valeur);
        }
        // Méthode qui ajoute un flux dans la base de données
        public static void AddFlux(Flux flux)
        {
            GestionDAO.AddFlux(flux);
        }
        // Méthode qui retourne une liste de debits
        public static List<Flux> GetDebits()
        {
            return(GestionDAO.GetDebits());
        }
        // Méthode qui retourne une liste de credits
        public static List<Flux> GetCredits()
        {
            return (GestionDAO.GetCredits());
        }
        // Méthode qui retourne une liste contenant un flux
        public static Flux GetUnFlux(int id)
        {
            return GestionDAO.GetUnFlux(id);
        }
        // Méthode qui modifie un adhérent dans la base de données
        public static void ModifFlux(Flux flux)
        {
            GestionDAO.ModifFlux(flux);
        }
        public static void SupprimeFlux(int id)
        {
            GestionDAO.SupprimeFlux(id);
        }
        public static float GetBudgetASActuel()
        {
            return GestionDAO.GetBudgetASActuel();
        }
        public static float GetBudgetEPSActuel()
        {
            return GestionDAO.GetBudgetEPSActuel();
        }
        public static void CalculerBudgetAS()
        {
            GestionDAO.CalculerBudgetAS();
        }
        public static void CalculerBudgetEPS()
        {
            GestionDAO.CalculerBudgetEPS();
        }
    }
}
