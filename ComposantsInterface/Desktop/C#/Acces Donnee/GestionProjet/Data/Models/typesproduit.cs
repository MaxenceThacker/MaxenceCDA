using System;
using System.Collections.Generic;

#nullable disable

namespace GestionProjet.Data.Models
{
    public partial class typesproduit
    {
        public typesproduit()
        {
            categories = new HashSet<category>();
        }

        public int IdTypesProduits { get; set; }
        public string LibelleTypeProduit { get; set; }

        public virtual ICollection<category> categories { get; set; }
    }
}
