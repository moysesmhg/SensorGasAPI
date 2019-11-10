using System;
using System.Threading.Tasks;
using SensorGasAPI.Negocio;

namespace SensorGasAPI.Repositorio
{
    public class ConfiguracaoRepositorio : IConfiguracaoRepositorio
    {

        #region Tela de Detalhe do Profissional

        public async Task<ConfiguracaoConsultaDados> RecuperarPrecoConsulta(long aCodigoProfissional)
        {
            await Task.Delay(TimeSpan.FromMilliseconds(0));
            return new ConfiguracaoDAL().RecuperarPrecoConsulta(aCodigoProfissional);
        }
       
        #endregion
    }
}