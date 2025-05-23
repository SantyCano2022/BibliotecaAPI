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
    public class RolService : IRolServices
    {
        private readonly IApplicationContext _context;

        public RolService(IApplicationContext context)
        {
            _context = context;
        }

        public async Task<List<Rol>> ObtenerRoles()
        {
            return await _context.Rol.ToListAsync();

        }
    }
}
