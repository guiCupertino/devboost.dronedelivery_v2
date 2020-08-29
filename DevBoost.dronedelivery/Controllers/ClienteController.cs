using System.Collections.Generic;
using System.Threading.Tasks;
using DevBoost.DroneDelivery.Domain.Entities;
using DevBoost.DroneDelivery.Domain.Interfaces.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DevBoost.dronedelivery.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        private readonly IClienteServices _clienteServices;

        public ClienteController(IClienteServices clienteServices)
        {
            _clienteServices = clienteServices;
        }

        [HttpGet, Authorize(Roles = "ADMIN,USER")]
        public async Task<ActionResult<IEnumerable<Cliente>>> GetClientes()
        {
            return Ok(await _clienteServices.GetAll());
        }

        [HttpPost, Authorize(Roles = "ADMIN,USER")]
        public async Task<ActionResult> InsertCliente(Cliente cliente)
        {
            if (await _clienteServices.Insert(cliente))
                return Ok();

            return BadRequest();
        }

    }
}