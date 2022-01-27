using System;
using System.Collections.Generic;

#nullable disable

namespace Cinema.Data.Models
{
    public partial class Seance
    {
        public int IdSeance { get; set; }
        public int? IdFilm { get; set; }
        public int? IdSalle { get; set; }
        public TimeSpan? HoraireSeance { get; set; }
        public DateTime? DateSeance { get; set; }
    }
}
