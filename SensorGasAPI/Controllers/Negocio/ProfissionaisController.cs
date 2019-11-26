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
    [RoutePrefix("profissional")]
    public class ProfissionaisController : ApiController
    {

        #region Propriedades

        private readonly IAppService _classeService;

        #endregion

        #region Construtores


        public ProfissionaisController(IAppService classeService)
        {
            _classeService = classeService;
        }

        #endregion

        // GET: profissional/todos
        [HttpGet]
        [Route("todos")]
        [ResponseType(typeof(IEnumerable<ListaProfissionaisProjecao>))]
        public async Task<IHttpActionResult> List()
        {
            return Ok(await _classeService.TodosProfissionais());
        }


        // GET: profissional/listar?aNomeProfissional={0}&aCodigoClasseProfissional={1}&aCodigoEspecialidadeProfissional={2}
        [HttpGet]
        [Route("listar")]
        [ResponseType(typeof(IEnumerable<ListaProfissionaisProjecao>))]
        public async Task<IHttpActionResult> ListarProfissionais(string aNomeProfissional,
                                                                 long? aCodigoClasseProfissional,
                                                                 long? aCodigoEspecialidadeProfissional)
        {
            var classe = await _classeService.ListarProfissionais(aNomeProfissional,
                                                                  aCodigoClasseProfissional,
                                                                  aCodigoEspecialidadeProfissional);

            if (classe == null)
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.NotFound));
            }

            return Ok(classe);
        }

        // GET: profissional/detalhe?aCodigoProfissional={0}
        [HttpGet]
        [Route("detalhe")]
        [ResponseType(typeof(DetalheProfissionalProjecao))]
        public async Task<IHttpActionResult> DetalheProfissional(long aCodigoProfissional)
        {
            var classe = await _classeService.DetalheProfissional(aCodigoProfissional);

            if (classe == null)
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.NotFound));
            }

            return Ok(classe);
        }


        // GET: profissional/recuperarNome?aCodigoProfissional={0}
        [HttpGet]
        [Route("recuperarNome")]
        [ResponseType(typeof(string))]
        public async Task<IHttpActionResult> RecuperarNomeProfissional(long aCodigoProfissional)
        {
            var classe = await _classeService.RecuperarNomeProfissional(aCodigoProfissional);

            if (classe == null)
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.NotFound));
            }

            return Ok(classe);
        }

    }
}