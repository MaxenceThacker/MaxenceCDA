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
    [Route("api/[Client]")]
    [ApiController]
    public class ClientController : ControllerBase
    {

        private readonly ClientServices _service;
        private readonly IMapper _mapper;

        public ClientController(ClientServices service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        //GET api/Client
        [HttpGet]
        public ActionResult<IEnumerable<ClientDtosAvecApparteniragence>> GetAllClient()
        {
            IEnumerable<Client> listeClient = _service.GetAllClient();
            return Ok(_mapper.Map<IEnumerable<ClientDtosAvecApparteniragence>>(listeClient));
        }

        //GET api/Client/{i}
        [HttpGet("{id}", Name = "GetClientById")]
        public ActionResult<ClientDtosAvecApparteniragence> GetClientById(int id)
        {
            Client commandItem = _service.GetClientById(id);
            if (commandItem != null)
            {
                return Ok(_mapper.Map<ClientDtosAvecApparteniragence>(commandItem));
            }
            return NotFound();
        }

        //POST api/Client
        [HttpPost]
        public ActionResult<ClientDtosOut> CreateClient(ClientDtosIn obj)
        {
            Client newClient = _mapper.Map<Client>(obj);
            _service.AddClient(newClient);
            return CreatedAtRoute(nameof(GetClientById), new { Id = newClient.IdClient }, newClient);
        }

        //POST api/Client/{id}
        [HttpPut("{id}")]
        public ActionResult UpdateClient(int id, ClientDtosIn obj)
        {
            Client objFromRepo = _service.GetClientById(id);
            if (objFromRepo == null)
            {
                return NotFound();
            }
            _mapper.Map(obj, objFromRepo);
            _service.UpdateClient(objFromRepo);
            return NoContent();
        }

        // Exemple d'appel
        // [{
        // "op":"replace",
        // "path":"",
        // "value":""
        // }]
        //PATCH api/Client/{id}
        [HttpPatch("{id}")]
        public ActionResult PartialClientUpdate(int id, JsonPatchDocument<Client> patchDoc)
        {
            Client objFromRepo = _service.GetClientById(id);
            if (objFromRepo == null)
            {
                return NotFound();
            }
            Client objToPatch = _mapper.Map<Client>(objFromRepo);
            patchDoc.ApplyTo(objToPatch, ModelState);
            if (!TryValidateModel(objToPatch))
            {
                return ValidationProblem(ModelState);
            }
            _mapper.Map(objToPatch, objFromRepo);
            _service.UpdateClient(objFromRepo);
            return NoContent();
        }

        //DELETE api/Client/{id}
        [HttpDelete("{id}")]
        public ActionResult DeleteClient(int id)
        {
            Client obj = _service.GetClientById(id);
            if (obj == null)
            {
                return NotFound();
            }
            _service.DeleteClient(obj);
            return NoContent();
        }
    }
