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
    [RoutePrefix("configuracao")]
    public class ConfiguracaoController : ApiController
    {

        #region Propriedades

        private readonly IAppService _classeService;

        #endregion

        #region Construtores        


        public ConfiguracaoController(IAppService classeService)
        {
            _classeService = classeService;
        }

        #endregion

        #region Tela de Configuração de Consulta

        // GET: configuracao/precoConsulta?aCodigoProfissional=
        [HttpGet]
        [Route("precoConsulta")]
        [ResponseType(typeof(IEnumerable<ConfiguracaoConsultaDados>))]
        public async Task<IHttpActionResult> RecuperarPrecoConsulta(long aCodigoProfissional)
        {
            return Ok(await _classeService.RecuperarPrecoConsulta(aCodigoProfissional));
        }

        #endregion

    }

}