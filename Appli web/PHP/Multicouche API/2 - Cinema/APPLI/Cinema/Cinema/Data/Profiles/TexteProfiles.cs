using AutoMapper;
using Cinema.Data.DTOs;
using Cinema.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cinema.Data.Profiles
{
    public class TexteProfiles : Profile
    {
        public TexteProfiles()
        {
            CreateMap<Texte, TexteDTOIn>();
            CreateMap<TexteDTOIn, Texte>();
            CreateMap<Texte, TexteDTOOut>();
            CreateMap<TexteDTOOut, Texte>();
        }
    }
}
