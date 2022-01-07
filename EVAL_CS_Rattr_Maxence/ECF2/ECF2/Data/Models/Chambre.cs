using System;
using System.Collections.Generic;

#nullable disable

namespace ECF2.Data.Models
{
    public partial class Chambre
    {
        public int IdChambre { get; set; }
        public int TypeChambre { get; set; }
        public int CapaciteChambre { get; set; }
        public int NumChambre { get; set; }
        public int IdHotel { get; set; }

        public virtual Hotel HotelAssocie { get; set; }
    }
}
