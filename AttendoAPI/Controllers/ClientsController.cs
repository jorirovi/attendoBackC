using AttendoAPI.Comunes.Clasess.Contratos.Clients;
using AttendoAPI.Dominio.Attendo.Clients;
using AttendoAPI.Dominio.Attendo.General;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AttendoAPI.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class ClientsController : Controller
    {
        private readonly IAttendoService<ClientsContract> _servicio;
        private readonly IClientsService _clienteServicio;
        public ClientsController(IAttendoService<ClientsContract> servicio, IClientsService clienteService)
        {
            _servicio = servicio;
            _clienteServicio = clienteService;
        }

        [HttpGet]
        public async Task<IActionResult> ObtenerClientes()
        {
            return Ok(await _servicio.GetAll());
        }

        [HttpGet("ByName/{name}")]
        public async Task<IActionResult> ObtenerClientesPorNombre(string name)
        {
            return Ok(await _clienteServicio.GetClientsByName(name));
        }

        [HttpGet("Contacto/{name}")]
        public async Task<IActionResult> ObtenerContactoCliente(string name)
        {
            return Ok(await _clienteServicio.GetClientesContact(name));
        }

        [HttpGet("ClienteContactos")]
        public async Task<IActionResult> ObtenerClientesContacto()
        {
            return Ok(await _clienteServicio.GetlistClients());
        }
    }
}

