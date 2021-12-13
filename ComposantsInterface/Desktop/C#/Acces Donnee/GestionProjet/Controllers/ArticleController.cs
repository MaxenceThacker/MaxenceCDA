using AutoMapper;
using GestionProjet.Data.Dtos;
using GestionProjet.Data.Models;
using GestionProjet.Data.Profiles;
using GestionProjet.Data.Services;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionProjet.Controllers
{
    [Route("api/Article")]
    [ApiController]

    public class ArticleController : ControllerBase 
    {

        private readonly ArticleService _service;
        private readonly IMapper _mapper;

        public ArticleController(MyDbContext _context)
        {
            _service = new ArticleService(_context);
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<ArticleProfile>();
            });
            _mapper = config.CreateMapper();
        }

        //GET api/Article
        [HttpGet]
        public ActionResult<IEnumerable<ArticleDtosAvecCategory>> GetAllArticle()
        {
            IEnumerable<Article> listeArticle = _service.GetAllArticle();
            return Ok(_mapper.Map<IEnumerable<ArticleDtosAvecCategory>>(listeArticle));
        }

        //GET api/Article/{i}
        [HttpGet("{id}", Name = "GetArticleById")]
        public ActionResult<ArticleDtosAvecCategory> GetArticleById(int id)
        {
            Article commandItem = _service.GetArticleById(id);
            if (commandItem != null)
            {
                return Ok(_mapper.Map<ArticleDtosAvecCategory>(commandItem));
            }
            return NotFound();
        }

        //POST api/Article
        [HttpPost]
        public ActionResult<ArticleDtosAvecCategory> CreateArticle(Article obj)
        {
            _service.AddArticle(obj);
            return CreatedAtRoute(nameof(GetArticleById), new { Id = obj.IdArticles }, obj);
        }

        //POST api/Article/{id}
        [HttpPut("{id}")]
        public ActionResult UpdateArticle(int id, ArticleDtosAvecCategory obj)
        {
            Article objFromRepo = _service.GetArticleById(id);
            if (objFromRepo == null)
            {
                return NotFound();
            }
            _mapper.Map(obj, objFromRepo);
            _service.UpdateArticle(objFromRepo);
            return NoContent();
        }

        // Exemple d'appel
        // [{
        // "op":"replace",
        // "path":"",
        // "value":""
        // }]
        //PATCH api/Article/{id}
        [HttpPatch("{id}")]
        public ActionResult PartialArticleUpdate(int id, JsonPatchDocument<Article> patchDoc)
        {
            Article objFromRepo = _service.GetArticleById(id);
            if (objFromRepo == null)
            {
                return NotFound();
            }
            Article objToPatch = _mapper.Map<Article>(objFromRepo);
            patchDoc.ApplyTo(objToPatch, ModelState);
            if (!TryValidateModel(objToPatch))
            {
                return ValidationProblem(ModelState);
            }
            _mapper.Map(objToPatch, objFromRepo);
            _service.UpdateArticle(objFromRepo);
            return NoContent();
        }

        //DELETE api/Article/{id}
        [HttpDelete("{id}")]
        public ActionResult DeleteArticle(int id)
        {
            Article obj = _service.GetArticleById(id);
            if (obj == null)
            {
                return NotFound();
            }
            _service.DeleteArticle(obj);
            return NoContent();
        }


    }

}
