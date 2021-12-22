using AutoMapper;
using ECF.Data.DTOs;
using ECF.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECF.Data.Profiles
{
    class GroupesProfiles : Profile 
    {
        public GroupesProfiles()
        {
            CreateMap<GroupesDTOIn, Groupe>();
            CreateMap<Groupe, GroupesDTOIn>();
            CreateMap<Groupe, GroupesDTOOut>();
            CreateMap<GroupesDTOOut, Groupe>();
            CreateMap<Groupe, GroupesDTOOutAvecMusiciens>();
            CreateMap<GroupesDTOOutAvecMusiciens, Groupe>();

        }
    }
}
