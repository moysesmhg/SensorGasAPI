using System;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using SensorGasAPI.Negocio;
using System.Web.Http.Description;
using System.Threading.Tasks;

namespace SensorGasAPI.Controllers
{
    [RoutePrefix("login")]
    public class UsuarioController : ApiController
    {

        #region Propriedades

        private readonly IAppService _classeService;

        #endregion

        #region Construtores


        public UsuarioController(IAppService classeService)
        {
            _classeService = classeService;
        }

        #endregion

        //POST (GAMBIARRÊICHON): login/validacao
        [HttpPost]
        [Route("validacao")]
        [ResponseType(typeof(LoginProjecao))]
        public async Task<IHttpActionResult> Get([FromBody]UsuarioDados aUsuario)
        {
            var classe = await _classeService.ValidarLogin(aUsuario);

            if (classe == null)
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.NotFound));
            }

            return Ok(classe);
        }

    }

}