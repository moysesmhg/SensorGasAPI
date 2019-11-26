using System.Web.Http;
using SensorGasAPI.Negocio;
using System.Threading.Tasks;
using System.Web.Http.Description;
using System.Collections.Generic;

namespace SensorGasAPI.Controllers
{
    [RoutePrefix("endereco")]
    public class EnderecoController : ApiController
    {

        #region Propriedades

        private readonly IAppService _enderecoService;

        #endregion

        #region Construtores       


        public EnderecoController(IAppService enderecoService)
        {
            _enderecoService = enderecoService;
        }

        #endregion

        // GET: endereco/listaEstados
        [HttpGet()]
        [Route("listaEstados")]
        [ResponseType(typeof(List<EstadoDados>))]
        public async Task<IHttpActionResult> ListaEstados()
        {
            return Ok(await _enderecoService.ListaEstados());
        }

        // GET: endereco/listaMunicipios?aCodigoEstado=
        [HttpGet()]
        [Route("listaMunicipios")]
        [ResponseType(typeof(List<MunicipioDados>))]
        public async Task<IHttpActionResult> ListaMunicipios(long aCodigoEstado)
        {
            return Ok(await _enderecoService.ListaMunicipios(aCodigoEstado));
        }


    }

}