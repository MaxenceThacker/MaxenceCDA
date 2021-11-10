using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceInvaders
{
    class Invader
    {
        public string Motif { get; set; } = "#";

        public Invader(string motif)
        {
            Motif = motif;
        }

        public override string ToString()
        {
            return this.Motif;
        }
    }
}
