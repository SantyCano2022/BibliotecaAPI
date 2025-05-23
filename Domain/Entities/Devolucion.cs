using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public partial class Devolucion
    {
        public int Id { get; set; }

        public int PrestamoId { get; set; }

        public DateOnly FechaDevolucion { get; set; }

        public Prestamo Prestamo { get; set; } = null!;
    }
}
