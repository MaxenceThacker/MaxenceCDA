using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Exercice_3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            //Exercice 1 - Majorité
             string saisie;
             double age;

             Console.Write("Saisissez votre âge :");
             saisie = Console.ReadLine();
             age = Convert.ToDouble(saisie);
             if (age >= 18)
             {
                 Console.WriteLine("Vous êtes Majeur !");
             }else
             {
                 if (age > 0)
                 {
                     Console.WriteLine("Vous êtes mineur !");
                 }
                 else
                 {
                     Console.WriteLine("Vous n'êtes pas né !");
                 }
             }
            //Exercice 2 - Valeur Absolue'
            string saisie;
            double valeur;

            Console.Write("Saisissez une valeur (entier ou reel, c'est vous qui décider et peu importe le signe) :");
            saisie = Console.ReadLine();
            valeur = Convert.ToDouble(saisie);
            if (valeur < 0)
            {
                Console.WriteLine($"Abs({valeur}) = {Math.Abs(valeur)}");
            }else
            {
                Console.WriteLine(valeur);
            }
            

            //Exercice 3 - Admissions
            decimal note;

            Console.Write("Saisissez votre note sur 20 :");
            saisie = Console.ReadLine();
            note = Convert.ToDecimal(saisie);
            if (note < 8)
            {
                Console.WriteLine("Ajourné, la prochaine fois tu l'auras !");
            }
            else
            {
                if (note > 10)
                {
                    Console.WriteLine("Admis, paye tes croissant !");
                }
                else
                {
                    Console.WriteLine("Rattrapage, seconde chance!");
                }
            }
            */
            //Exercice 4 - Assurances

            double franchise;

            Console.Write("Saisissez le montant des dommages :");
            franchise = (0.1*Convert.ToDouble(Console.ReadLine());

                if (franchise < 4000)
            {
                Console.WriteLine("Le montant qui sera remboursé est de :" (dommage - (0.1 * dommage))"et la franchise prélevé est de :" (0.1 * dommage));
            } else
                {
                    Console.WriteLine("Les conditions de remboursement ne sont pas remplient");
                }





                /*
            //Exercice 7 - Calculatrice
            string saisie1;
            string saisie2;
            string signe;
            int valeur1;
            int valeur2;


            Console.Write("Saisissez un entier :");
            saisie1 = Console.ReadLine();
            Console.Write("Saisissez un autre entier :");
            saisie2 = Console.ReadLine();
            Console.Write("Saisissez l'opérateur ( +, -, *, / :)");
            signe = Console.ReadLine();
            valeur1 = Convert.ToInt32(saisie1);
            valeur2 = Convert.ToInt32(saisie2);
            switch (signe)
            {
                case "-":
                    Console.WriteLine("Le resultat :"valeur1 - valeur2);
                    break;
                case "+":
                    Console.WriteLine(valeur1 + valeur2);
                    break;
                case "/":
                    if(valeur2 == 0)
                    {
                        Console.WriteLine("Division impossible par 0");
                    }
                    else
                    {
                        Console.WriteLine(valeur1 / valeur2);
                    }
                    
                    break;
                case "*":
                    Console.WriteLine(valeur1 * valeur2);
                    break;
                default:
                    Console.WriteLine("Veulliez choisir un signe opérationnel la prochaine fois");
                    break;
            }
        }

    }
}

