using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cinema.Data.DTOs
{
    public class FilmDTOIn
    {
        public string LibelleFilm { get; set; }
        public int? DureeMinuteFilm { get; set; }
    }

    public class FilmDTOOut
    {
        public int IdFilm { get; set; }
        public string LibelleFilm { get; set; }
        public int? DureeMinuteFilm { get; set; }
    }
}
