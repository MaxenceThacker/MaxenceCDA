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
    class ProduitsProfile : Profile
    {
        public ProduitsProfile()
        {
            CreateMap<Produits, ProduitsDTOIn>();
            CreateMap<ProduitsDTOIn, Produits>();
            CreateMap<Produits, ProduitsDTOOut>()
                .ForMember(d => d.LibelleRubrique, o => o.MapFrom(s => s.Rubrique.LibelleRubrique));
            CreateMap<ProduitsDTOOut, Produits>();
        }
    }
}
