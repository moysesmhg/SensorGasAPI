using System.Collections.Generic;
using System.Threading.Tasks;
using SensorGasAPI.Negocio;


namespace SensorGasAPI.Negocio
{
    public class EspecialidadeProfissionalService : IEspecialidadeProfissionalService
    {
        private readonly IEspecialidadeProfissionalRepositorio _repository;

        public EspecialidadeProfissionalService(IEspecialidadeProfissionalRepositorio repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<EspecialidadeDados>> TodasEspecialidades()
        {
            return await _repository.TodasEspecialidades();
        }

        public async Task<IEnumerable<EspecialidadeDados>> ListarEspecialidades(long? aCodigoClasseProfissional)
        {
            return await _repository.ListarEspecialidades(aCodigoClasseProfissional);
        }
    }

}