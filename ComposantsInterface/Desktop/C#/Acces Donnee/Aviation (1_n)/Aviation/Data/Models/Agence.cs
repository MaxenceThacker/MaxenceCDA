using System;
using System.Collections.Generic;

#nullable disable

namespace Aviation.Data.Models
{
    public partial class Agence
    {
        public Agence()
        {
            Apparteniragences = new HashSet<Apparteniragence>();
            Avions = new HashSet<Avion>();
        }

        public int IdAgence { get; set; }
        public string NomAgence { get; set; }

        public virtual ICollection<Apparteniragence> Apparteniragences { get; set; }
        public virtual ICollection<Avion> Avions { get; set; }
    }
}
