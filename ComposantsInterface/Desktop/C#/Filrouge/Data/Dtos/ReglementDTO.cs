using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filrouge.Data.Dtos
{
    public class ReglementDTOIn
    {
        public string TypePaiement { get; set; }
    }

    public class ReglementDTOout
    {
        public int IdReglement { get; set; }
        public string TypePaiement { get; set; }
    }
}
