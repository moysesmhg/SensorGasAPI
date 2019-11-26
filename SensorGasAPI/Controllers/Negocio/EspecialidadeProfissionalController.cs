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
    [RoutePrefix("especialidade")]
    public class EspecialidadeProfissionalController : ApiController
    {

        #region Propriedades

        private readonly IAppService _classeService;

        #endregion

        #region Construtores      


        public EspecialidadeProfissionalController(IAppService classeService)
        {
            _classeService = classeService;
        }

        #endregion

        // GET: especialidade/todos
        [HttpGet]
        [Route("todos")]
        [ResponseType(typeof(IEnumerable<EspecialidadeDados>))]
        public async Task<IHttpActionResult> List()
        {
            await Task.Delay(TimeSpan.FromMilliseconds(0));

            return Ok(_classeService.TodasEspecialidades());
        }


        // GET: especialidade/listar?aCodigoClasseProfissional={0}
        [HttpGet]
        [Route("listar")]
        [ResponseType(typeof(IEnumerable<EspecialidadeDados>))]
        public async Task<IHttpActionResult> ListarEspecialidades(long? aCodigoClasseProfissional)
        {
            var classe = await _classeService.ListarEspecialidades(aCodigoClasseProfissional);

            if (classe == null)
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.NotFound));
            }

            return Ok(classe);
        }

    }
}