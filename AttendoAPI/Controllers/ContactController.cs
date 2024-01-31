using AttendoAPI.Comunes.Clasess.Contratos.Contacts;
using AttendoAPI.Dominio.Attendo.Contacts;
using AttendoAPI.Dominio.Attendo.General;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AttendoAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ContactController : Controller
    {
        private readonly IAttendoService<ContactContract> _servicio;
        private readonly IContactService _contactoService;
        public ContactController(IAttendoService<ContactContract> servicio, IContactService contactoService)
        {
            _servicio = servicio;
            _contactoService = contactoService;
        }

        [HttpGet]
        public async Task<IActionResult> ObtenerContactos()
        {
            return Ok(await _servicio.GetAll());
        }

        [HttpGet("byID/{id}")]
        public async Task<IActionResult> ContactoPorId(int id)
        {
            return Ok(await _servicio.GetById(id));
        }

        [HttpGet("byName/{name}")]
        public async Task<IActionResult> ContactoPorNombre(string name)
        {
            return Ok(await _contactoService.GetByName(name));
        }
    }
}

