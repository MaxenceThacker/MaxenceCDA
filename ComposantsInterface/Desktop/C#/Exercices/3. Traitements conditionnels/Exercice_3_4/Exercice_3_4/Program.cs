using System;

namespace Exercice_3_4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercice 11 - Opérations sur les heures

            double h1, m1, h2, m2, heures, minutes, minutes1;

            Console.Write("Veuillez rentrez heure de début :");
            h1 = (double.Parse(Console.ReadLine()));
            Console.Write("Veuillez rentrez minute de début :");
            m1 = double.Parse(Console.ReadLine());
            Console.Write("Veuillez rentrez heure de fin :");
            h2 = (double.Parse(Console.ReadLine()));
            Console.Write("Veuillez rentrez minute de fin :");
            m2 = double.Parse(Console.ReadLine());
            heures = (h2 - h1);
            if ((m2 + m1) > 60) 
                    {
                     heures++;
                     minutes = ((m2 + m1) - 60);
                    }else
                    {
                     minutes = Math.Abs(m2 - m1);
                    }
            if (h2 < h1 || h2 == h1 && m2 < m1)
            {
                Console.WriteLine("error");
            }else
            {
                Console.WriteLine("possible, l'écart entre est de " + heures + " : " + minutes);
            }
            //Exercice 12 - Le jour d’après

            int j;
            int m;
            int a;

            Console.Write("Veuillez rentrez le jour :");
            j = (int.Parse(Console.ReadLine()));
            Console.Write("Veuillez rentrez le mois :");
            m = int.Parse(Console.ReadLine());
            Console.Write("Veuillez rentrez l'année :");
            a = (int.Parse(Console.ReadLine()));
           

             if (j == 31)
            {
                j = 01;
                m++;
            } 
            else if (m == 30 )
            {

            }
            else
            {
                j++;
            }

            if (m == 12)
            {
                m = 01;
                a++;
            }
            else
            {
                m++;
            }
            if (((a % 4 == 0 && a % 100 != 0) || a % 400 == 0) && m == 2 && j == 28)
            {
                j++;
            }
            if else ((a % 4 == 0 && a % 100 != 0) || a % 400 == 0)
            { 
                Console.WriteLine("C'est une une année bissextiles");
            }





                    




        }
    }
}
