using System;

namespace Exercice_2
{
    class Program
    {
        static void Main()
        {
            string saisie;
            double montant;
            double[] array = new double[] {0.01, 0.02, 0.05, 0.1, 0.2, 0.5};

            Console.WriteLine("Entrer le montant à payer :");
            saisie = Console.ReadLine()
                montant = Convert.ToDouble(saisie)
    /*
           // 2.1
            string var;
            int varInt;
            Console.Write("Saisissez un caractère : ");
            var = Console.ReadLine();
            varInt = (int)char.Parse(var);
            Console.WriteLine("Son successeur dans la table UNICODE est : " + (char)(varInt + 1) + " soit le code : " + (varInt + 1));

            // 2.2
            char val1 = '0';
            char val2 = '1';
            char val3 = '2';
            char val4 = '3';
            char val5 = '4';
            char val6 = '5';
            char val7 = '6';
            char val8 = '7';
            char val9 = '8';
            char val10 = '9';

            Console.WriteLine((int)val1);
            Console.WriteLine((int)val2);
            Console.WriteLine((int)val3);
            Console.WriteLine((int)val4);
            Console.WriteLine((int)val5);
            Console.WriteLine((int)val6);
            Console.WriteLine((int)val7);
            Console.WriteLine((int)val8);
            Console.WriteLine((int)val9);
            Console.WriteLine((int)val10);

            //2.3
            Console.WriteLine("Saisissez le poids d'un carton : ");
            float poidsUnitaire = float.Parse(Console.ReadLine());
            Console.WriteLine("Saisissez la capacité du camion : ");
            float poidsTotal = float.Parse(Console.ReadLine());
            int nombreDeCartons = (int)(poidsTotal / poidsUnitaire);
            Console.WriteLine("Vous pourrez placer " + nombreDeCartons + " cartons.");
               
        }
    }
}
