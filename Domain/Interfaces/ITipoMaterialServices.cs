﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace Interfaces
{
    public interface ITipoMaterialServices
    {
        Task<List<TipoMaterial>> TipoMaterialActivo();
    }
}
