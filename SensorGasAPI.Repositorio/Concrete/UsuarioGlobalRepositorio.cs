using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SensorGasAPI.Negocio;

namespace SensorGasAPI.Repositorio
{
    public class UsuarioGlobalRepositorio : IUsuarioGlobalRepositorio
    {
        public async Task<UsuarioGlobalDados> CheckUsuarioGlobal()
        {
            await Task.Delay(TimeSpan.FromMilliseconds(0));
            return new UsuarioGlobalDAL().CheckUsuarioGlobal();
        }

        public async Task InserirUsuarioGlobal(UsuarioGlobalDados aUsuarioGlobal)
        {
            await Task.Delay(TimeSpan.FromMilliseconds(0));
            new UsuarioGlobalDAL().InserirUsuarioGlobal(aUsuarioGlobal);
        }

    }
}