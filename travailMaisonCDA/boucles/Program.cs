using System;

namespace boucles
{
    class Program
    {
        static void Main(string[] args)
        {
            /*    
            //Exercice 4
             int n;

            Console.Write("Veuillez rentrez une valeur :");
            n = (int.Parse(Console.ReadLine()));
            for (int i = n; i > 0; i--)
            {
                Console.WriteLine(i);
            }
       
            //Exercice 5
            int n;
            int i = 1;
            int fact = 1;
            Console.Write("Veuillez entrez une valeur :");
            n = int.Parse(Console.ReadLine());
            do
            {
                fact *= i++;
            }
            while (i <= n)
            Console.WriteLine("La factorielle de " + n + "est" + fact);

            //Exercice 6 

            int nb;
            bool val;


            do
            {
                Console.Write("Entrez une valeur entière : ");
                val = int.TryParse(Console.ReadLine(), out nb);
            } while (!val || nb < 0);

            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine(nb + " x " + i + " = " + (nb * i));
            }


            //Exercice 7
            int valeur;
            for(int i=1;i <= 10;i++)
            {
                for(int j=1;j <= 10;j++)
                {
                    valeur = i * j;
                    Console.Write(valeur + "," );
                }
                Console.WriteLine("");
            }
            
            //Exercice 8 

            int x, n;
            int total = 1;
            int i;
            bool boolean;

            do
            {

                Console.WriteLine("entrer le nombre ");
                x = int.Parse(Console.ReadLine());
                Console.WriteLine("entrer la puissance ");
                boolean = int.TryParse(Console.ReadLine(), out n);

            } while (!boolean || n < 0);

            for (i = 1; i <= n; i++)
             {
                    total = total * x;
             }
             Console.WriteLine("total de l'operation " + total);
            
             //Exercice 9

            int n;
            Console.Write("Saisissez une valeur:");
            n = int.Parse(Console.ReadLine());          
            for ( int i=0; i<n;i++)
            {
             Console.WriteLine();
             for (int j = 0; j < n; j++)
             {
              Console.Write("X ");
             }
            }
            */
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
                        resultat = valeur1 + valeur2;
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

