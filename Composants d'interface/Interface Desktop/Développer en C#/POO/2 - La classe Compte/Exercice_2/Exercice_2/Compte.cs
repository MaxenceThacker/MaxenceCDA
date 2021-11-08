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

        public Compte(Client compteClient, int solde)
        {
            CompteClient = compteClient;
            Solde = solde;
            compteur++;
        }

        public int Crediter(int montant)
        {
            this.Solde += montant;
            return this.Solde;    
        }

        public int Crediter(int montant, Compte Solde)
        {
            this.Crediter(montant);
            this.Solde -= montant;
            return this.Solde;
        }

        public int Debiter(int montant)
        {
            this.Solde -= montant;
            return this.Solde;
        }
        public int Debiter(int montant, Compte Solde)
        {
            this.Debiter(montant);
            this.Solde += montant;
            return this.Solde;
        }

        public string Resume()
        {
            return Client.Afficher()


        }
    }
}
