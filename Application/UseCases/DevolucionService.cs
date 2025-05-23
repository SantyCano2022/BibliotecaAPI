using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using Interfaces;
using Microsoft.EntityFrameworkCore;

namespace UseCases
{
    public class DevolucionService : IDevolucionServices
    {
        private readonly IApplicationContext _context;

        public DevolucionService(IApplicationContext context)
        {
            _context = context;
        }

        public async Task<string> AddDevolucionAsync(Devolucion devolucion)
        {
            var prestamo = await _context.Prestamo
                .FirstOrDefaultAsync(p => p.Id == devolucion.PrestamoId);

            if (prestamo == null)
            {
                return "El préstamo no existe.";
            }

            var material = await _context.Material
                .FirstOrDefaultAsync(m => m.Id == prestamo.MaterialId);

            if (material == null)
            {
                return "El material asociado al préstamo no existe.";
            }

            _context.Devolucion.Add(devolucion);
            await _context.SaveChangesAsync();

            prestamo.Estado = false;
            _context.Prestamo.Update(prestamo);
            await _context.SaveChangesAsync();

            material.CantidadActual += prestamo.CantidadPrestada;
            _context.Material.Update(material);
            await _context.SaveChangesAsync();

            return "Devolución registrada y cantidad de material actualizada correctamente.";
        }
    }
}
