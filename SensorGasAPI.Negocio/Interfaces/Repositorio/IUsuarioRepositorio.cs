﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using SensorGasAPI.Negocio;

namespace SensorGasAPI.Negocio
{
    public interface IUsuarioRepositorio
    {
        Task<LoginProjecao> ValidarLogin(UsuarioDados aUsuario);
        
    }
}