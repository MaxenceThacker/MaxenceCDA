using AutoMapper;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Voitures.Data.Dtos;
using Voitures.Data.Models;
using Voitures.Data.Services;

namespace Voitures.Controllers
{
    [Route("api/Voitures")]

    [ApiController]
    public class VoituresControllers : ControllerBase
    {

        private readonly VoituresServices _service;
        private readonly IMapper _mapper;

        public VoituresControllers(VoituresServices service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        //GET api/Voitures
        [HttpGet]
        public ActionResult<IEnumerable<VoituresDtosOut>> GetAllVoitures()
        {
            IEnumerable<Voiture> listeVoitures = _service.GetAllVoitures();
            return Ok(_mapper.Map<IEnumerable<VoituresDtosOut>>(listeVoitures));
        }

        //GET api/Voitures/{i}
        [HttpGet("{id}", Name = "GetVoituresById")]
        public ActionResult<VoituresDtosIn> GetVoituresById(int id)
        {
            Voiture commandItem = _service.GetVoitureById(id);
            if (commandItem != null)
            {
                return Ok(_mapper.Map<VoituresDtosIn>(commandItem));
            }
            return NotFound();
        }

        //POST api/Voitures
        [HttpPost]
        public ActionResult<VoituresDtosIn> CreateVoitures(VoituresDtosIn obj)
        {
            _service.AddVoitures(_mapper.Map<Voiture>(obj));
            return CreatedAtRoute(nameof(GetVoituresById), new { id = obj.IdVoiture }, obj);
        }

        //POST api/Voitures/{id}
        [HttpPut("{id}")]
        public ActionResult UpdateVoitures(int id, VoituresDtosIn obj)
        {
            Voiture objFromRepo = _service.GetVoitureById(id);
            if (objFromRepo == null)
            {
                return NotFound();
            }
            _mapper.Map(obj, objFromRepo);
            _service.UpdateVoiture(objFromRepo);
            return NoContent();
        }

        //PATCH api/Voitures/{id}
        [HttpPatch("{id}")]
        public ActionResult PartialVoituresUpdate(int id, JsonPatchDocument<Voiture> patchDoc)
        {
            Voiture objFromRepo = _service.GetVoitureById(id);
            if (objFromRepo == null)
            {
                return NotFound();
            }
            Voiture objToPatch = _mapper.Map<Voiture>(objFromRepo);
            patchDoc.ApplyTo(objToPatch, ModelState);
            if (!TryValidateModel(objToPatch))
            {
                return ValidationProblem(ModelState);
            }
            _mapper.Map(objToPatch, objFromRepo);
            _service.UpdateVoiture(objFromRepo);
            return NoContent();
        }

        //DELETE api/Voitures/{id}
        [HttpDelete("{id}")]
        public ActionResult DeleteVoitures(int id)
        {
            Voiture obj = _service.GetVoitureById(id);
            if (obj == null)
            {
                return NotFound();
            }
            _service.DeleteVoitures(obj);
            return NoContent();
        }


    }
}
