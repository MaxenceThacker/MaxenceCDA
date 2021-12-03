using AutoMapper;
using GestionProjet.Data.Dtos;
using GestionProjet.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionProjet.Data.Profiles
{
    class CategoryProfile : Profile
    {
        public CategoryProfile()
        {
            CreateMap<Category, CategoryDtosIn>();
            CreateMap<CategoryDtosIn, Category>();

            CreateMap<Category, CategoryDtosOut>();
            CreateMap<CategoryDtosOut, Category>();

            CreateMap<Category, CategoryDtosAvecProduit>();
            CreateMap<CategoryDtosAvecProduit, Category>();

            CreateMap<Category, CategoryDtosAvecProduitEtArticle>();
            CreateMap<CategoryDtosAvecProduitEtArticle, Category>();

            CreateMap<Category, CategoryDtosAvecArticle>();
            CreateMap<CategoryDtosAvecArticle, Category>();
        }
    }
}
