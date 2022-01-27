using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cinema.Data.DTOs
{
    public class TexteDTOIn
    {
        public string CodeTexte { get; set; }
        public string Fr { get; set; }
        public string En { get; set; }
    }

    public class TexteDTOOut
    {
        public int IdTexte { get; set; }
        public string CodeTexte { get; set; }
        public string Fr { get; set; }
        public string En { get; set; }
    }
}
