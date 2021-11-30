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
    [Route("api/Clients")]

    [ApiController]
    public class ClientsControllers : ControllerBase 
    {
        private readonly ClientsServices _service;
        private readonly IMapper _mapper;
        public ClientsControllers(ClientsServices service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        [HttpGet]
        public ActionResult<IEnumerable<ClientsDtosOut>> GetAllClients()
        {
            IEnumerable<Client> listeClients = _service.GetAllClient();
            return Ok(_mapper.Map<IEnumerable<ClientsDtosOut>>(listeClients));
        }
    }
}
