using System.Collections.Generic;
using System.Threading.Tasks;

namespace SensorGasAPI.Negocio
{
    public class CadastroProfissionalService : ICadastroProfissionalService
    {
        private readonly ICadastroProfissionalRepositorio _repository;
        public CadastroProfissionalService(ICadastroProfissionalRepositorio repository)
        {
            _repository = repository;
        }

        public async Task Insert(CadastroProfissionalProjecao aCadastroProfissional)
        {
            await _repository.Insert(aCadastroProfissional);
        }

        public async Task Update(CadastroProfissionalProjecao aCadastroProfissional)
        {
            await _repository.Update(aCadastroProfissional);
        }
    }
}