using System.Collections.Generic;
using System.Threading.Tasks;
using SensorGasAPI.Negocio;

namespace SensorGasAPI.Negocio
{
    public class ProfissionaisService : IProfissionaisService
    {
        private readonly IProfissionaisRepositorio _repository;

        public ProfissionaisService(IProfissionaisRepositorio repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<ListaProfissionaisProjecao>> TodosProfissionais()
        {
            return await _repository.TodosProfissionais();
        }

        public async Task<IEnumerable<ListaProfissionaisProjecao>> ListarProfissionais(string aNomeProfissional,
                                                                                       long? aCodigoClasseProfissional,
                                                                                       long? aCodigoEspecialidadeProfissional)
        {
            return await _repository.ListarProfissionais(aNomeProfissional,
                                                         aCodigoClasseProfissional,
                                                         aCodigoEspecialidadeProfissional);
        }

        public async Task<DetalheProfissionalProjecao> DetalheProfissional(long aCodigoProfissional)
        {
            return await _repository.DetalheProfissional(aCodigoProfissional);
        }

        public async Task<string> RecuperarNomeProfissional(long aCodigoProfissional)
        {
            return await _repository.RecuperarNomeProfissional(aCodigoProfissional);
        }
    }
}