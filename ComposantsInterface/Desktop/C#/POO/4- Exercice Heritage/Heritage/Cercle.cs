using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heritage
{
    class Cercle
    {
        public double Diametre { get; set; }

        public Cercle(double diametre)
        {
            Diametre = diametre;
        }

        public double Perimetre()
        {
            return Math.PI*(this.Diametre);
        }

        public double Aire()
        {
            return Math.PI*Math.Pow((this.Diametre/2), 2);
        }
        public string AfficherCercle()
        {
            return "Diamètre : " + this.Diametre + "- Périmètre : " + this.Perimetre() + "- Aire : " + this.Aire();
        }
    }
}
