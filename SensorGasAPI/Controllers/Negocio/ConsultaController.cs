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
    [RoutePrefix("consulta")]
    public class ConsultaController : ApiController
    {

        #region Propriedades

        private readonly IAppService _classeService;

        #endregion

        #region Construtores        


        public ConsultaController(IAppService classeService)
        {
            _classeService = classeService;
        }

        #endregion

        #region Tela de Configuração de Consulta

        // GET: consulta/recuperarDados?aCodigoProfissional=
        [HttpGet]
        [Route("recuperarDados")]
        [ResponseType(typeof(ConfiguracaoConsultaDados))]
        public async Task<IHttpActionResult> RecuperarDadosConsulta(long aCodigoProfissional)
        {
            return Ok(await _classeService.RecuperarDadosConsulta(aCodigoProfissional));
        }

        // POST: consulta/salvardados
        [HttpPost]
        [Route("salvardados")]
        public async Task<IHttpActionResult> SalvarDadosConsulta([FromBody]ConfiguracaoConsultaDados aDadosConsulta)
        {
            await _classeService.SalvarDadosConsulta(aDadosConsulta);
            return Ok();
        }

        #endregion

        #region Tela de Configuração de Horários

        // GET: consulta/listaConfiguracaoHorarios?aCodigoProfissional={0}
        [HttpGet]
        [Route("listaConfiguracaoHorarios")]
        [ResponseType(typeof(IEnumerable<ConfiguracaoHorarioDados>))]
        public async Task<IHttpActionResult> ListaDadosConfiguracaoHorario(long aCodigoProfissional)
        {
            return Ok(await _classeService.ListaDadosConfiguracaoHorario(aCodigoProfissional));
        }

        // GET: consulta/getConfiguracaoHorarios?aCodigoProfissional={0}&aCodigoDiaConsulta={1}
        [HttpGet]
        [Route("getConfiguracaoHorarios")]
        [ResponseType(typeof(ConfiguracaoHorarioDados))]
        public async Task<IHttpActionResult> RecuperarDadosConfiguracaoHorario(long aCodigoProfissional, long aCodigoDiaConsulta)
        {
            return Ok(await _classeService.RecuperarDadosConfiguracaoHorario(aCodigoProfissional, aCodigoDiaConsulta));
        }

        // POST: consulta/salvarConfiguracaoHorarios
        [HttpPost]
        [Route("salvarConfiguracaoHorarios")]
        public async Task<IHttpActionResult> SalvarDadosConfiguracaoHorario([FromBody]ConfiguracaoHorarioDados aConfiguracaoHorarioDados)
        {
            await _classeService.SalvarDadosConfiguracaoHorario(aConfiguracaoHorarioDados);
            return Ok();
        }

        #endregion

        #region Tela de Agenda

        // POST: consulta/verificarExistencia - Quando há objetos nos parâmetros e no retorno, usa-se o POST ao invés do GET
        [HttpPost]
        [Route("verificarExistencia")]
        [ResponseType(typeof(ConsultaDados))]
        public async Task<IHttpActionResult> VerificarExistenciaConsulta([FromBody]ConsultaDados aConsultaDados)
        {
            return Ok(await _classeService.VerificarExistenciaConsulta(aConsultaDados));
        }

        // GET: consulta/getConsultas?aCodigoProfissional={0}&aDataSelecionadaCalendario={1}
        [HttpGet]
        [Route("getConsultas")]
        [ResponseType(typeof(IEnumerable<ConsultaDados>))]
        public async Task<IHttpActionResult> SelecionarConsultas(long aCodigoProfissional, string aDataSelecionadaCalendario)
        {
            return Ok(await _classeService.SelecionarConsultas(aCodigoProfissional, aDataSelecionadaCalendario));
        }

        // GET: consulta/getConsultasPaciente?aCodigoProfissional={0}&aCodigoPaciente={1}&aDataSelecionadaCalendario={2}
        [HttpGet]
        [Route("getConsultasPaciente")]
        [ResponseType(typeof(IEnumerable<ConsultaDados>))]
        public async Task<IHttpActionResult> SelecionarConsultasPaciente(long aCodigoProfissional, long aCodigoPaciente, string aDataSelecionadaCalendario)
        {
            return Ok(await _classeService.SelecionarConsultasPaciente(aCodigoProfissional, aCodigoPaciente, aDataSelecionadaCalendario));
        }

        // GET: consulta/buscarSituacaoDatas?aCodigoProfissional={0}&aDataInicio={1}&aDataFim={2}
        [HttpGet]
        [Route("buscarSituacaoDatas")]
        [ResponseType(typeof(IEnumerable<StatusDatasProjecao>))]
        public async Task<IHttpActionResult> BuscarSituacaoDatasConsulta(long aCodigoProfissional, string aDataInicio, string aDataFim)
        {
            return Ok(await _classeService.BuscarSituacaoDatasConsulta(aCodigoProfissional, aDataInicio, aDataFim));
        }

        // POST: consulta/atualizar
        [HttpPost]
        [Route("atualizar")]
        public async Task<IHttpActionResult> AtualizarConsulta([FromBody]ConsultaDados aConsulta)
        {
            await _classeService.AtualizarConsulta(aConsulta);
            return Ok();
        }

        #endregion

        #region Tela Minhas Consultas

        // GET: consulta/listaMinhasConsultas?aCodigoPaciente={0}
        [HttpGet]
        [Route("listaMinhasConsultas")]
        [ResponseType(typeof(IEnumerable<ListaMinhasConsultasProjecao>))]
        public async Task<IHttpActionResult> ListaMinhasConsultas(long aCodigoPaciente)
        {
            return Ok(await _classeService.ListaMinhasConsultas(aCodigoPaciente));
        }

        // GET: consulta/detalheMinhasConsutas?aCodigoConsulta={0}
        [HttpGet]
        [Route("detalheMinhasConsutas")]
        [ResponseType(typeof(MinhasConsultasProjecao))]
        public async Task<IHttpActionResult> DetalheMinhasConsultas(long aCodigoConsulta)
        {
            return Ok(await _classeService.DetalheMinhasConsultas(aCodigoConsulta));
        }

        #endregion

        #region Tela Gerenciar Consultas

        // GET: consulta/listaGerenciarConsultas?aCodigoProfissional={0}
        [HttpGet]
        [Route("listaGerenciarConsultas")]
        [ResponseType(typeof(IEnumerable<ListaGerenciarConsultasProjecao>))]
        public async Task<IHttpActionResult> ListaGerenciarConsultas(long aCodigoProfissional)
        {
            return Ok(await _classeService.ListaGerenciarConsultas(aCodigoProfissional));
        }

        // GET: consulta/detalheGerenciarConsutas?aCodigoConsulta={0}
        [HttpGet]
        [Route("detalheGerenciarConsutas")]
        [ResponseType(typeof(DetalheGerenciarConsultasProjecao))]
        public async Task<IHttpActionResult> DetalheGerenciarConsultas(long aCodigoConsulta)
        {
            return Ok(await _classeService.DetalheGerenciarConsultas(aCodigoConsulta));
        }

        #endregion

        #region Serviço de E-Mail

        // GET: consulta/getConsultasEmail?aCodigoPaciente={0}
        [HttpGet]
        [Route("getConsultasEmail")]
        [ResponseType(typeof(IEnumerable<ConsultaServicoEmailProjecao>))]
        public async Task<IHttpActionResult> RecuperarConsultaServicoEmail(long aCodigoPaciente)
        {
            return Ok(await _classeService.RecuperarConsultaServicoEmail(aCodigoPaciente));
        }

        #endregion

    }

}