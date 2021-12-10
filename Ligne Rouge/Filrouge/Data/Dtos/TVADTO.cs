using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filrouge.Data.Dtos
{
    public class TVADTOIn
    {
        public int? TauxTva { get; set; }
    }

    public class TVADTOOut
    {
        public int IdTva { get; set; }
        public int? TauxTva { get; set; }
    }
}
