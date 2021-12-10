using AutoMapper;
using Filrouge.Data.Dtos;
using Filrouge.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filrouge.Data.Profiles
{
    class VillesProfile : Profile
    {
        public VillesProfile()
        {
            CreateMap<Villes, VillesDTOIn>();
            CreateMap<VillesDTOIn, Villes>();
            CreateMap<Villes, VillesDTOOut>()
                .ForMember(d => d.NomPays, o => o.MapFrom(s => s.Pays.NomPays));
            CreateMap<VillesDTOOut, Villes>();
        }
    }
}
