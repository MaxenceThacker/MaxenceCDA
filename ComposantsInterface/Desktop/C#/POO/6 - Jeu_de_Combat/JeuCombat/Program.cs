using System;

namespace JeuxCombat
{
    class Program
    {
        static void Main(string[] args)
        {

           
            Joueurs titi = new Joueurs();
            int nbMonstre = 0;
            bool trace = true;
            MonstresFaciles monstre;
           
            if (De.LancerDe() <= 3)
            {
                monstre = new MonstresFaciles();
            }
            else monstre = new MonstresDifficiles();
            
            do
            {
                if (!monstre.Vivant) 
                {
                    if (De.LancerDe() <= 3)
                    {
                        monstre = new MonstresFaciles();
                    }
                    else monstre = new MonstresDifficiles();
                }
                if  (titi.Attaque(monstre, trace))
                {
                    Console.WriteLine("le monstre est mort");
                    nbMonstre++;
                }
                else
                {
                    Console.WriteLine("le joueur a raté son coup");
                    if (monstre.Attaque(titi, trace))
                    {
                        Console.WriteLine("le joueur a été toucher");
                    }
                    else
                    {
                        Console.WriteLine("Le monstre a raté ");
                    }
                }
            } while  (titi.PV > 0);
            Console.WriteLine("Vous etes mort vous avez reussi a tuer : " + nbMonstre + " monstres ");
        }
    }
}