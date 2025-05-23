using Dtos;
using Entities;
using Interfaces;
using Microsoft.AspNetCore.Mvc;
using UseCases;

namespace BibliotecaAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MaterialController : Controller
    {
        private readonly IMaterialServices _materialService;
        public MaterialController(IMaterialServices materialService)
        {
            _materialService = materialService;
        }

        [HttpGet("ObtenerMateriales")]
        public async Task<IActionResult> ObtenerMateriales()
        {
            var result = await _materialService.GetAllMaterialsAsync();
            if (result == null || !result.Any())
            {
                return NotFound(new { message = "No se encontraron materiales." });
            }
            return Ok(result);
        }

        [HttpPost("RegistrarMaterial")]
        public async Task<IActionResult> RegistrarMaterial([FromBody] CrearMaterialDto dto)
        {
            if (dto == null)
            {
                return BadRequest(new { message = "El material no puede ser nulo." });
            }

            var material = new Material
            {
                Titulo = dto.Titulo,
                NroIdentificacion = dto.NroIdentificacion,
                FechaRegistro = DateOnly.FromDateTime(DateTime.Now),
                CantidadRegistrada = dto.CantidadRegistrada,
                CantidadActual = dto.CantidadActual,
                TipoMaterialId = dto.TipoMaterialId,
                Estado = true
            };

            var result = await _materialService.AddMaterialAsync(material);
            if (result == "El numero de material ya existe.")
            {
                return Conflict(new { message = result });
            }

            return Ok(new { message = result });
        }

        [HttpPut("ActualizarMaterial")]
        public async Task<IActionResult> ActualizarMaterial([FromBody] MaterialActualizarDto materialDto)
        {
            if (materialDto == null)
            {
                return BadRequest(new { message = "Los datos del material no pueden ser nulos." });
            }

            bool actualizado = await _materialService.UpdateMaterialAsync(materialDto);
            if (!actualizado)
            {
                return NotFound(new { message = "No se pudo actualizar el material." });
            }

            return Ok(new { message = "Material actualizado correctamente." });
        }



    }

}
