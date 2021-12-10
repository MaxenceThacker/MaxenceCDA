using System;
using System.Collections.Generic;

#nullable disable

namespace Filrouge.Data.Models
{
    public partial class LignesCommande
    {
        public int IdLigneCommande { get; set; }
        public int? IdProduit { get; set; }
        public int? IdCommande { get; set; }
        public int? QuantiteProduit { get; set; }
    }
}
