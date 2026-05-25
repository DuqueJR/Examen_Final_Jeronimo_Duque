using FINAL_WEB_JERONIMO_DUQUE_RUIZ.Interfaces;
using FINAL_WEB_JERONIMO_DUQUE_RUIZ.Models.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace FINAL_WEB_JERONIMO_DUQUE_RUIZ.Controllers
{

    [ApiController]
    [Route("api/[controller]")]

    public class RespuestaController : Controller
    {
        private readonly IRespuestaService _service;

        public RespuestaController (IRespuestaService service)
        {
            _service = service;

        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody]CreatedRespuestaDTO dto)
        {
            var created = await _service.Create(dto);

            return created == null ? NotFound("Pregutna no encontrada o no disponible para responder") : Ok(created);

        }
    }
}
