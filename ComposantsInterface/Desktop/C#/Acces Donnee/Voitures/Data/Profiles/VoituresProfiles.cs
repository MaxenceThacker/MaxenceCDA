using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Voitures.Data.Dtos;
using Voitures.Data.Models;

namespace Voitures.Data.Profiles
{
    public class VoituresProfiles : Profile 
    {
        public VoituresProfiles()
        {
            CreateMap<Voiture, VoituresDtosIn>();
            CreateMap<VoituresDtosIn, Voiture>();
        }
    }
}
