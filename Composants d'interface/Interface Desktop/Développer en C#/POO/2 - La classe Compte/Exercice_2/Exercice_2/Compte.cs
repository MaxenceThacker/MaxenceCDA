using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_2
{
    class Compte
    {
        static int compteur;

        public Client CompteClient { get;}
        public int Solde { get; private set; }

        public Compte(Client compteClient, int solde, int compteur)
        {
            CompteClient = compteClient;
            Solde = solde;
            compteur++;
        }

        public int Crediter(int montant)
        {
            int montant;
            bool conversionReussie;
            do 
            {
                Console.WriteLine("Veuillez entrer la montant à créditer :");
                conversionReussie = int.TryParse(Console.ReadLine(), out montant);
            }while (!conversionReussie || montant != 0);
            this.Solde += this.Solde + montant;
            return this.Solde;    
        }

        public string Crediter(int Crediter, Compte Solde)
        {
            this.Crediter();
        }

    }
}
