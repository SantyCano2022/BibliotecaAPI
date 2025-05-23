using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dtos;
using Entities;

namespace Interfaces
{
    public interface IMaterialServices
    {
        Task<List<ObtenerMaterialesDto>> GetAllMaterialsAsync();
        Task<string> AddMaterialAsync(Material material);
        Task<bool> UpdateMaterialAsync(MaterialActualizarDto materialDto);
    }
}
