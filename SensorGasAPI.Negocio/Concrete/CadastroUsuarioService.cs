using System.Collections.Generic;
using System.Threading.Tasks;
using SensorGasAPI.Negocio;

namespace SensorGasAPI.Negocio
{
    public class CadastroUsuarioService : ICadastroUsuarioService
    {
        private readonly ICadastroUsuarioRepositorio _repository;
        public CadastroUsuarioService(ICadastroUsuarioRepositorio repository)
        {
            _repository = repository;
        }
        
        public async Task Insert(CadastroUsuarioProjecao aCadastroUsuario)
        {
            await _repository.Insert(aCadastroUsuario);
        }

        public async Task Update(CadastroUsuarioProjecao aCadastroUsuario)
        {
             await _repository.Update(aCadastroUsuario);
        }
    }
}