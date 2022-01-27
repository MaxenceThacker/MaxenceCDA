using AutoMapper;
using Cinema.Data.DTOs;
using Cinema.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cinema.Data.Profiles
{
    public class SalleProfiles : Profile
    {
        public SalleProfiles()
        {
            CreateMap<Salle, SalleDTOIn>();
            CreateMap<SalleDTOIn, Salle>();
            CreateMap<Salle, SalleDTOOut>();
            CreateMap<SalleDTOOut, Salle>();
        }
    }
}
