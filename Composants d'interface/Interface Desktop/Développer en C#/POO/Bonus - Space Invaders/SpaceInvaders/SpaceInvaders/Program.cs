using System;

namespace SpaceInvaders
{
    class Program
    {
        static void Main(string[] args)
        {
            Space Grille1 = new Space(4, 10);
            Grille1.NouvelleGrille();
            Grille1.AfficherGrille();

        }
    }
}
