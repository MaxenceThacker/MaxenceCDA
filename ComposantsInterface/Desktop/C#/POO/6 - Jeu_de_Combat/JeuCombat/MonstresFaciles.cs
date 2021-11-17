using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuxCombat
{
    class MonstresFaciles
    {
        public bool Vivant { get; set; }

        public MonstresFaciles()
        {
            this.Vivant = true;
        }

        public virtual bool Attaque(Joueurs toto, bool trace)
        {

            int lancerJoueur = De.LancerDe();
            int lancerMonstre = De.LancerDe();
            if (lancerMonstre > lancerJoueur)
            {
                toto.SubiDegats(10, trace);
                return true;
            }
            return false;
        }
    }
}
