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
            return 2;
        }

        public double Aire()
        {
            return 2 / (this.Base * this.Hauteur);
        }
        public string AfficherTriangle()
        {
            return "Base : " + this.Base + "- Hauteur : " + this.Hauteur + "- Périmètre : " + this.Perimetre() + "- Aire : " + this.Aire();
        }
    }
}
