using AutoMapper;
using Aviation.Data.Dtos;
using Aviation.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aviation.Data.Profiles
{
    public class AvionProfile : Profile
    {
        public AvionProfile()
        {
            CreateMap<Avion, AvionDtosIn>();
            CreateMap<AvionDtosIn, Avion>();

            CreateMap<Avion, AvionDtosOut>();
            CreateMap<AvionDtosOut, Avion>();

            CreateMap<Avion, AvionDtosAvecAgence>();
            CreateMap<AvionDtosAvecAgence, Avion>();

        }
    }
}
