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
    class RolesProfile : Profile
    {
        public RolesProfile()
        {
            CreateMap<Roles, RolesDTOIn>();
            CreateMap<RolesDTOIn, Roles>();
            CreateMap<Roles, RolesDTOOut>();
            CreateMap<RolesDTOOut, Roles>();
        }
    }
}
