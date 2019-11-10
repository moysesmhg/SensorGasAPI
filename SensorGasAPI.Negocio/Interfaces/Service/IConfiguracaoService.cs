using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using SensorGasAPI.Negocio;

namespace SensorGasAPI.Negocio
{
    public interface IConfiguracaoService
    {

        #region Tela de Detalhe do Profissional

        Task<ConfiguracaoConsultaDados> RecuperarPrecoConsulta(long aCodigoProfissional);

        #endregion

    }
}