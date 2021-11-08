using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_2
{
    class Client
    {
        public int Cin { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public int Telephone { get; set; }

        public Client(int cin, string nom, string prenom, int telephone)
        {
            Cin = cin;
            Nom = nom;
            Prenom = prenom;
            Telephone = telephone;
        }
        public Client(int cin, string nom, string prenom)
        {
            Cin = cin;
            Nom = nom;
            Prenom = prenom;
        }
        public string Afficher()
        {
            return "Les informations du Client sont :" + 
                   "CIN : " + this.Cin + Environment.NewLine +
                   "Nom : " + this.Nom + Environment.NewLine +
                   "Prénom : " + this.Nom + Environment.NewLine +
                   "Téléphone : " + this.Nom + Environment.NewLine ;
        }


    }
}
