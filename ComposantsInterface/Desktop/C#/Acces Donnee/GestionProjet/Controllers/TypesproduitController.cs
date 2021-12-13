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
    [Route("api/Typesproduit")]
    [ApiController]

    public class TypesproduitController : ControllerBase
    {

        private readonly TypesproduitService _service;
        private readonly IMapper _mapper;

        public TypesproduitController(MyDbContext _context)
        {
            _service = new TypesproduitService(_context);
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<TypesproduitProfile>();
            });
            _mapper = config.CreateMapper();
        }

        //GET api/Typesproduit
        [HttpGet]
        public ActionResult<IEnumerable<TypesproduitDtosAvecCategory>> GetAllTypesproduit()
        {
            IEnumerable<Typesproduit> listeTypesproduit = _service.GetAllTypesproduit();
            return Ok(_mapper.Map<IEnumerable<TypesproduitDtosAvecCategory>>(listeTypesproduit));
        }

        //GET api/Typesproduit/{i}
        [HttpGet("{id}", Name = "GetTypesproduitById")]
        public ActionResult<TypesproduitDtosAvecCategory> GetTypesproduitById(int id)
        {
            Typesproduit commandItem = _service.GetTypesproduitById(id);
            if (commandItem != null)
            {
                return Ok(_mapper.Map<TypesproduitDtosAvecCategory>(commandItem));
            }
            return NotFound();
        }

        //POST api/Typesproduit
        [HttpPost]
        public ActionResult<TypesproduitDtosAvecCategory> CreateTypesproduit(Typesproduit obj)
        {
            _service.AddTypesproduit(obj);
            return CreatedAtRoute(nameof(GetTypesproduitById), new { Id = obj.IdTypesProduits }, obj);
        }

        //POST api/Typesproduit/{id}
        [HttpPut("{id}")]
        public ActionResult UpdateTypesproduit(int id, TypesproduitDtosAvecCategory obj)
        {
            Typesproduit objFromRepo = _service.GetTypesproduitById(id);
            if (objFromRepo == null)
            {
                return NotFound();
            }
            _mapper.Map(obj, objFromRepo);
            _service.UpdateTypesproduit(objFromRepo);
            return NoContent();
        }

        // Exemple d'appel
        // [{
        // "op":"replace",
        // "path":"",
        // "value":""
        // }]
        //PATCH api/Typesproduit/{id}
        [HttpPatch("{id}")]
        public ActionResult PartialTypesproduitUpdate(int id, JsonPatchDocument<Typesproduit> patchDoc)
        {
            Typesproduit objFromRepo = _service.GetTypesproduitById(id);
            if (objFromRepo == null)
            {
                return NotFound();
            }
            Typesproduit objToPatch = _mapper.Map<Typesproduit>(objFromRepo);
            patchDoc.ApplyTo(objToPatch, ModelState);
            if (!TryValidateModel(objToPatch))
            {
                return ValidationProblem(ModelState);
            }
            _mapper.Map(objToPatch, objFromRepo);
            _service.UpdateTypesproduit(objFromRepo);
            return NoContent();
        }

        //DELETE api/Typesproduit/{id}
        [HttpDelete("{id}")]
        public ActionResult DeleteTypesproduit(int id)
        {
            Typesproduit obj = _service.GetTypesproduitById(id);
            if (obj == null)
            {
                return NotFound();
            }
            _service.DeleteTypesproduit(obj);
            return NoContent();
        }
    }
}
