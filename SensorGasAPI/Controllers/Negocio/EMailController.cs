using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using SensorGasAPI.Negocio;
using System.Web.Http.Description;
using System.Threading.Tasks;

namespace SensorGasAPI.Controllers
{
    [RoutePrefix("email")]
    public class EMailController : ApiController
    {

        #region Propriedades

        private readonly IAppService _classeService;

        #endregion

        #region Construtores        


        public EMailController(IAppService classeService)
        {
            _classeService = classeService;
        }

        #endregion

        #region Serviço de E-Mail

        // GET: email/verificarEnvio?aCodigoPaciente={0}
        [HttpGet]
        [Route("verificarEnvio")]
        [ResponseType(typeof(CheckEmailDados))]
        public async Task<IHttpActionResult> SelectCheckEMail(long aCodigoPaciente)
        {
            return Ok(await _classeService.SelectCheckEMail(aCodigoPaciente));
        }

        // POST: email/inserirVerificacao
        [HttpPost]
        [Route("inserirVerificacao")]
        public async Task<IHttpActionResult> InsertCheckEMail(long aCodigoConsulta)
        {
            await _classeService.InsertCheckEMail(aCodigoConsulta);
            return Ok();
        }

        #endregion
               
    }

}