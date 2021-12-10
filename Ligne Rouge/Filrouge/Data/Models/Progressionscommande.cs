using System;
using System.Collections.Generic;

#nullable disable

namespace Filrouge.Data.Models
{
    public partial class ProgressionsCommande
    {
        public int IdProgressionsCommande { get; set; }
        public int? IdCommande { get; set; }
        public int? IdEtatCommande { get; set; }
        public DateTime DateEtatCommande { get; set; }
    }
}
