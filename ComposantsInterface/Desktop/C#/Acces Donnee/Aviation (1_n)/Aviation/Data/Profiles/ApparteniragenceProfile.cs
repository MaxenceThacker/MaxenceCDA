using AutoMapper;
using Aviation.Data.Dtos;
using Aviation.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aviation.Data.Profiles
{
    public class ApparteniragenceProfile : Profile
    {
        public ApparteniragenceProfile()
        {
            CreateMap<Apparteniragence, ApparteniragenceDtosIn>();
            CreateMap<ApparteniragenceDtosIn, Apparteniragence>();

            CreateMap<Apparteniragence, ApparteniragenceDtosOut>();
            CreateMap<ApparteniragenceDtosOut, Apparteniragence>();

            CreateMap<Apparteniragence, ApparteniragenceDtosAvecAgence>();
            CreateMap<ApparteniragenceDtosAvecAgence, Apparteniragence>();

            CreateMap<Apparteniragence, ApparteniragenceDtosAvecAgenceEtClient>();
            CreateMap<ApparteniragenceDtosAvecAgenceEtClient, Apparteniragence>();

            CreateMap<Apparteniragence, ApparteniragenceDtosAvecClient>();
            CreateMap<ApparteniragenceDtosAvecClient, Apparteniragence>();
        }
    }
}
