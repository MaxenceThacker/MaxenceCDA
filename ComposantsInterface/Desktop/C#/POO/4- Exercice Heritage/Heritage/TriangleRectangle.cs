using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heritage
{
    class TriangleRectangle
    {
        public double Base { get; set; }
        public double Hauteur { get; set; }

        public TriangleRectangle(double b, double hauteur)
        {
            Base = b;
            Hauteur = hauteur;
        }

        public double Perimetre()
        {
            return this.Base + this.Hauteur + Math.Sqrt(Math.Pow(this.Base, 2) + Math.Pow(this.Hauteur, 2));
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
