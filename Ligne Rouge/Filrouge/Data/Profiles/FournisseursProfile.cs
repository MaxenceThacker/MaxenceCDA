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
    class FournisseursProfile : Profile
    {
        public FournisseursProfile()
        {
            CreateMap<Fournisseurs, FournisseursDTOIn>();
            CreateMap<FournisseursDTOIn, Fournisseurs>();
            CreateMap<Fournisseurs, FournisseursDTOOut>();
            CreateMap<FournisseursDTOOut, Fournisseurs>();
        }
    }
}
