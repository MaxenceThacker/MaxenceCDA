using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuxCombats
{
    class Joueurs
    {

        public int PV { get; private set; }

        public Joueurs()
        {
            this.PV = 50;
        }

        public bool EstVivant()
        {
            if (this.PV <= 0)
            {
                return false;
            }
            return true;
        }

        public bool Attaque(MonstresFaciles monstre, bool trace)
        {
            int lancerJoueur = De.LancerDe();
            int lancerMonstre = De.LancerDe();
            if (trace)
            {
                Console.WriteLine("le héros attaque : " + lancerJoueur + " le monstre attaque : " + lancerMonstre);
            }
            if (lancerJoueur >= lancerMonstre)
            {
                monstre.Vivant = false;
                return true;
            }
            return false;
        }

        public bool SubiDegats(int degat, bool trace)
        {
            int lancerJoueur = De.LancerDe();
            if (trace)
            {
                Console.WriteLine("bouclier : " + lancerJoueur);
            }
            if (lancerJoueur <= 2)
            {
                return true;
            }
            if (trace)
            {
                Console.WriteLine("le heros subit des degats : " + degat + " point de vie restant : " + this.PV);
            }
            this.PV -= degat;
            return false;
        }


    }
}
