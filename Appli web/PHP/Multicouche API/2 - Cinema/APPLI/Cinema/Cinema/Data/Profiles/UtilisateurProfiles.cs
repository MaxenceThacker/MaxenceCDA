using AutoMapper;
using Cinema.Data.DTOs;
using Cinema.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cinema.Data.Profiles
{
    public class UtilisateurProfiles : Profile
    {
        public UtilisateurProfiles()
        {
            CreateMap<Utilisateur, UtilisateurDTOIn>();
            CreateMap<UtilisateurDTOIn, Utilisateur>();
            CreateMap<Utilisateur, UtilisateurDTOOut>();
            CreateMap<UtilisateurDTOOut, Utilisateur>();
        }
    }
}
