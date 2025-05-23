using Interfaces;
using Microsoft.AspNetCore.Mvc;
using UseCases;

namespace BibliotecaAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RolController : Controller
    {
        private readonly IRolServices _rolService;
        public RolController(IRolServices rolService)
        {
            _rolService = rolService;
        }

        [HttpGet("ObtenerRoles")]
        public async Task<IActionResult> ObtenerRoles()
        {
            var result = await _rolService.ObtenerRoles();
            if (result == null || !result.Any())
            {
                return NotFound("No se encontraron Roles.");
            }
            return Ok(result);

        }
    }

}
