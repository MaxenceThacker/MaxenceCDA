using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECF2.Data.DTOs
{
    public class ChambresDTOIn
    {
       public int IdChambre { get; set; }
        public int TypeChambre { get; set; }
        public int CapaciteChambre { get; set; }
        public int NumChambre { get; set; }
        public int IdHotel { get; set; }
    }
    public class ChambresDTOOut
    {
        public int IdChambre { get; set; }
        public int TypeChambre { get; set; }
        public int CapaciteChambre { get; set; }
        public int NumChambre { get; set; }

    }
    public class ChambresDTOOutAvecHotel
    {
        public int IdChambre { get; set; }
        public int TypeChambre { get; set; }
        public int CapaciteChambre { get; set; }
        public int NumChambre { get; set; }
        public int IdHotel { get; set; }
        public string NomHotel { get; set; }
        public string VilleHotel { get; set; }

    }
}
