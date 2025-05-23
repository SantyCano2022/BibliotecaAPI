using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public partial class Usuario
    {
        public int Id { get; set; }

        public string Nombre { get; set; } = null!;

        public string Cedula { get; set; } = null!;

        public int RolId { get; set; }

        public bool Estado { get; set; }
        public Rol Rol { get; set; } = null!;
    }
}
