﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using SensorGasAPI.Negocio;

namespace SensorGasAPI.Negocio
{
    public interface IEspecialidadeProfissionalService
    {
        Task<IEnumerable<EspecialidadeDados>> TodasEspecialidades();
        Task<IEnumerable<EspecialidadeDados>> ListarEspecialidades(long? aCodigoClasseProfissional);
    }
}