using System;
using System.Collections.Generic;

#nullable disable

namespace GestionProjet.Data.Models
{
    public partial class article
    {
        public int IdArticles { get; set; }
        public string LibelleArticle { get; set; }
        public int? QuatiteStockee { get; set; }
        public int IdCategories { get; set; }

        public virtual category IdCategoriesNavigation { get; set; }
    }
}
