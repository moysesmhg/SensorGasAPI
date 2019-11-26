using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using SensorGasAPI.Negocio;
using System.Web.Http.Description;
using System.Threading.Tasks;

namespace SensorGasAPI.Controllers
{

    [RoutePrefix("usuarioGlobal")]
    public class UsuarioGlobalController : ApiController
    {

        #region Propriedades

        private readonly IAppService _classeService;

        #endregion

        #region Construtores


        public UsuarioGlobalController(IAppService classeService)
        {
            _classeService = classeService;
        }

        #endregion


        // GET: usuarioGlobal/check
        [HttpGet]
        [Route("check")]
        [ResponseType(typeof(UsuarioGlobalDados))]
        public async Task<IHttpActionResult> CheckUsuarioGlobal()
        {
            var classe = await _classeService.CheckUsuarioGlobal();

            if (classe == null)
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.NotFound));
            }

            return Ok(classe);
        }


        // GET: usuarioGlobal/inserir
        [HttpPost]
        [Route("inserir")]
        public async Task<IHttpActionResult> InserirUsuarioGlobal([FromBody]UsuarioGlobalDados aUsuarioGlobal)
        {
            await _classeService.InserirUsuarioGlobal(aUsuarioGlobal);
            return Ok();
        }

    }
}