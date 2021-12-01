using System;
using System.Collections.Generic;

#nullable disable

namespace Aviation.Data.Models
{
    public partial class Avion
    {
        public int IdAvion { get; set; }
        public string TypeAvion { get; set; }
        public int IdAgence { get; set; }

        public virtual Agence Agence { get; set; }
        
    }
}
