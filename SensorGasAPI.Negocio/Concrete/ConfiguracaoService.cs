using System.Collections.Generic;
using System.Threading.Tasks;

namespace SensorGasAPI.Negocio
{
    public class ConfiguracaoService : IConfiguracaoService
    {
        private readonly IConfiguracaoRepositorio _repository;
        public ConfiguracaoService(IConfiguracaoRepositorio repository)
        {
            _repository = repository;
        }

        public async Task<ConfiguracaoConsultaDados> RecuperarPrecoConsulta(long aCodigoProfissional)
        {
             return await _repository.RecuperarPrecoConsulta(aCodigoProfissional);
        }
    }
}