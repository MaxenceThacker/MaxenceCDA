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
    class ReglementsProfile : Profile
    {
        public ReglementsProfile()
        {
            CreateMap<Reglements, ReglementsDTOIn>();
            CreateMap<ReglementsDTOIn, Reglements>();
            CreateMap<Reglements, ReglementsDTOOut>();
            CreateMap<ReglementsDTOOut, Reglements>();
        }
    }
}
