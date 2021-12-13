using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace GestionProjet.Data.Models
{
    public partial class Article
    {
        [Key]
        public int IdArticles { get; set; }
        public string LibelleArticle { get; set; }
        public int QuatiteStockee { get; set; }
        public int IdCategories { get; set; }

        public virtual Category Category { get; set; }
    }
}
