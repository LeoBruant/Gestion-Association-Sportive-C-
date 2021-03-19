using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilisateursBO
{
    public class Budget
    {
        private int id_budget;
        private string libelle_budget;
        private float montantinitial_budget;
        private float montantactuel_budget;

        public Budget(string libelle_budget, float montantinitial_budget, float montantactuel_budget)
        {
            this.Libelle_budget = libelle_budget;
            this.Montantinitial_budget = montantinitial_budget;
            this.Montantactuel_budget = montantactuel_budget;
        }

        public int Id_budget { get => id_budget; set => id_budget = value; }
        public string Libelle_budget { get => libelle_budget; set => libelle_budget = value; }
        public float Montantinitial_budget { get => montantinitial_budget; set => montantinitial_budget = value; }
        public float Montantactuel_budget { get => montantactuel_budget; set => montantactuel_budget = value; }
    }
}
