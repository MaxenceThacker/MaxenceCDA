using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cinema.Data.DTOs
{
    public class SeanceDTOIn
    {
        public int? IdFilm { get; set; }
        public int? IdSalle { get; set; }
        public TimeSpan? HoraireSeance { get; set; }
        public DateTime? DateSeance { get; set; }
    }

    public class SeanceDTOOut
    {
        public int IdSeance { get; set; }
        public int? IdFilm { get; set; }
        public int? IdSalle { get; set; }
        public TimeSpan? HoraireSeance { get; set; }
        public DateTime? DateSeance { get; set; }
    }
}
