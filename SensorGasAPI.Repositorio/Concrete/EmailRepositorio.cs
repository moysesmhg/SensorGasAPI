using System;
using System.Threading.Tasks;
using SensorGasAPI.Negocio;

namespace SensorGasAPI.Repositorio
{
    public class EmailRepositorio : IEmailRepositorio
    {

        #region Serviço de E-Mail

        public async Task<CheckEmailDados> SelectCheckEMail(long aCodigoPaciente)
        {
            await Task.Delay(TimeSpan.FromMilliseconds(0));
            return new CheckEMailDAL().SelectCheckEMail(aCodigoPaciente);
        }

        public async Task InsertCheckEMail(long aCodigoConsulta)
        {
            await Task.Delay(TimeSpan.FromMilliseconds(0));
            new CheckEMailDAL().InsertCheckEMail(aCodigoConsulta);
        }

        #endregion

    }

}