using System.Web.Http;
using SensorGasAPI.Negocio;
using System.Threading.Tasks;
using System.Web.Http.Description;
using System.Collections.Generic;

namespace SensorGasAPI.Controllers
{
    [RoutePrefix("tratamento")]
    public class TratamentoController : ApiController
    {

        #region Propriedades

        private readonly IAppService _tratamentoService;

        #endregion

        #region Construtores       


        public TratamentoController(IAppService tratamentoService)
        {
            _tratamentoService = tratamentoService;
        }

        #endregion

        // GET: tratamento/listaDefinirTratamento?aCodigoPaciente=
        [HttpGet()]
        [Route("listaDefinirTratamento")]
        [ResponseType(typeof(List<ListaTratamentoProjecao>))]
        public async Task<IHttpActionResult> ListaDefinirTratamento(long aCodigoPaciente)
        {
            return Ok(await _tratamentoService.ListaDefinirTratamento(aCodigoPaciente));
        }


        // GET: tratamento/detalheTratamento?aCodigoConsulta=
        [HttpGet()]
        [Route("detalheTratamento")]
        [ResponseType(typeof(DetalheTratamentoProjecao))]
        public async Task<IHttpActionResult> DetalheTratamento(long aCodigoConsulta)
        {
            return Ok(await _tratamentoService.DetalheTratamento(aCodigoConsulta));
        }

        // POST: tratamento/atualizar
        [HttpPost()]
        [Route("atualizar")]
        public async Task<IHttpActionResult> SalvarTratamento([FromBody]TratamentoDados aAvaliacaoPaciente)
        {
            await _tratamentoService.SalvarTratamento(aAvaliacaoPaciente);
            return Ok();
        }


        // GET: tratamento/listaAviso?aCodigoPaciente=
        [HttpGet()]
        [Route("listaAviso")]
        [ResponseType(typeof(List<TratamentoDados>))]
        public async Task<IHttpActionResult> ListaTratamentosAviso(long aCodigoPaciente)
        {
            return Ok(await _tratamentoService.ListaTratamentosAviso(aCodigoPaciente));
        }


    }

}