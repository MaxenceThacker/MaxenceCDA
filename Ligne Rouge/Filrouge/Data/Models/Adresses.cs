using System;
using System.Collections.Generic;

#nullable disable

namespace Filrouge.Data.Models
{
    public partial class Adresses
    {
        public int IdAdresse { get; set; }
        public string EmailAdresse { get; set; }
        public string TelMobile { get; set; }
        public string TelFixe { get; set; }
        public string Adresse { get; set; }
        public string Province { get; set; }
        public string ComplementAdresse { get; set; }
        public int IdVille { get; set; }
        public virtual Villes Villes { get; set; }
        public virtual Pays Pays { get; set; }
    }
}
