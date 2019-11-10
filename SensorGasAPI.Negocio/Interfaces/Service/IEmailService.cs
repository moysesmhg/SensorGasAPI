
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using SensorGasAPI.Negocio;

namespace SensorGasAPI.Negocio
{
    public interface IEmailService
    {

        #region Serviço de E-Mail

        Task<CheckEmailDados> SelectCheckEMail(long aCodigoPaciente);
        Task InsertCheckEMail(long aCodigoConsulta);

        #endregion

    }

}