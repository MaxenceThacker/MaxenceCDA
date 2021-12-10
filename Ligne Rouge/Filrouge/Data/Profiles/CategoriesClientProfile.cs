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
    class CategoriesClientProfile : Profile
    {
        public CategoriesClientProfile()
        {
            CreateMap<CategoriesClient, CategoriesClientDTOIn>();
            CreateMap<CategoriesClientDTOIn, CategoriesClient>();
            CreateMap<CategoriesClient, CategoriesClientDTOOut>();
            CreateMap<CategoriesClientDTOOut, CategoriesClient>();
        }
    }
}
