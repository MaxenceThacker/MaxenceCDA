using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace Exercice_3
{
    class Agences
    {
        public string Nom { get; set; }
        public string Adresse { get; set; }
        public int CodePostal { get; set; }
        public string Ville { get; set; }
        public bool Restaurant { get; set; }

        public Agences(string nom, string adresse, int codePostal, string ville, bool restaurant)
        {
            Nom = nom;
            Adresse = adresse;
            CodePostal = codePostal;
            Ville = ville;
            Restaurant = restaurant;
        }
        public void TicketResto()
        {
            if (this.Restaurant == false)
            {
                Console.WriteLine("L'employé poccèdera des tickets restaurants");
            }
            else
            {
                Console.WriteLine("L'employé ne poccèdera pas de tickets restaurant");
            }
        }
        public override string ToString()
        {
            string reponse =
            "****_INFORMATION_SUR_L'AGENCE_****" +
            "\n|Nom                : " + this.Nom +
            "\n|Adresse    : " + this.Adresse +
            "\n|Code Postal         : " + this.CodePostal +
            "\n|Ville          : " + this.Ville +
            "\n|Restaurant          : " + this.Restaurant;
            this.TicketResto();
            return reponse;
        }

        
                                            
        
    }

}
