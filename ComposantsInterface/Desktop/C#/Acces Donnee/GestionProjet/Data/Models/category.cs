using System;
using System.Collections.Generic;

#nullable disable

namespace GestionProjet.Data.Models
{
    public partial class category
    {
        public category()
        {
            articles = new HashSet<article>();
        }

        public int IdCategories { get; set; }
        public string LibelleCategorie { get; set; }
        public int IdTypesProduits { get; set; }

        public virtual typesproduit IdTypesProduitsNavigation { get; set; }
        public virtual ICollection<article> articles { get; set; }
    }
}
