using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace Interfaces
{
    public interface IRolServices
    {
        Task<List<Rol>> ObtenerRoles();
    }
}
