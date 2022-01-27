using System;
using System.Collections.Generic;

#nullable disable

namespace Cinema.Data.Models
{
    public partial class Film
    {
        public int IdFilm { get; set; }
        public string LibelleFilm { get; set; }
        public int? DureeMinuteFilm { get; set; }
    }
}
