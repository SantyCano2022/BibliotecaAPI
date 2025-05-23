using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using Microsoft.EntityFrameworkCore;

namespace Interfaces
{
    public interface IApplicationContext
    {
        DbSet<Devolucion> Devolucion { get; set; }

        DbSet<Material> Material { get; set; }

        DbSet<Prestamo> Prestamo { get; set; }

        DbSet<Rol> Rol { get; set; }

        DbSet<TipoMaterial> TipoMaterial { get; set; }

        DbSet<Usuario> Usuario { get; set; }

        Task<int> SaveChangesAsync();
    }
}
