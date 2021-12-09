using System;
using System.Collections.Generic;

#nullable disable

namespace Filrouge.Data.Models
{
    public partial class Ville
    {
        public int IdVille { get; set; }
        public string LibelleVille { get; set; }
        public string CodePostal { get; set; }
        public int IdPays { get; set; }

        public virtual Pay IdPaysNavigation { get; set; }
    }
}
