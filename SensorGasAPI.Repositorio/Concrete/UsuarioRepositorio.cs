using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SensorGasAPI.Negocio;

namespace SensorGasAPI.Repositorio
{
    public class UsuarioRepositorio : IUsuarioRepositorio
    {
        public async Task<LoginProjecao> ValidarLogin(UsuarioDados aUsuario)
        {
            await Task.Delay(TimeSpan.FromMilliseconds(0));
            return new UsuarioDAL().RecuperarLogin(aUsuario);
        }

    }
}