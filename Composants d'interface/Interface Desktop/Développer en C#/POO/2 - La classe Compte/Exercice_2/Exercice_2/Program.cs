using System;

namespace Exercice_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Client client1 = new Client(150224, "Durant", "Toto");
            Client client2 = new Client(150225, "Durant", "Tata");

            //Compte compteClient1 = new Compte(client1, 5000);
            //compteClient1.Crediter();
            Console.WriteLine(client1.Afficher());
        }
    }
}
