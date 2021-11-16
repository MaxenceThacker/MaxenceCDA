using System;

namespace Exercice_Echec1
{
    class Program
    {
        static void Main(string[] args)
        {
            string saisieI;
            string saisieJ;
            int i;
            int j;

            Console.Write("Saisir une coordonnée entre 1 et 8 :");
            saisieI = Console.ReadLine();
            Console.Write("Saisir une coordonnée entre 1 et 8 :");
            saisieJ = Console.ReadLine();
            i = Convert.ToInt32(saisieI);
            j = Convert.ToInt32(saisieJ);
            if (((i + j) % 2) == 0)
            {
                Console.WriteLine("Noir");
            }
            else
            {
                Console.WriteLine("Blanc");
            }

            int piece, i1, i2, j1, j2;
            Console.WriteLine("Quelle piece souhaitez-vous deplacer ? :" +  // Présentation de Pierrot !!!! LA CLASSE
                              "\n**************************************" +
                              "\n0 = Cavalier " +
                              "\n1 = Tour" +
                              "\n2 = Fou" +
                              "\n3 = Dame" +
                              "\n4 = Roi" +
                              "\n**************************************");
            piece = int.Parse(Console.ReadLine());
            Console.WriteLine("Coordonnées (i,j) de la position de départ :");
            Console.Write("i = ");
            i1 = int.Parse(Console.ReadLine());
            Console.Write("j = ");
            j1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Coordonnées (i',j') de la position d'arrivée :");
            Console.Write("i' = ");
            i2 = int.Parse(Console.ReadLine());
            Console.Write("j' = ");
            j2 = int.Parse(Console.ReadLine());
            string possible = "Déplacement de la dame de(" + i1 + ", " + j1 + ") vers(" + i2 + ", " + j2 + ") possible.";
            string impossible = "Déplacement de la tour de(" + i1 + ", " + j1 + ") vers(" + i2 + ", " + j2 + ") impossible.";

            switch (piece)
            {
                case 0: // Cavalier
                    if (Math.Abs(i1 - i2) == 2 && Math.Abs(j1 - j2) == 1 || Math.Abs(i1 - i2) == 1 && Math.Abs(j1 - j2) == 2)
                    {
                        Console.WriteLine(possible);
                    }
                    else
                    {
                        Console.WriteLine(impossible);
                    }
                    break;
                case 1: // Tour
                    if (i1 == i2 || j1 == j2)
                    {
                        Console.WriteLine(possible);
                    }
                    else
                    {
                        Console.WriteLine(impossible);
                    }
                    break;
                case 2: // Fou
                    if (Math.Abs(i1 - i2) == Math.Abs(j1 - j2))
                    {
                        Console.WriteLine(possible);
                    }
                    else
                    {
                        Console.WriteLine(impossible);
                    }
                    break;
                case 3: // Dame
                    if (i1 == i2 || j1 == j2 || Math.Abs(i1 - i2) == Math.Abs(j1 - j2))
                    {
                        Console.WriteLine(possible);
                    }
                    else
                    {
                        Console.WriteLine(impossible);
                    }
                    break;
                case 4: // Roi
                    if (Math.Abs(i1 - i2) < 2 && Math.Abs(j1 - j2) < 2)
                    {
                        Console.WriteLine(possible);
                    }
                    else
                    {
                        Console.WriteLine(impossible);
                    }
                    break;
                default:
                    Console.WriteLine("Votre choix ne correspond au attentes du programme");
                    break;
                    /* REVOIR LA LOGIQUE DU FOU */


            }
        }
    }
}
