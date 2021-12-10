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
    class PaysProfile : Profile
    {
        public PaysProfile()
        {
            CreateMap<Pays, PaysDTOIn>();
            CreateMap<PaysDTOIn, Pays>();
            CreateMap<Pays, PaysDTOOut>();
            CreateMap<PaysDTOOut, Pays>();
        }
    }
}
