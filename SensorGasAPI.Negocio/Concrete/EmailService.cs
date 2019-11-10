using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SensorGasAPI.Negocio
{
    public class EmailService : IEmailService
    {
        private readonly IEmailRepositorio _repository;

        public EmailService(IEmailRepositorio repository)
        {
            _repository = repository;
        }

        #region Serviço de E-Mail

        public async Task<CheckEmailDados> SelectCheckEMail(long aCodigoPaciente)
        {
           return await _repository.SelectCheckEMail(aCodigoPaciente);
        }

        public async Task InsertCheckEMail(long aCodigoConsulta)
        {
            await _repository.InsertCheckEMail(aCodigoConsulta);
        }

        #endregion

    }

}