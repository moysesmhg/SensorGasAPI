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
    [RoutePrefix("classe")]
    public class ClasseProfissionalController : ApiController
    {

        #region Propriedades

        private readonly IAppService _classeService;

        #endregion

        #region Construtores        


        public ClasseProfissionalController(IAppService classeService)
        {
            _classeService = classeService;
        }

        #endregion

        // GET: classe/todos
        [HttpGet]
        [Route("todos")]
        [ResponseType(typeof(IEnumerable<ClasseProfissionalDados>))]
        public async Task<IHttpActionResult> List()
        {
            return Ok(await _classeService.TodasClasses());
        }


        // GET: classe/select?aCodigo=
        [HttpGet]
        [Route("select")]
        [ResponseType(typeof(IEnumerable<ClasseProfissionalDados>))]
        public async Task<IHttpActionResult> GetClasse(long aCodigo)
        {
            var classe = await _classeService.Select(aCodigo);

            if (classe == null)
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.NotFound));
            }

            return Ok(classe);
        }

        // POST: classe/insert
        [HttpPost()]
        [Route("insert")]
        public async Task<IHttpActionResult> Post([FromBody]ClasseProfissionalDados aClasseProfissional)
        {
            await _classeService.Insert(aClasseProfissional);
            return Ok();
        }


        // PUT classe/update
        [HttpPut()]
        [Route("update")]
        public async Task<IHttpActionResult> Put(long aCodigo, [FromBody]ClasseProfissionalDados aClasseProfissional)
        {
            aClasseProfissional.CodigoClasseProfissional = aCodigo;
            await _classeService.Update(aClasseProfissional);
            return Ok();
        }

        // DELETE classe/delete
        [HttpDelete()]
        [Route("delete")]
        public async Task<IHttpActionResult> Delete(long aCodigo)
        {
            await _classeService.Delete(aCodigo);
            return Ok();
        }

    }
}