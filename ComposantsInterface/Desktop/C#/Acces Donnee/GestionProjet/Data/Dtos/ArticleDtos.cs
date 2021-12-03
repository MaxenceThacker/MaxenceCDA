using GestionProjet.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionProjet.Data.Dtos
{
    public class ArticleDtosIn 
    {
        public string LibelleArticle { get; set; }
        public int? QuatiteStockee { get; set; }
        public int IdCategories { get; set; }
    }

    public class ArticleDtosOut
    {
        public string LibelleArticle { get; set; }
        public int? QuatiteStockee { get; set; }
    }

    public class ArticleDtosAvecCategory
    {
        public string LibelleArticle { get; set; }
        public int? QuatiteStockee { get; set; }
        public int IdCategories { get; set; }
        public virtual Category Category { get; set; }
    }
}
