using System;

namespace Exercice_Calculatrice
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercice 10

            int val1;
            int val2;
            string ope;
            demanderEntierPositif(string texte);
            {
                int n;
                bool boolean;
                do
                {
                    Console.WriteLine(texte);
                    boolean = int.TryParse(Console.ReadLine(), out n);
                } while (!boolean || n < 0);
                return n;
            }
            demanderDoubleNonNul(string texte);
            {
                double n;
                bool conversionReussi;
                do
                {
                    Console.WriteLine(texte);
                    conversionReussi = int.TryParse(Console.ReadLine(), out n);
                } while (!conversionReussi || n < 0);
                return n;
            }
            demanderDouble();
            {
                float n;
                bool boolean;
                do
                {
                    Console.WriteLine("entrer le nombre ");
                    boolean = int.TryParse(Console.ReadLine(), out n);
                } while (!boolean);
                return n;
            }
            demanderOperateur();
            {
                char n;
                bool boolean;
                do
                {
                    Console.WriteLine("entrer le opérateur :");
                    boolean = char.TryParse(Console.ReadLine(), out n);
                } while (!boolean || n = '+' || n = '-' || n = '/' || n = '*' || n = '$' || n = '!' || n = 'V');
                return n;
            }
            demanderCalcul();
            {
                double n;
                char ope;
                double n1;
                int
                demanderRelatif(n);
                demanderOperateur(ope);
                switch (ope)
                {
                    case "-":
                        demanderRelatif()
                    Console.Write()
                }
            }
            demanderCalculSimple();
            {
                char n;
                bool boolean;
                do
                {
                    Console.WriteLine("entrer le opérateur :");
                    boolean = char.TryParse(Console.ReadLine(), out n);
                } while (!boolean || n = '+' || n = '-' || n = '/' || n = '*' || n = '$' || n = '!' || n = 'V');
                return n;
            }
            /////////////////////////////////////////////////////////////////////////////////////////////////////////
            public static double demanderDoubleNonNull(string texte)
            {
                double n;
                bool conversionReussie;
                do
                {
                    Console.WriteLine(texte);
                    conversionReussie = double.TryParse(Console.ReadLine(), out n);
                } while (!conversionReussie || n != 0);
                return n;
            }
            public static int demanderEntierPositif(string texte)
            {
                int valeur;
                bool conversionReussie;
                do
                {
                    Console.WriteLine(texte);
                    conversionReussie = int.TryParse(Console.ReadLine(), out valeur);

                } while (!conversionReussie || valeur < 0);
                return valeur;
            }
            static double demanderDouble(string texte)
            {
                double nb;
                bool ok;
                do
                {
                    Console.Write(texte);
                    ok = double.TryParse(Console.ReadLine(), out nb);
                } while (!ok);
                return nb;
            }
            static char DemanderOperateur()
            {
                bool ok = true;
                char op;
                bool condition;

                do
                {
                    Console.Write("Entrez un opérateur +,-,*,/,$,!,V : ");
                    ok = char.TryParse(Console.ReadLine(), out op);
                    condition = !ok || (op != '+' && op != '-' && op != '*' && op != '/' && op != '$' && op != '!' && op != 'V' && op != 'v');
                    if (condition)
                        Console.WriteLine("Saisie incorrecte.");

                } while (condition);
                return char.ToUpper(op);
            }
            static double calculSimple(double valeur1, char operateur, double valeur2)
            {
                double resultat;
                switch (operateur)
                {
                    case '+':
                        resultat = valeur1 + valeur2;
                        break;
                    case '-':
                        resultat = valeur1 - valeur2;
                        break;
                    case '*':
                        resultat = valeur1 * valeur2;
                        break;
                    case '/':
                        resultat = valeur1 / valeur2;
                        break;
                    case '$':
                        resultat = Math.Pow(valeur1, valeur2);
                        break;
                    default:
                        break;
                }
                return resultat;
            }
            static double calcul(double valeur1, char operateur, double valeur2)
            {
                double resultat;
                switch (operateur)
                {
                    case '!':
                        resultat = Math.Sqrt(valeur);
                        break;
                    case 'v':
                        resultat = valeur1 - valeur2;
                    default:
                        break;
                }
                return resultat;
            }
        }
    }
}
