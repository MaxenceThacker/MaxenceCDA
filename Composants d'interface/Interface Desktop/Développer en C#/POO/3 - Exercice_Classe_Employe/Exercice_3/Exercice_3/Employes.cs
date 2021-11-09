using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_3
{
    class Employes
    {
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public DateTime DateEmbauche { get; set; }
        public string PosteEmploye { get; set; }
        public double SalaireBrutAnnuel { get; set; }
        public string ServiceEmploye { get; set; }
        private static int NbrEmployes { get; set; } = 0;
        public Agences Agence { get; set; }

        public Employes(string nom, string prenom, DateTime dateEmbauche, string posteEmploye, int salaireBrutAnnuel, string serviceEmploye, Agences agence)
        {
            Nom = nom;
            Prenom = prenom;
            DateEmbauche = dateEmbauche;
            PosteEmploye = posteEmploye;
            SalaireBrutAnnuel = salaireBrutAnnuel;
            ServiceEmploye = serviceEmploye;
            Agence = agence;
            NbrEmployes++;
        }

        public int Anciennete()
        {
            return (int)(DateTime.Today.Subtract(DateTime dateEmbauche).TotalDays / 365);
        }

        public double PrimeAnnuel(double salaireBrutAnnuel)
        {
            return (salaireBrutAnnuel*0.05);
        }

        public double PrimeAnciennete(DateTime dateEmbauche, double salaireBrutAnnuel)
        {
            return (double)(this.Anciennete(dateEmbauche)*(salaireBrutAnnuel*0.02));
        }

        public bool VersementPrime(Employes employe)
        {
            if (DateTime.Now.Month == 12 && DateTime.Now.Day == 31)
            {
                Console.WriteLine("La prime a été versé et le montant de cette prime est de :" + (employe.PrimeAnciennete(DateEmbauche, SalaireBrutAnnuel) + employe.PrimeAnnuel(SalaireBrutAnnuel)));
                return true;
            }
            else
            {
                Console.WriteLine("La prime n'a pas encore été versé");
                return false;
            }
        }
        //public bool VersementPrimeTest(Employes employe)
        //{
        //    if (DateTime.Now.Month == DateTime.Now.Month && DateTime.Now.Day == DateTime.Now.Day)
        //    {
        //        Console.WriteLine("La prime a été versé et le montant de cette prime est de :" + (employe.PrimeAnciennete(DateEmbauche, SalaireBrutAnnuel) + employe.PrimeAnnuel(SalaireBrutAnnuel)));
        //        return true;
        //    }
        //    else
        //    {
        //        Console.WriteLine("La prime n'a pas encore été versé");
        //        return false;
        //    }
        //}
        public static void AfficherNbrEmployes()  
        {
            Console.WriteLine("nombre d'employés est: " + NbrEmployes);
        }
        
        public void ChequesVacance()
        {
            if (this.Anciennete() )
        }
        


    }
}
