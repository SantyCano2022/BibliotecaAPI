using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dtos;

namespace Interfaces
{
    public interface IPrestamoServices
    {
        Task<string> AddPrestamoAsync(CrearPrestamoDto dto);
        Task<List<ResponseHistorialBibliotecaDto>> ObtenerHistorialBibliotecaAsync();
    }
}
