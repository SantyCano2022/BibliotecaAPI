using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dtos
{
    public class CrearUsuarioDto
    {
        public string Nombre { get; set; } = null!;
        public string Cedula { get; set; } = null!;
        public int RolId { get; set; }
    }
}
