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
    class RubriquesProfile : Profile
    {
        public RubriquesProfile()
        {
            CreateMap<Rubriques, RubriquesDTOIn>();
            CreateMap<RubriquesDTOIn, Rubriques>();
            CreateMap<Rubriques, RubriquesDTOOut>();
            CreateMap<RubriquesDTOOut, Rubriques>();
            CreateMap<Rubriques, RubriquesRubriquesMereDTOOut>();
            CreateMap<RubriquesRubriquesMereDTOOut, Rubriques>();
        } 
    }
}
