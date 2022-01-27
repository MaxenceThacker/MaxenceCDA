using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cinema.Data.DTOs
{
    public class SalleDTOIn
    {
        public int? NbrPlaceSalle { get; set; }
    }

    public class SalleDTOOut
    {
        public int IdSalle { get; set; }
        public int? NbrPlaceSalle { get; set; }
    }
}
