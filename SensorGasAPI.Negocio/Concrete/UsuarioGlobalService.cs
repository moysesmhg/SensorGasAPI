using System.Collections.Generic;
using System.Threading.Tasks;
using SensorGasAPI.Negocio;

namespace SensorGasAPI.Negocio
{
    public class UsuarioGlobalService : IUsuarioGlobalService
    {
        private readonly IUsuarioGlobalRepositorio _repository;
        public UsuarioGlobalService(IUsuarioGlobalRepositorio repository)
        {
            _repository = repository;
        }

        public async Task<UsuarioGlobalDados> CheckUsuarioGlobal()
        {
            return await _repository.CheckUsuarioGlobal();
        }

        public async Task InserirUsuarioGlobal(UsuarioGlobalDados aUsuarioGlobal)
        {
            await _repository.InserirUsuarioGlobal(aUsuarioGlobal);
        }

    }

}