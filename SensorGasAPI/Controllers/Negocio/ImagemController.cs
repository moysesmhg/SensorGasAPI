using System.Web.Http;
using SensorGasAPI.Negocio;
using System.Threading.Tasks;
using System.Web.Http.Description;
using System.Collections.Generic;

namespace SensorGasAPI.Controllers
{
    [RoutePrefix("imagem")]
    public class ImagemController : ApiController
    {

        #region Propriedades

        private readonly IAppService _imagemService;

        #endregion

        #region Construtores       


        public ImagemController(IAppService imagemService)
        {
            _imagemService = imagemService;
        }

        #endregion

        #region Tela de Avaliaçao do Paciente


        // GET: imagem/recuperarImagem?aCodigoUsuario=
        [HttpGet()]
        [Route("recuperarImagem")]
        [ResponseType(typeof(ImagensDados))]
        public async Task<IHttpActionResult> RecuperarImagem(long aCodigoUsuario)
        {
            return Ok(await _imagemService.RecuperarImagem(aCodigoUsuario));
        }

        // POST: imagem/salvar
        [HttpPost()]
        [Route("salvar")]
        public async Task<IHttpActionResult> AtualizarImagem([FromBody]ImagensDados aImagem)
        {
            await _imagemService.AtualizarImagem(aImagem);
            return Ok();
        }

        #endregion

       

    }

}