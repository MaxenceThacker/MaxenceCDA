using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuCombat
{
    class Joueur_
    {
        public int PV { get; private set; } = 50;

        public Joueur_(int pV)
        {
            PV = pV;
        }

        public bool EstVivant()
        {
            if (this.PV > 0) 

                return true;
            else
                return false;
        }
        
        public bool Attaque(MonstreFacile Monstre)
        {
            int lancerJoueur = De.Lancer();
            int lancerMonstre = De.Lancer();

            if (lancerJoueur >= lancerMonstre)
            {
                Monstre.Vivant = false;
                return true;
            }
                



        }
        

    }
}
