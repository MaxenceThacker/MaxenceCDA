using System;
using System.Collections.Generic;
using System.Text;

namespace Exercice_1
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Exercice 1-1 
            string chaine1;
            Console.Write("Entrez votre nom : ");
            chaine1 = Console.ReadLine();
            Console.Write("La nom saisie est : " + chaine1);
            Console.ReadLine(); 

            //Exercie 1.2
            int nb;
            Console.WriteLine("Entrez un entier : ");
            nb = int.Parse(Console.ReadLine());
            //nb = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(nb);


            string entier;

            Console.Write("Saisir un entier : ");

            entier = Console.ReadLine();

            try
            {
              Convert.ToInt32(entier);
              Console.Write("Votre entier est : " + entier);
            }
            catch
            {
              Console.Write("Votre entier n'est pas un entier");
            }

            int a = 5;
            int b = 1;
            Console.WriteLine("La somme de a et b est :" + (a+b));
            Console.WriteLine("La division de a et b est:" + (a/b));
            
            Exercice 4 - Saisie et affichage
            Saisir une variable de type float, afficher sa valeur.

            string Cc;
            double c;

            Console.WriteLine("Saisissez votre taille au format M,Cm : ");
            Cc = Console.ReadLine();
            c = double.Parse(Cc);
            Console.WriteLine("vous mesurez " + c + " cm  c'est deja pas mal ! \n");

            //EXERCICE 5

            string a, b, c;
            double d;

            Console.WriteLine("veuillez saisir une valeur numerique");
            Console.WriteLine("Saisir un premier nombre !");
            a = Console.ReadLine();

            Console.WriteLine("Saisir un deuxième nombre !");
            b = Console.ReadLine();
            Console.WriteLine("Saisir un troisieme nombre !");
            c = Console.ReadLine();

            d = (Convert.ToDouble(a) + Convert.ToDouble(b) + Convert.ToDouble(c))/3;
            Console.WriteLine("La somme des deux nombres est égal a " + d);

            //6 Surface Rectangle
            string saisie1;
            string saisie2;
            double longueur;
            double largeur;
            double surface;

            Console.WriteLine("Entrez une longueur : ");
            saisie1 = Console.ReadLine()
            Console.WriteLine("Entrez une largeur : ");
            saisie2 = Console.ReadLine()
            longueur = Convert.ToDouble(saisie1)
            largeur = Convert.ToDouble(saisie2)
            surface = longueur * largeur;
            Console.Write("Le rectangle de " + longueur + "et de largeur" + largeur);
            Console.WriteLine("a pour surface : " + surface);
            Console.ReadLine();

            /* Exercice 1-7
            char a = 'B';
            Console.WriteLine("Le code ascii de " + a + " est : " + (int)a);
            Console.ReadLine();
            //Exercice 1.8
            Console.WriteLine("lettre en minuscule : ");
            string lettre = Console.ReadLine();
            Console.WriteLine("Lettre en majuscule : " + lettre.ToUpper());

            */


        }
    }
}
