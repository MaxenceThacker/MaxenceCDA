using System;
using System.Collections.Generic;

#nullable disable

namespace Filrouge.Data.Models
{
    public partial class Produit
    {
        public int IdProduit { get; set; }
        public string LibelleProduit { get; set; }
        public string Description { get; set; }
        public string RefProduit { get; set; }
        public decimal PrixHorsTaxe { get; set; }
        public string Photo { get; set; }
        public int Stock { get; set; }
        public int IdRubrique { get; set; }
    }
}
