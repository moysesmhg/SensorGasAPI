using System.Web.Http;
using SensorGasAPI.Negocio;
using System.Threading.Tasks;

namespace SensorGasAPI.Controllers
{
    [RoutePrefix("profissional")]
    public class CadastroProfissionalController : ApiController
    {

        #region Propriedades

        private readonly IAppService _cadastroProfissionalService;

        #endregion

        #region Construtores       


        public CadastroProfissionalController(IAppService cadastroProfissionalService)
        {
            _cadastroProfissionalService = cadastroProfissionalService;
        }

        #endregion 

        // POST: profissional/insert
        [HttpPost()]
        [Route("insert")]
        public async Task<IHttpActionResult> Post([FromBody]CadastroProfissionalProjecao aClasseProfissional)
        {
            await _cadastroProfissionalService.Insert(aClasseProfissional);
            return Ok();
        }


        // PUT: profissional/update
        [HttpPut()]
        [Route("update")]
        public async Task<IHttpActionResult> Put(long aCodigo, [FromBody]CadastroProfissionalProjecao aClasseProfissional)
        {
            await _cadastroProfissionalService.Update(aClasseProfissional);
            return Ok();
        }

        // DELETE profissional/update
        //[HttpDelete()]
        //[Route("delete")]
        //public void Delete(long aCodigo)
        //{
        //    _cadastroProfissionalService.Delete(aCodigo);
        //}

    }
}