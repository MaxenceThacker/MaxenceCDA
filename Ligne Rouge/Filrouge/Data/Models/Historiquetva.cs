using System;
using System.Collections.Generic;

#nullable disable

namespace Filrouge.Data.Models
{
    public partial class Historiquetva
    {
        public int IdHistoriqueTva { get; set; }
        public int? IdProduit { get; set; }
        public int? IdTva { get; set; }
        public DateTime DateTva { get; set; }
    }
}
