using System.Collections.Generic;
using System.Threading.Tasks;
using SensorGasAPI.Negocio;

namespace SensorGasAPI.Negocio
{
    public class UsuarioService : IUsuarioService
    {
        private readonly IUsuarioRepositorio _repository;
        public UsuarioService(IUsuarioRepositorio repository)
        {
            _repository = repository;
        }

        public async Task<LoginProjecao> ValidarLogin(UsuarioDados aUsuario)
        {
            return await _repository.ValidarLogin(aUsuario);
        }

    }

}