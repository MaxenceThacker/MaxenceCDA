using System;
using System.Collections.Generic;

#nullable disable

namespace Filrouge.Data.Models
{
    public partial class Factures
    {
        public int IdFacture { get; set; }
        public int? IdReglement { get; set; }
        public int? IdCommande { get; set; }
        public DateTime DatePaiement { get; set; }
        public decimal MontantPaiement { get; set; }
    }
}
