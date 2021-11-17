using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heritage
{
    class Sphere : Cercle
    {
        public Sphere(double diametre) : base(diametre)
        {

        }
        public double Volume()
        {
            return 4 / 3 * this.Aire() * (base.Diametre/2);
        }
        public string AfficherSphere()
        {
            return "- Volume : " + this.Volume();
        }
    }
}
