using System.Web.Http;
using SensorGasAPI.Negocio;
using System.Threading.Tasks;
using System.Web.Http.Description;
using System.Collections.Generic;
using System;

namespace SensorGasAPI.Controllers
{
    [RoutePrefix("registroEmissao")]
    public class WebServiceController : ApiController
    {

        #region Propriedades

        private readonly IRegistroEmissaoService _cadastroProfissionalService;

        #endregion

        #region Construtores       


        public WebServiceController(IRegistroEmissaoService cadastroProfissionalService)
        {
            _cadastroProfissionalService = cadastroProfissionalService;
        }

        #endregion

        // GET: registroEmissao/listaRegistroEmissao?aIdRegistroEmissao=
        [HttpGet()]
        [Route("listaRegistroEmissao")]
        [ResponseType(typeof(List<RegistroEmissao>))]
        public async Task<IHttpActionResult> ListaAvaliacoesPaciente(int aIdRegistroEmissao)
        {
            return Ok(await _cadastroProfissionalService.ListaRegistroEmissao(aIdRegistroEmissao));
        }

        // GET: registroEmissao/listaRegistroEmissao?aDataInicio={0}&aDataFim={1}
        [HttpGet()]
        [Route("listaRegistroEmissao")]
        [ResponseType(typeof(List<RegistroEmissao>))]
        public async Task<IHttpActionResult> ListaAvaliacoesPaciente(DateTime aDataInicio, DateTime aDataFim)
        {
            return Ok(await _cadastroProfissionalService.ListaRegistroEmissao(aDataInicio, aDataFim));
        }


        // GET: registroEmissao/registroEmissao?aIdRegistroEmissao=
        [HttpGet()]
        [Route("registroEmissao")]
        [ResponseType(typeof(RegistroEmissao))]
        public async Task<IHttpActionResult> RecuperarRegistroEmissao(int aIdRegistroEmissao)
        {
            return Ok(await _cadastroProfissionalService.RecuperarRegistroEmissao(aIdRegistroEmissao));
        }

        // POST: registroEmissao/salvar
        [HttpPost()]
        [Route("salvar")]
        public async Task<IHttpActionResult> SalvarRegistroEmissao([FromBody]RegistroEmissao aAvaliacaoPaciente)
        {
            await _cadastroProfissionalService.SalvarRegistroEmissao(aAvaliacaoPaciente);
            return Ok();
        }

        // POST: registroEmissao/salvar?aIdRegistroEmissao=
        [HttpPost()]
        [Route("salvar")]
        public async Task<IHttpActionResult> SalvarRegistroEmissao(int aIdIndicadorEmissao)
        {
            await _cadastroProfissionalService.SalvarRegistroEmissao(aIdIndicadorEmissao);
            return Ok();
        }


    }

}