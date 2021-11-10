using System;

namespace Exercice_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Employes e1 = new Employes("Chat", "Nyani", new DateTime(2004, 01, 10), "Directrice des Newbs",23031001 ,"Fun4Life");
            Employes e2 = new Employes("Rat", "MAXje", new DateTime(2000, 03, 23), "Directeur des Newbs", 10012303, "Fun4Life");
            Employes e3 = new Employes("Cochon", "Enzo", new DateTime(1998, 06, 20), "Directeur des Headshots", 20062303, "Fun4Life");
            Employes e4 = new Employes("Cheval", "Marija", new DateTime(2001, 12, 04), "Directrice des Bêtises", 12041447, "Fun4Life");
            Employes e5 = new Employes("Serpent", "Theo", new DateTime(1999, 07, 08), "Directeur de la Sagesse", 88888888, "Fun4Life");

            //e1.VersementPrimeTest(e1);

            //4.1 Employes.AfficherNbrEmployes();

            foreach (var item in Employes.Enfants)
            {

            }


           
        }
    }
}
