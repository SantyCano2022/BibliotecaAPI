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
    public class TipoMaterialService: ITipoMaterialServices
    {
        private readonly IApplicationContext _context;

        public TipoMaterialService(IApplicationContext context)
        {
            _context = context;
        }

        public async Task<List<TipoMaterial>> TipoMaterialActivo()
        {
            return await _context.TipoMaterial.Where(t => t.Estado == true).ToListAsync();
        }
    }
}
