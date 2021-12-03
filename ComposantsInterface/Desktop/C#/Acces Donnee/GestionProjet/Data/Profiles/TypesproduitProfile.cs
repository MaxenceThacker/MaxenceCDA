using AutoMapper;
using GestionProjet.Data.Dtos;
using GestionProjet.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionProjet.Data.Profiles
{
    class TypesproduitProfile : Profile
    {
        public TypesproduitProfile()
        {
            CreateMap<Typesproduit, TypesproduitDtosIn>();
            CreateMap<TypesproduitDtosIn, Typesproduit>();

            CreateMap<Typesproduit, TypesproduitDtosOut>();
            CreateMap<TypesproduitDtosOut, Typesproduit>();

            CreateMap<Typesproduit, TypesproduitDtosAvecCategory>();
            CreateMap<TypesproduitDtosAvecCategory, Typesproduit>();
        }
    }
}
