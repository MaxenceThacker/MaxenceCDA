using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciceClasse_1
{
    class Voitures
    {
        public string Couleur { get; set; }
        public string Marque { get; set; }
        public string Modele { get; set; }
        public int NbKilometres { get; set; }
        public string Motorisation { get; set; }

        public Voitures(string couleur, string marque, string modele, int nbKilometres, string motorisation)
        {
            Couleur = couleur;
            Marque = marque;
            Modele = modele;
            NbKilometres = nbKilometres;
            Motorisation = motorisation;
        }

        public Voitures(string marque, string modele)
        {
            Marque = marque;
            Modele = modele;
        }

        public override string ToString()
        {
            return "Cette voiture est une " + this.Modele + " de la marque " + this.Marque + " de couleur " + this.Couleur + " de motorisation " + this.Motorisation + " avec Nb de kilomètres " + this.NbKilometres + ".";
        }
    }
}
