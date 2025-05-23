using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public partial class Rol
    {
        public int Id { get; set; }

        public string Nombre { get; set; } = null!;

        public bool Estado { get; set; }

    }
}
