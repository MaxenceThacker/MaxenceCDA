using System;
using System.Text;

namespace Exercice_5
{
    class Program
    {
        static void Main()
        {
            //exercice 1
            //string phrase = "Les framboises sont perchées sur le tabouret de mon grand père.";

            //for (int i = 0; i <= phrase.Length; i++)
            //{
            //    Console.Write(phrase[i]);
            //    Console.ReadLine();
            //}
            //exercice 2
            //string t, t2 = "";
            //int i;
            //int j;
            //int e;
            //string t2;

            //Console.Write("Veuillez entrer une chaine de caractère :");
            //t = Console.ReadLine();
            //Console.Write("Veuillez entrer lavaleur de départ :");
            //i = int.Parse(Console.ReadLine());
            //Console.Write("Veuillez entrer la valeur de fin :");
            //j = int.Parse(Console.ReadLine());
            //for (e = i; i < j; i++)
            //{
            //    t2 = t2 + t[i];
            //}
            //Console.WriteLine(t2);

            //Exercice 3
            //string t, t2 = "";
            //int i;
            //int j;
            //int e;

            //Console.Write("Veuillez entrer une chaine de caractère :");
            //t = Console.ReadLine();
            //Console.Write("Veuillez entrer lavaleur de départ :");
            //i = int.Parse(Console.ReadLine());
            //Console.Write("Veuillez entrer la valeur de fin :");
            //j = int.Parse(Console.ReadLine());
            //for (e = i; i < j; i++)
            //{
            //    t2.Insert(t2.Length, t[i].ToString());
            //}
            //Console.WriteLine(t2);

            //Exercice 4
            //string chaine, a, b;
            //Console.Write("Entrez une chaine de caractere : ");
            //chaine = Console.ReadLine();
            //Console.Write("Entrez la premiere lettre : ");
            //a = Console.ReadLine();
            //Console.Write("Entrez la seconde lettre : ");
            //b = Console.ReadLine();
            //Console.WriteLine(chaine.Replace(a, b));

            //Exercice 5

            //StringBuilder t = new StringBuilder();
            //char a;
            //char b;

            //Console.WriteLine("Veuillez faire rentrer les cibles :");
            //t.Append(Console.ReadLine());
            //Console.WriteLine("Veuillez entrer la cible a abattre :");
            //a = Convert.ToChar(Console.ReadLine());
            //Console.WriteLine("Veuillez entrer l'emplacement des tombes :");
            //b = Convert.ToChar(Console.ReadLine());
            ////Déploiment de la tête chercheuse
            //for (int i = 0; i < t.Length; i++)
            //{
            //     if (t[i] == a)
            //    {
            //        t[i] = b;
            //    }
            //}
            //Console.WriteLine(t);

            //Exercice 6

            //string t, t1, t2;
            //string p;
            //t = "";
            //t1 = "";
            //t2 = "";
            //p = ".";
            //Console.WriteLine("Veuiller entrer l'adresse du fichier :");
            //t = Console.ReadLine();
            //t1 = t.Substring(0, t.IndexOf(p));
            //Console.WriteLine(t1);
            //t2 = t.Substring(t.LastIndexOf(p)+1);
            //Console.WriteLine(t2);

            //Exercice 7

            string fonction;
            int cptr = 0;

            Console.WriteLine("Veuillez entrer une fonction");
            fonction = Console.ReadLine();

            for (int i = 0; i < fonction.Length; i++)
            {
                if (fonction[i] == '(')
                {
                    cptr++;
                }
                else if (fonction[i] == ')')
                {
                    cptr--;
                }
            }
            if (cptr == 0)
            {
                Console.WriteLine("Votre foction est correcte.");
            }
            else
            {
                Console.WriteLine("Votre foction est incorrecte.");
            }



        }
    }
}
