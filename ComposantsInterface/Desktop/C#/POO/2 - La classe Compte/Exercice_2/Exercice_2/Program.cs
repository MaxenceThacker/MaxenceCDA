using System;

namespace Exercice_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Client client1 = new Client(150224, "Durant", "Toto");
            Compte compte = new Compte(client1, 200); 
            compte.Crediter(100); 
            compte.Debiter(50); 
            Console.WriteLine("Le nouveau solde est de : {0}€", compte.Solde); // Sympa la syntaxe !
            Console.ReadKey(); 
        }
    }
}
