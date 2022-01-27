using AutoMapper;
using Cinema.Data.DTOs;
using Cinema.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cinema.Data.Profiles
{
    public class FilmProfiles : Profile
    {
        public FilmProfiles()
        {
            CreateMap<Film, FilmDTOIn>();
            CreateMap<FilmDTOIn, Film>();
            CreateMap<Film, FilmDTOOut>();
            CreateMap<FilmDTOOut, Film>();
        }
    }
}
