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
    class TVAProfile : Profile
    {
        public TVAProfile()
        {
            CreateMap<TVA, TVADTOIn>();
            CreateMap<TVADTOIn, TVA>();
            CreateMap<TVA, TVADTOOut>();
            CreateMap<TVADTOOut, TVA>();
        }
    }
}
