using System.Web.Http;
using SensorGasAPI.Negocio;
using System.Threading.Tasks;


namespace SensorGasAPI.Controllers
{
    [RoutePrefix("usuario")]
    public class CadastroUsuarioController : ApiController
    {

        #region Propriedades

        private readonly IAppService _cadastroUsuarioService;

        #endregion

        #region Construtores        

        public CadastroUsuarioController(IAppService cadastroUsuarioService)
        {
            _cadastroUsuarioService = cadastroUsuarioService;
        }

        #endregion

        // POST: usuario/insert
        [HttpPost()]
        [Route("insert")]
        public async Task<IHttpActionResult> Post([FromBody]CadastroUsuarioProjecao aClasseProfissional)
        {
            await _cadastroUsuarioService.Insert(aClasseProfissional);
            return Ok();
        }

        // PUT usuario/update
        [HttpPut()]
        [Route("update")]
        public async Task<IHttpActionResult> Put(long aCodigo, [FromBody]CadastroUsuarioProjecao aClasseProfissional)
        {
            //aClasseProfissional.CodigoClasseProfissional = aCodigo;
            await _cadastroUsuarioService.Update(aClasseProfissional);
            return Ok();
        }

        //// DELETE usuario/delete
        //[HttpDelete()]
        //[Route("delete")]
        //public void Delete(long aCodigo)
        //{
        //    _cadastroProfissionalService.Delete(aCodigo);
        //}

    }
}