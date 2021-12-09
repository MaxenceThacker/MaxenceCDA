using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filrouge.Data.Dtos
{
    public class FournisseursDTOIn
    {
        public string NomFournisseur { get; set; }
    }

    public class FournisseursDTOOut
    {
        public int IdFournisseur { get; set; }
        public string NomFournisseur { get; set; }
    }
}
