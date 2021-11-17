using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heritage
{
    class Parallelepipede : Rectangle
    {
        public double Hauteur { get; set; }

        public Parallelepipede(double hauteur, double longeur, double largeur) : base(longeur, largeur)
        {
            Hauteur = hauteur;
        }

        public override double Perimetre()
        {
            return 6 * (this.Longueur + this.Largeur) + 4 * this.Hauteur;
        }

        public double Volume()
        {
            return (this.Aire())* this.Hauteur;
        }

        public override string AfficherRectangle()
        {
            return "- Périmètre : " + this.Perimetre() + "- Volume : " + this.Volume();
        }

    }
}
