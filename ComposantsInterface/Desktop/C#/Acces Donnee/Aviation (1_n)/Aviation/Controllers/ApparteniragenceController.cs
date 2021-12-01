using AutoMapper;
using Aviation.Data.Dtos;
using Aviation.Data.Models;
using Aviation.Data.Services;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aviation.Controllers
{
    [Route("api/[Apparteniragence]")]
    [ApiController]
    public class ApparteniragenceController : ControllerBase
    {

        private readonly ApparteniragenceServices _service;
        private readonly IMapper _mapper;

        public ApparteniragenceController(ApparteniragenceServices service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        //GET api/Apparteniragence
        [HttpGet]
        public ActionResult<IEnumerable<ApparteniragenceDtosAvecAgenceEtClient>> GetAllApparteniragence()
        {
            IEnumerable<Apparteniragence> listeApparteniragence = _service.GetAllApparteniragence();
            return Ok(_mapper.Map<IEnumerable<ApparteniragenceDtosAvecAgenceEtClient>>(listeApparteniragence));
        }

        //GET api/Apparteniragence/{i}
        [HttpGet("{id}", Name = "GetApparteniragenceById")]
        public ActionResult<ApparteniragenceDtosAvecAgenceEtClient> GetApparteniragenceById(int id)
        {
            Apparteniragence commandItem = _service.GetApparteniragenceById(id);
            if (commandItem != null)
            {
                return Ok(_mapper.Map<ApparteniragenceDtosAvecAgenceEtClient>(commandItem));
            }
            return NotFound();
        }

        //POST api/Apparteniragence
        [HttpPost]
        public ActionResult<ApparteniragenceDtosOut> CreateApparteniragence(ApparteniragenceDtosIn obj)
        {
            Apparteniragence newApparteniragence = _mapper.Map<Apparteniragence>(obj);
            _service.AddApparteniragence(newApparteniragence);
            return CreatedAtRoute(nameof(GetApparteniragenceById), new { Id = newApparteniragence.IdAppartenirAgences }, newApparteniragence);
        }

        //POST api/Apparteniragence/{id}
        [HttpPut("{id}")]
        public ActionResult UpdateApparteniragence(int id, ApparteniragenceDtosIn obj)
        {
            Apparteniragence objFromRepo = _service.GetApparteniragenceById(id);
            if (objFromRepo == null)
            {
                return NotFound();
            }
            _mapper.Map(obj, objFromRepo);
            _service.UpdateApparteniragence(objFromRepo);
            return NoContent();
        }

        // Exemple d'appel
        // [{
        // "op":"replace",
        // "path":"",
        // "value":""
        // }]
        //PATCH api/Apparteniragence/{id}
        [HttpPatch("{id}")]
        public ActionResult PartialApparteniragenceUpdate(int id, JsonPatchDocument<Apparteniragence> patchDoc)
        {
            Apparteniragence objFromRepo = _service.GetApparteniragenceById(id);
            if (objFromRepo == null)
            {
                return NotFound();
            }
            Apparteniragence objToPatch = _mapper.Map<Apparteniragence>(objFromRepo);
            patchDoc.ApplyTo(objToPatch, ModelState);
            if (!TryValidateModel(objToPatch))
            {
                return ValidationProblem(ModelState);
            }
            _mapper.Map(objToPatch, objFromRepo);
            _service.UpdateApparteniragence(objFromRepo);
            return NoContent();
        }

        //DELETE api/Apparteniragence/{id}
        [HttpDelete("{id}")]
        public ActionResult DeleteApparteniragence(int id)
        {
            Apparteniragence obj = _service.GetApparteniragenceById(id);
            if (obj == null)
            {
                return NotFound();
            }
            _service.DeleteApparteniragence(obj);
            return NoContent();
        }
    }
}
