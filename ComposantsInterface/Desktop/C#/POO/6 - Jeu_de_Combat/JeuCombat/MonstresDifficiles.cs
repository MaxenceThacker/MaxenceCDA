using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuxCombats
{
    class MonstresDifficiles : MonstresFaciles
    {


        public override bool Attaque(Joueurs toto, bool trace)
        {
            base.Attaque(toto, trace);
            int lancerMonstre = De.LancerDe();
            if (lancerMonstre != 6)
            {
                toto.SubiDegats(lancerMonstre * 5, trace);
                return true;
            }
            return false;
        }
    }
}