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

    [Route("api/[Agence]")]
    [ApiController]
    public class AgenceController : ControllerBase
    {

        private readonly AgenceServices _service;
        private readonly IMapper _mapper;

        public AgenceController(AgenceServices service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        //GET api/Agence
        [HttpGet]
        public ActionResult<IEnumerable<AgenceDtosAvecApparteniragence>> GetAllAgence()
        {
            IEnumerable<Agence> listeAgence = _service.GetAllAgence();
            return Ok(_mapper.Map<IEnumerable<AgenceDtosAvecApparteniragence>>(listeAgence));
        }

        //GET api/Agence/{i}
        [HttpGet("{id}", Name = "GetAgenceById")]
        public ActionResult<AgenceDtosAvecApparteniragence> GetAgenceById(int id)
        {
            Agence commandItem = _service.GetAgenceById(id);
            if (commandItem != null)
            {
                return Ok(_mapper.Map<AgenceDtosAvecApparteniragence>(commandItem));
            }
            return NotFound();
        }

        //POST api/Agence
        [HttpPost]
        public ActionResult<AgenceDtosOut> CreateAgence(AgenceDtosIn obj)
        {
            Agence newAgence = _mapper.Map<Agence>(obj);
            _service.AddAgence(newAgence);
            return CreatedAtRoute(nameof(GetAgenceById), new { Id = newAgence.IdAgence }, newAgence);
        }

        //POST api/Agence/{id}
        [HttpPut("{id}")]
        public ActionResult UpdateAgence(int id, AgenceDtosIn obj)
        {
            Agence objFromRepo = _service.GetAgenceById(id);
            if (objFromRepo == null)
            {
                return NotFound();
            }
            _mapper.Map(obj, objFromRepo);
            _service.UpdateAgence(objFromRepo);
            return NoContent();
        }

        // Exemple d'appel
        // [{
        // "op":"replace",
        // "path":"",
        // "value":""
        // }]
        //PATCH api/Agence/{id}
        [HttpPatch("{id}")]
        public ActionResult PartialAgenceUpdate(int id, JsonPatchDocument<Agence> patchDoc)
        {
            Agence objFromRepo = _service.GetAgenceById(id);
            if (objFromRepo == null)
            {
                return NotFound();
            }
            Agence objToPatch = _mapper.Map<Agence>(objFromRepo);
            patchDoc.ApplyTo(objToPatch, ModelState);
            if (!TryValidateModel(objToPatch))
            {
                return ValidationProblem(ModelState);
            }
            _mapper.Map(objToPatch, objFromRepo);
            _service.UpdateAgence(objFromRepo);
            return NoContent();
        }

        //DELETE api/Agence/{id}
        [HttpDelete("{id}")]
        public ActionResult DeleteAgence(int id)
        {
            Agence obj = _service.GetAgenceById(id);
            if (obj == null)
            {
                return NotFound();
            }
            _service.DeleteAgence(obj);
            return NoContent();
        }
    }
}




