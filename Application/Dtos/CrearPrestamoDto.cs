using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dtos
{
    public class CrearPrestamoDto
    {
        public int UsuarioId { get; set; }
        public int MaterialId { get; set; }
        public int CantidadPrestada { get; set; }
    }
}
