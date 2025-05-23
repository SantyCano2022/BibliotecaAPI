using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dtos
{
    public class CrearMaterialDto
    {
        public string Titulo { get; set; } = null!;
        public string NroIdentificacion { get; set; } = null!;
        public int CantidadRegistrada { get; set; }
        public int CantidadActual { get; set; }
        public int TipoMaterialId { get; set; }
    }
}
