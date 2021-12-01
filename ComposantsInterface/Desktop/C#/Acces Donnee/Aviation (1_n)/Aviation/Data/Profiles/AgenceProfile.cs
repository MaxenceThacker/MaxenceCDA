using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Aviation.Data.Dtos;
using Aviation.Data.Models;

namespace Aviation.Data.Profiles
{
    public class AgenceProfile : Profile
    { 
        public AgenceProfile()
        {
            CreateMap<Agence, AgenceDtosIn>();
            CreateMap<AgenceDtosIn, Agence>();

            CreateMap<Agence, AgenceDtosOut>();
            CreateMap<AgenceDtosOut, Agence>();

            CreateMap<Agence, AgenceDtosAvecApparteniragenceEtAvion>();
            CreateMap<AgenceDtosAvecApparteniragenceEtAvion, Agence>();

            CreateMap<Agence, AgenceDtosAvecApparteniragence>();
            CreateMap<AgenceDtosAvecApparteniragence, Agence>();

            CreateMap<Agence, AgenceDtosAvecAvion>();
            CreateMap<AgenceDtosAvecAvion, Agence>();
        }
    }
}
        

