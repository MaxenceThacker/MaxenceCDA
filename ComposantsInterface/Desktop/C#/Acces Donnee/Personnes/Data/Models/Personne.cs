using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace Personnes.Data.Models
{
    public partial class Personne
    {
        [Key]
        public int IdPersonne { get; set; }

        public string Nom { get; set; }
        public string Prenom { get; set; }

        internal void Dump()
        {
            throw new NotImplementedException();
        }
    }
}
