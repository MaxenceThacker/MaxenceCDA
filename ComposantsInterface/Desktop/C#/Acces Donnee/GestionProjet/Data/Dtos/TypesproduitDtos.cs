using GestionProjet.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionProjet.Data.Dtos
{
    public partial class TypesproduitDtosIn
    {
        public string LibelleTypeProduit { get; set; }
    }

    public partial class TypesproduitDtosOut
    {
        public string LibelleTypeProduit { get; set; }
    }

    public partial class TypesproduitDtosAvecCategory
    {
        public TypesproduitDtosAvecCategory()
        {
            Categories = new HashSet<Category>();
        }

        public string LibelleTypeProduit { get; set; }

        public virtual ICollection<Category> Categories { get; set; }
    }
}
