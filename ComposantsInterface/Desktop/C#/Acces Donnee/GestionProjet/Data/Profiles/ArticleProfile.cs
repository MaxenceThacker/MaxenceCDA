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
    class ArticleProfile : Profile
    {
        public ArticleProfile()
        {
            CreateMap<Article, ArticleDtosIn>();
            CreateMap<ArticleDtosIn, Article>();

            CreateMap<Article, ArticleDtosOut>();
            CreateMap<ArticleDtosOut, Article>();

            CreateMap<Article, ArticleDtosAvecCategory>();
            CreateMap<ArticleDtosAvecCategory, Article>();
        }
    }
}
