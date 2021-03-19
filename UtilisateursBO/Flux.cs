using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilisateursBO
{
    public class Flux
    {
        private int id;
        private string libelle;
        private DateTime dateFlux;
        private float montantFlux;
        private int prelevementEff;
        private int idAdherent;
        private int idTypeFlux;
        private int idEvenement;
        private int idBudget;
        private string libelleBudget;

        // constructeur utilisé pour afficher les données des flux
        public Flux(int id, string libelle, DateTime dateFlux, float montantFlux, int prelevementEff, int idAdherent, int idTypeFlux, int idEvenement, int idBudget)
        {
            this.id = id;
            this.libelle = libelle;
            this.dateFlux = dateFlux;
            this.montantFlux = montantFlux;
            this.prelevementEff = prelevementEff;
            this.idAdherent = idAdherent;
            this.idTypeFlux = idTypeFlux;
            this.idEvenement = idEvenement;
            this.idBudget = idBudget;
        }

        // constructeur utilisé pour afficher la liste des flux
        public Flux(int id, DateTime dateFlux, string libelle, float montantFlux, string libelleBudget, int idBudget)
        {
            this.id = id;
            this.dateFlux = dateFlux;
            this.libelle = libelle;
            this.montantFlux = montantFlux;
            this.libelleBudget = libelleBudget;
            this.idBudget = idBudget;
        }

        // constructeur utilisé pour ajouter un flux dans la base de données
        public Flux(string libelle,DateTime dateFlux, float montantFlux, int prelevementEff, int idAdherent, int idTypeFlux,int idEvenement, int idBudget)
        {
            this.libelle = libelle;
            this.dateFlux = dateFlux;
            this.montantFlux = montantFlux;
            this.prelevementEff = prelevementEff;
            this.idAdherent = idAdherent;
            this.idTypeFlux = idTypeFlux;
            this.idEvenement = idEvenement;
            this.idBudget = idBudget;
        }

        public int Id { get => id; set => id = value; }
        public string Libelle { get => libelle; set => libelle = value; }
        public DateTime DateFlux { get => dateFlux; set => dateFlux = value; }
        public float MontantFlux { get => montantFlux; set => montantFlux = value; }     
        public int PrelevementEff { get => prelevementEff; set => prelevementEff = value; }
        public int IdAdherent { get => idAdherent; set => idAdherent = value; }
        public int IdTypeFlux { get => idTypeFlux; set => idTypeFlux = value; }
        public int IdEvenement { get => idEvenement; set => idEvenement = value; }
        public int IdBudget { get => idBudget; set => idBudget = value; }
    }
}

