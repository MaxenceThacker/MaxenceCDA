using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_3
{
    class Enfants
    {
        public string Nom { get; set; }
        public DateTime DDN { get; set; }

        public Enfants(string nom, DateTime ddn)
        {
            Nom = nom;
            DDN = ddn;
        }

        public int age()
        {
            if (DateTime.Now.Month > this.DDN.Month)
            {
                return (DateTime.Now.Year - this.DDN.Year) + 1;
            }
            else
            {
                return (DateTime.Now.Year - this.DDN.Year);
            }
        }


    }



}
