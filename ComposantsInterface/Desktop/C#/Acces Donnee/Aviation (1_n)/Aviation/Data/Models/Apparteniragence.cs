using System;
using System.Collections.Generic;

#nullable disable

namespace Aviation.Data.Models
{
    public partial class Apparteniragence
    {
        public int IdAppartenirAgences { get; set; }
        public int IdAgence { get; set; }
        public int IdClient { get; set; }

        public virtual Agence IdAgenceNavigation { get; set; }
        public virtual Client IdClientNavigation { get; set; }
    }
}
