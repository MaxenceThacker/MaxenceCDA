using System;
using System.Collections.Generic;

#nullable disable

namespace Filrouge.Data.Models
{
    public partial class Rubriques
    {
        public Rubriques()
        {
            InverseIdRubriqueMereNavigation = new HashSet<Rubriques>();
        }

        public int IdRubrique { get; set; }
        public string LibelleRubrique { get; set; }
        public int IdRubriqueMere { get; set; }

        public virtual Rubriques IdRubriqueMereNavigation { get; set; }
        public virtual ICollection<Rubriques> InverseIdRubriqueMereNavigation { get; set; }
    }
}
