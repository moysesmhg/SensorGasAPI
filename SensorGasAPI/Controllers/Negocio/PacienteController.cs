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
    [RoutePrefix("paciente")]
    public class PacienteController : ApiController
    {

        #region Propriedades

        private readonly IAppService _classeService;

        #endregion

        #region Construtores        


        public PacienteController(IAppService classeService)
        {
            _classeService = classeService;
        }

        #endregion

        #region Dados do Paciente

        // GET: paciente/recuperarNome?aCodigoPaciente={0}
        [HttpGet]
        [Route("recuperarNome")]
        [ResponseType(typeof(string))]
        public async Task<IHttpActionResult> RecuperarNomePaciente(long aCodigoPaciente)
        {
            return Ok(await _classeService.RecuperarNomePaciente(aCodigoPaciente));
        }

        // POST: paciente/recuperarContato?aCodigoPaciente={0}
        [HttpGet]
        [Route("recuperarContato")]
        [ResponseType(typeof(PacienteProjecao))]
        public async Task<IHttpActionResult> RecuperarContatoPaciente(long aCodigoPaciente)
        {
            return Ok(await _classeService.RecuperarContatoPaciente(aCodigoPaciente));
        }

        #endregion

    }

}