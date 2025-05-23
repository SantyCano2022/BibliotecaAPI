using Entities;
using Interfaces;
using Microsoft.AspNetCore.Mvc;
using UseCases;

namespace BibliotecaAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DevolucionController : Controller
    {
        private readonly IDevolucionServices _devolucionService;
        public DevolucionController(IDevolucionServices devolucionService)
        {
            _devolucionService = devolucionService;
        }

        [HttpPost("RegistrarDevolucion/{idPrestamo}")]
        public async Task<IActionResult> RegistrarDevolucion([FromRoute] int idPrestamo)
        {
            if (idPrestamo <= 0)
            {
                return BadRequest(new { message = "El IdPrestamo no es válido." });
            }

            try
            {
                var devolucion = new Devolucion
                {
                    PrestamoId = idPrestamo,
                    FechaDevolucion = DateOnly.FromDateTime(DateTime.UtcNow.Date)
                };

                var result = await _devolucionService.AddDevolucionAsync(devolucion);
                return Ok(new { message = result });
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Error interno del servidor: {ex.Message}");
            }
        }
    }

}
