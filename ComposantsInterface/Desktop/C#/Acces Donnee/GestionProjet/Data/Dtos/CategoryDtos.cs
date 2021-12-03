using GestionProjet.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionProjet.Data.Dtos
{
    public partial class CategoryDtosIn
    {
        public CategoryDtosIn()
        {
        }
        public string LibelleCategorie { get; set; }
        public int IdTypesProduits { get; set; }
    }

    public partial class CategoryDtosOut
    {
        public CategoryDtosOut()
        {
        }

        public string LibelleCategorie { get; set; }
    }

    public partial class CategoryDtosAvecProduit
    {
        public string LibelleCategorie { get; set; }
        public int IdTypesProduits { get; set; }

        public virtual Typesproduit Typeproduit { get; set; }
    }

    public partial class CategoryDtosAvecProduitEtArticle
    {
            public CategoryDtosAvecProduitEtArticle()
            {
                Articles = new HashSet<Article>();
            }

            public int IdCategories { get; set; }
            public string LibelleCategorie { get; set; }
            public int IdTypesProduits { get; set; }

            public virtual Typesproduit Typeproduit { get; set; }
            public virtual ICollection<Article> Articles { get; set; }
    }

    public partial class CategoryDtosAvecArticle
    {
        public CategoryDtosAvecArticle()
        {
            Articles = new HashSet<Article>();
        }

        public int IdCategories { get; set; }
        public string LibelleCategorie { get; set; }
        public int IdTypesProduits { get; set; } // Peut-on omettre cette ligne ? Je pense que oui mais je la laisse dans le doute

        public virtual ICollection<Article> Articles { get; set; }
    }
}
