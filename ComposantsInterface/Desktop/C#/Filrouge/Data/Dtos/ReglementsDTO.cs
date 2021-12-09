using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filrouge.Data.Dtos
{
    public class ReglementsDTOIn
    {
        public string TypePaiement { get; set; }
    }

    public class ReglementsDTOout
    {
        public int IdReglement { get; set; }
        public string TypePaiement { get; set; }
    }
}
