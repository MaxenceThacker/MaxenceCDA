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
    class AdressesProfile : Profile
    {
        public AdressesProfile()
        {
            CreateMap<Adresses, AdressesDTOIn>();
            CreateMap<AdressesDTOIn, Adresses>();
            CreateMap<Adresses, AdressesDTOOut>()
                .ForMember(d => d.LibelleVille, o => o.MapFrom(s => s.Villes.LibelleVille))
                .ForMember(d => d.CodePostal, o => o.MapFrom(s => s.Villes.CodePostal))
                .ForMember(d => d.IdPays, o => o.MapFrom(s => s.Pays.IdPays))
                .ForMember(d => d.NomPays, o => o.MapFrom(s => s.Pays.NomPays));
            CreateMap<AdressesDTOOut, Adresses>();
        }
    }
}
