using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECF2.Data.DTOs
{
    public class HotelsDTOIn
    {
        public string NomHotel { get; set; }
        public int CategorieHotel { get; set; }
        public string AdresseHotel { get; set; }
        public string VilleHotel { get; set; }
    }
    public class HotelsDTOOut
    {
        public int IdHotel { get; set; }
        public string NomHotel { get; set; }
        public int CategorieHotel { get; set; }
        public string AdresseHotel { get; set; }
        public string VilleHotel { get; set; }
    }
}
