using AutoMapper;
using Cinema.Data.DTOs;
using Cinema.Data.Models;
using Cinema.Data.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cinema.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class SeanceController : ControllerBase
    {
        private readonly SeanceServices _service;
        private readonly IMapper _mapper;

        public SeanceController(SeanceServices service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        //GET api/Seance

        [HttpGet]
        public ActionResult<IEnumerable<SeanceDTOOut>> GetAllSeance()
        {
            IEnumerable<Seance> listeSeance = _service.GetAllSeance();
            return Ok(_mapper.Map<IEnumerable<SeanceDTOOut>>(listeSeance));
        }

        //GET api/Seance/{i}

        [HttpGet("{id}", Name = "GetSeanceById")]
        public ActionResult<SeanceDTOOut> GetSeanceById(int id)
        {
            Seance commandItem = _service.GetSeanceById(id);
            if (commandItem != null)
            {
                return Ok(_mapper.Map<SeanceDTOOut>(commandItem));
            }
            return NotFound();
        }

        //POST api/Seance

        [HttpPost]
        public ActionResult<SeanceDTOIn> CreateSeance(SeanceDTOOut obj)
        {
            _service.AddSeance(_mapper.Map<Seance>(obj));
            return CreatedAtRoute(nameof(GetSeanceById), new { Id = obj.IdSeance }, obj);
        }

        //POST api/Seance/{id}

        [HttpPut("{id}")]
        public ActionResult UpdateSeance(int id, SeanceDTOOut obj)
        {
            Seance objFromRepo = _service.GetSeanceById(id);
            if (objFromRepo == null)
            {
                return NotFound();
            }
            _mapper.Map(obj, objFromRepo);
            _service.UpdateSeance(objFromRepo);
            return NoContent();
        }



        //DELETE api/Seance/{id}

        [HttpDelete("{id}")]
        public ActionResult DeleteSeance(int id)
        {
            Seance obj = _service.GetSeanceById(id);
            if (obj == null)
            {
                return NotFound();
            }
            _service.DeleteSeance(obj);
            return NoContent();
        }


    }
}
