using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using SensorGasAPI.Negocio;

namespace SensorGasAPI.Repositorio
{
    public class RegistroEmissaoRepositorio : IRegistroEmissaoRepositorio
    {

        #region Tela de Avaliação do Paciente

        public async Task<IEnumerable<RegistroEmissao>> ListaRegistroEmissao(int aIdRegistroEmissao)
        {
            await Task.Delay(TimeSpan.FromMilliseconds(0));
            return new RegistroEmissaoDAL().ListaRegistroEmissao(aIdRegistroEmissao);
        }

        public async Task<IEnumerable<RegistroEmissao>> ListaRegistroEmissao(DateTime aDataInicio, DateTime aDataFim)
        {
            await Task.Delay(TimeSpan.FromMilliseconds(0));
            return new RegistroEmissaoDAL().ListaRegistroEmissao(aDataInicio, aDataFim);
        }

        public async Task<RegistroEmissao> RecuperarRegistroEmissao(int aIdRegistroEmissao)
        {
            await Task.Delay(TimeSpan.FromMilliseconds(0));
            return new RegistroEmissaoDAL().RecuperarRegistroEmissao(aIdRegistroEmissao);
        }

        public async Task SalvarRegistroEmissao(RegistroEmissao aRegistroEmissao)
        {
            await Task.Delay(TimeSpan.FromMilliseconds(0));
            new RegistroEmissaoDAL().SalvarAvaliacao(aRegistroEmissao);
        }

        public async Task SalvarRegistroEmissao(int aIdIndicadorEmissao)
        {
            await Task.Delay(TimeSpan.FromMilliseconds(0));
            new RegistroEmissaoDAL().SalvarAvaliacao(aIdIndicadorEmissao);
        }

        #endregion

    }
}