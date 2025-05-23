using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dtos;
using Entities;

namespace Interfaces
{
    public interface IUsuarioServices 
    {
        Task<List<ConsultarUsuarioDto>> ObtenerUsuarios();
        Task<string> RegistrarUsuario(Usuario usuario);
        Task<bool> EliminarUsuario(int idusuario);
    }
}
