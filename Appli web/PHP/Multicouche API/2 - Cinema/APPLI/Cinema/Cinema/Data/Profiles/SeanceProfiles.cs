using AutoMapper;
using Cinema.Data.DTOs;
using Cinema.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cinema.Data.Profiles
{
    public class SeanceProfiles : Profile
    {
        public SeanceProfiles()
        {
            CreateMap<Seance, SeanceDTOIn>();
            CreateMap<SeanceDTOIn, Seance>();
            CreateMap<Seance, SeanceDTOOut>();
            CreateMap<SeanceDTOOut, Seance>();
        }
    }
}
