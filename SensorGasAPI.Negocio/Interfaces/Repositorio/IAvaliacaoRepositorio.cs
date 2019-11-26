using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using SensorGasAPI.Negocio;

namespace SensorGasAPI.Negocio
{
    public interface IRegistroEmissaoRepositorio
    {
        #region Tela de Avaliação do Paciente

        Task<IEnumerable<RegistroEmissao>> ListaRegistroEmissao(int aIdRegistroEmissao);
        Task<IEnumerable<RegistroEmissao>> ListaRegistroEmissao(DateTime aDataInicio, DateTime aDataFim);
        Task<RegistroEmissao> RecuperarRegistroEmissao(int aIdRegistroEmissao);
        Task SalvarRegistroEmissao(RegistroEmissao aAvaliacaoPaciente);
        Task SalvarRegistroEmissao(int aIdIndicadorEmissao);

        #endregion

    }

}