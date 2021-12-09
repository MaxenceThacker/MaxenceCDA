using System;
using System.Collections.Generic;

#nullable disable

namespace Filrouge.Data.Models
{
    public partial class Rubrique
    {
        public Rubrique()
        {
            InverseIdRubriqueMereNavigation = new HashSet<Rubrique>();
        }

        public int IdRubrique { get; set; }
        public string LibelleRubrique { get; set; }
        public int IdRubriqueMere { get; set; }

        public virtual Rubrique IdRubriqueMereNavigation { get; set; }
        public virtual ICollection<Rubrique> InverseIdRubriqueMereNavigation { get; set; }
    }
}
