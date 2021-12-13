using System;
using System.Collections.Generic;

#nullable disable

namespace GestionProjet.Data.Models
{
    public partial class Typesproduit
    {
        public Typesproduit()
        {
            Categories = new HashSet<Category>();
        }

        public int IdTypesProduits { get; set; }
        public string LibelleTypeProduit { get; set; }

        public virtual ICollection<Category> Categories { get; set; }
    }
}
