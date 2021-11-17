using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heritage
{
    class PyramideBaseTriangle : TriangleRectangle
    {
        public double Profondeur { get; set; }

        public PyramideBaseTriangle(double profondeur, double b, double hauteur) : base(b, hauteur)
        {
            Profondeur = profondeur;
        }

        public override double Perimetre()
        {
            return 2 * base.Perimetre() + 3 * this.Profondeur;
        }

        public double Volume()
        {
            return this.Aire() * this.Profondeur;
        }
        public string AfficherPyramide()
        {
            return "- Périmètre : " + this.Perimetre() + "- Volume : " + this.Volume();
        }
    }
}
