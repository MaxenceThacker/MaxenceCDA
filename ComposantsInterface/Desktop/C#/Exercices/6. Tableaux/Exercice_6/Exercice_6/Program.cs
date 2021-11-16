using System;

namespace Exercice_6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercice 3

            //double[] k;
            //k = new double[10];
            //k[0] = 1;// k[0] = 1
            //for (double i = 1; i < 10; i++)
            //    k[i] = 0; //k[1,0,0,0,0,0,0,0,0,0]
            //for (double j = 1; j <= 1000; j++)
            //    for (double i = 1; i < 10; i++)   
            //        k[i] += k[i - 1];
            //foreach (double i in k)
            //    Console.WriteLine(i);
            // tour 1 = k[1,1,1,1,1,1,1,1,1,1]
            // tour 2 = k[1,2,3,4,5,6,7,8,9,10]
            // tour 3 = k[1,3,6,10,15,21,28,36,45,55]

            //Exercice 4

            //int[] liste = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //for (int i = 0; i < liste.Length; i++)
            //{

            //    if (liste[i] < 10)
            //    {
            //        Console.WriteLine("Poste {0}: {1}", i, liste[i]);
            //    }
            //    else { Console.WriteLine("Poste {0}: {1}", i, liste[i]); }
            //}

            //Exercice 5
            //int[] t = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //int somme = 0;
            //for (int i = 0; i < t.Length; i++)
            //    somme = somme + t[i];
            //Console.Write("la somme est de: " + somme);

            // Exercice 6,7,8 => voir correction

            //Exercice 9 
            //int[] t = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //int val;
            //val = t[t.Length - 1];
            //for (int i = t.Length - 2; i >= 0; i--)
            //{
            //    t[i + 1] = t[i];            
            //}
            //t[0] = val;
            //foreach (int a in t)
            //{
            //    Console.Write(a + " ");
            //}

            //Exercice 10
            int[] t = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };
            int temp;
            for (int i = 0; i < (t.Length / 2); i++)
            {
                temp = t[i];
                t[i] = t[t.Length - 1 - i];
                t[t.Length - 1 - i] = temp;
            }
            foreach (int val in t)
            {
                Console.Write(val + " ");
            }


        }
      }
    }
    
