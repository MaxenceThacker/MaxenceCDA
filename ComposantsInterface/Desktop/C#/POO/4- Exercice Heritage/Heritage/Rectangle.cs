using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heritage
{
    class Rectangle
    {
        public double Longueur { get; set; }
        public double Largeur { get; set; }

        public Rectangle(double longueur, double largeur)
        {
            Longueur = longueur;
            Largeur = largeur;
        }

        public double Perimetre()
        {
            return 2 * (this.Longueur + this.Largeur);
        }
        
        public double Aire()
        {
            return this.Longueur * this.Largeur;
        }

        private bool EstCarre()
        {
            if (this.Longueur == this.Largeur)
                return true;
            else
                return false;
        }
        
        public string ToStringCarre()
        {
            return this.EstCarre() ? "Ce rectangle est un carré" : "Ce rectangle n'est pas un carré";
        }

        public string AfficherRectangle()
        {
            return "Longueur : " + this.Longueur + "- Largeur : " + this.Largeur + "- Périmètre : " + this.Perimetre() + "- Aire : " + this.Aire() + this.ToStringCarre();
        }

    }
}

