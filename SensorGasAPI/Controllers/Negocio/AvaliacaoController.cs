using System.Web.Http;
using SensorGasAPI.Negocio;
using System.Threading.Tasks;
using System.Web.Http.Description;
using System.Collections.Generic;

namespace SensorGasAPI.Controllers
{
    [RoutePrefix("avaliacao")]
    public class AvaliacaoController : ApiController
    {

        #region Propriedades

        private readonly IAppService _avaliacaoService;

        #endregion

        #region Construtores       


        public AvaliacaoController(IAppService cadastroProfissionalService)
        {
            _avaliacaoService = cadastroProfissionalService;
        }

        #endregion

        #region Tela de Avaliaçao do Paciente

        // GET: avaliacao/listaAvaliacoes?aCodigoPaciente=
        [HttpGet()]
        [Route("listaAvaliacoes")]
        [ResponseType(typeof(List<ListaAvaliacoesPacienteProjecao>))]
        public async Task<IHttpActionResult> ListaAvaliacoesPaciente(long aCodigoPaciente)
        {
            return Ok(await _avaliacaoService.ListaAvaliacoesPaciente(aCodigoPaciente));
        }


        // GET: avaliacao/detalheAvaliacao?aCodigoConsulta=
        [HttpGet()]
        [Route("detalheAvaliacao")]
        [ResponseType(typeof(AvaliacaoPacienteProjecao))]
        public async Task<IHttpActionResult> RecuperarDetalheAvaliacao(long aCodigoConsulta)
        {
            return Ok(await _avaliacaoService.RecuperarDetalheAvaliacao(aCodigoConsulta));
        }

        // POST: avaliacao/salvar
        [HttpPost()]
        [Route("salvar")]
        public async Task<IHttpActionResult> SalvarAvaliacao([FromBody]AvaliacaoDados aAvaliacaoPaciente)
        {
            await _avaliacaoService.SalvarAvaliacao(aAvaliacaoPaciente);
            return Ok();
        }

        #endregion

        #region Tela de Reputação do Profissional

        // GET: avaliacao/listaReputacao?aCodigoProfissional=
        [HttpGet()]
        [Route("listaReputacao")]
        [ResponseType(typeof(ListaReputacaoProjecao))]
        public async Task<IHttpActionResult> ListaReputacao(long aCodigoProfissional)
        {
            return Ok(await _avaliacaoService.ListaReputacao(aCodigoProfissional));
        }

        // GET: avaliacao/detalheReputacao?=aCodigoConsulta
        [HttpGet()]
        [Route("detalheReputacao")]
        [ResponseType(typeof(ReputacaoProjecao))]
        public async Task<IHttpActionResult> RecuperarDetalheReputacao(long aCodigoConsulta)
        {
            return Ok(await _avaliacaoService.RecuperarDetalheReputacao(aCodigoConsulta));
        }

        #endregion

        #region Tela de Detalhe do Profissional

        // GET: avaliacao/numerosProfissional?aCodigoProfissional=
        [HttpGet()]
        [Route("numerosProfissional")]
        [ResponseType(typeof(NumerosProfissionalProjecao))]
        public async Task<IHttpActionResult> RecuperarNumerosProfissional(long aCodigoProfissional)
        {
            return Ok(await _avaliacaoService.RecuperarNumerosProfissional(aCodigoProfissional));
        }

        #endregion

    }

}