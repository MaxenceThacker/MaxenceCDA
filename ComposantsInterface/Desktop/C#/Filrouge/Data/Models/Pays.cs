using System;
using System.Collections.Generic;

#nullable disable

namespace Filrouge.Data.Models
{
    public partial class Pays
    {
        public Pays()
        {
            Villes = new HashSet<Villes>();
        }

        public int IdPays { get; set; }
        public string NomPays { get; set; }

        public virtual ICollection<Villes> Villes { get; set; }
    }
}
