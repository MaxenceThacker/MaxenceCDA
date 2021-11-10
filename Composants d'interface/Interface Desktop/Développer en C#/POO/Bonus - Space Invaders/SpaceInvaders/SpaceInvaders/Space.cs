using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceInvaders
{
    class Space
    {
        public int NbLignes { get; set; }
        public int NbColonnes { get; set; } 
        public char[,] Grille { get; set; }

        public Space(int nbLignes, int nbColonnes)
        {
            NbLignes = nbLignes;
            NbColonnes = nbColonnes;
            NouvelleGrille();
        }
        public void NouvelleGrille()
        {
            Grille = new char[this.NbLignes,this.NbColonnes ];

            for (int i = 0; i < this.NbLignes; i++)
            {
                for (int j = 0; j < this.NbColonnes; j++)
                {
                    Grille[i, j] = ' ';
                }
            }

        }

        public override string ToString()
        {
            
        }


    }
        // pour faire plus simple Grille est une propriété de type Char[,] tableau à 2 dim de char
        // dans le construct des que tu as les dimensions tu crée la grille et tu l'as remplis d'espace
        // ce remplissage se fait dans une fonction (un algo)
        //mais c'est font tion est obligatoirement dans le constructeur ?
        // on ne peux pas mettre une fonction dans une autre. Elle est definie en dessous et appelée à l'intérieur





}

