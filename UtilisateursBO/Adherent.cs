using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilisateursBO
{
    public class Adherent
    {
        int id;
        string nom;
        string prenom;
        DateTime dateNaissance;
        string numTel;
        string email;
        string numParent;
        int autorisePrelev;
        string sexe;
        string login;
        DateTime dateMaj;
        int estArchive;
        string mdp;
        int classe;

        // constructeur utilisé pour afficher les données des adhérents
        public Adherent(int id, string nom, string prenom, DateTime dateNaissance, string numTel, string email, string numParent, int autorisePrelev, string sexe, string login, DateTime dateMaj, int estArchive, int classe)
        {
            this.id = id;
            this.nom = nom;
            this.prenom = prenom;
            this.dateNaissance = dateNaissance;
            this.numTel = numTel;
            this.email = email;
            this.numParent = numParent;
            this.autorisePrelev = autorisePrelev;
            this.sexe = sexe;
            this.login = login;
            this.dateMaj = dateMaj;
            this.estArchive = estArchive;
            this.classe = classe;
        }

        // constructeur utilisé pour afficher la liste des adhérents
        public Adherent(int id, string nom, string prenom)
        {
            this.id = id;
            this.nom = nom;
            this.prenom = prenom;
        }

        // constructeur utilisé pour ajouter un adhérent dans la base de données
        public Adherent(string nom, string prenom, DateTime dateNaissance, string numTel, string email, string numParent, int autorisePrelev, string sexe, string login, string mdp, int classe)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.dateNaissance = dateNaissance;
            this.numTel = numTel;
            this.email = email;
            this.numParent = numParent;
            this.autorisePrelev = autorisePrelev;
            this.sexe = sexe;
            this.login = login;
            this.mdp = mdp;
            this.classe = classe;
        }

        // constructeur utilisé pour modifier un adhérent de la base de données
        public Adherent(string nom, string prenom, DateTime dateNaissance, string numTel, string email, string numParent, int autorisePrelev, string sexe, string login, int estArchive, int classe)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.dateNaissance = dateNaissance;
            this.numTel = numTel;
            this.email = email;
            this.numParent = numParent;
            this.autorisePrelev = autorisePrelev;
            this.sexe = sexe;
            this.login = login;
            this.estArchive = estArchive;
            this.classe = classe;
        }

        public int Id { get => id; set => id = value; }
        public string Nom { get => nom; set => nom = value; }
        public string Prenom { get => prenom; set => prenom = value; }
        public DateTime DateNaissance { get => dateNaissance; set => dateNaissance = value; }
        public string NumTel { get => numTel; set => numTel = value; }
        public string Email { get => email; set => email = value; }
        public string NumParent { get => numParent; set => numParent = value; }
        public int AutorisePrelev { get => autorisePrelev; set => autorisePrelev = value; }
        public string Sexe { get => sexe; set => sexe = value; }
        public string Login { get => login; set => login = value; }
        public DateTime DateMaj { get => dateMaj; set => dateMaj = value; }
        public int EstArchive { get => estArchive; set => estArchive = value; }
        public string Mdp { get => mdp; set => mdp = value; }
        public int Classe { get => classe; set => classe = value; }
    }
}
