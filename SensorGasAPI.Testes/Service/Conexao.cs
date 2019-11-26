using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;


namespace SensorGasAPI.Testes
{
    public class Conexao
    {

        #region Conexão com a Web API

        public static async Task CheckConexao()
        {
            try
            {
                using (var checkConexao = new HttpClient())
                {
                    // Endereco da WebApi
                    checkConexao.BaseAddress = new Uri(AppParametros.GetWebApiUrl);

                    // Limite do tempo de resposta
                    // client.Timeout = TimeSpan.FromMilliseconds(20000);

                    // Tentar realizar a conexão com a WebApi
                    await checkConexao.GetAsync(checkConexao.BaseAddress).ContinueWith(
                      getTask =>
                      {
                          if (getTask.Result.StatusCode != HttpStatusCode.OK)
                          {
                              throw new Exception("Falha na conexão com o banco de dados.");
                          }
                      }
                      );
                }
            }
            catch
            {
                throw new Exception("Falha na conexão com o banco de dados.");
            }
        }

        private async Task<HttpClient> RecuperarConexao()
        {
            // Verifica se há conexão com a WebApi
            await CheckConexao();

            // Cria um nojo objeto de conexão com o servidor
            HttpClient conexao = new HttpClient();
            conexao.BaseAddress = new Uri(AppParametros.GetWebApiUrl);

            conexao.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            return conexao;
        }

        private async Task VerificarRespostaConexao(HttpResponseMessage resposta)
        {
            int tipoRespostaHttp = Convert.ToInt32(resposta.StatusCode);

            if (tipoRespostaHttp >= 300 && tipoRespostaHttp < 400)
            {

            }
            else if (tipoRespostaHttp >= 400 && tipoRespostaHttp < 500)
            {
                switch (resposta.StatusCode)
                {
                    case HttpStatusCode.NotFound:
                        throw new Exception("Não foram encontradas informações.");
                    case HttpStatusCode.BadRequest:

                        var mensagemErro = await resposta.Content.ReadAsStringAsync();

                        try
                        {
                            // Pesquisar alguma maneira de "tipar" as mensagens de erro
                            mensagemErro = JsonConvert.DeserializeObject<object>(mensagemErro).ToString();
                        }
                        catch
                        {
                            mensagemErro = "Ocorreu um erro inesperado.";
                        }

                        throw new Exception(mensagemErro);

                    case HttpStatusCode.Unauthorized:
                        throw new UnauthorizedAccessException();
                    default:
                        throw new Exception("Erro ao recuperar os dados");
                }
            }
            else if (tipoRespostaHttp >= 500 && tipoRespostaHttp < 600)
            {
                throw new Exception("Erro ao recuperar os dados");
            }
        }

        public async Task<string> RetornarResposta(HttpResponseMessage resposta)
        {
            // Verifica se houve resposta da WebApi
            await VerificarRespostaConexao(resposta);

            if (resposta.StatusCode == HttpStatusCode.NoContent)
                return "[]";

            return await resposta.Content.ReadAsStringAsync();
        }

        #endregion

        #region GET

        public async Task<List<T>> SelectList<T>(Uri endereco)
        {
            var retorno = await Select(endereco);

            return JsonConvert.DeserializeObject<List<T>>(retorno);
        }

        public async Task<T> Select<T>(Uri endereco)
        {
            var retorno = await Select(endereco);

            return JsonConvert.DeserializeObject<T>(retorno);
        }

        public async Task<string> Select(Uri endereco)
        {
            using (var conexao = await RecuperarConexao())
            {
                var resposta = await conexao.GetAsync(endereco);
                return await RetornarResposta(resposta);
            }
        }

        #endregion

        //#region GET.BODY

        //public async Task<string> GetBody<T>(Uri endereco, T data)
        //{
        //    var value = JsonConvert.SerializeObject(data);
        //    return await GetBody(endereco, value);
        //}        

        //public async Task<string> GetBody(Uri endereco, string data)
        //{
        //    using (var client = await RecuperarConexao())
        //    {
        //        var result = await client.PostAsync(endereco, new StringContent(data, Encoding.UTF8, "application/json"));
        //        return await RetornarResposta(result);
        //    }
        //}

        //#endregion

        #region POST

        public async Task<TResult> Post<T, TResult>(Uri endereco, T data)
        {
            var value = await Post<T>(endereco, data);
            return JsonConvert.DeserializeObject<TResult>(value);
        }

        public async Task<string> Post<T>(Uri endereco, T data)
        {
            var value = JsonConvert.SerializeObject(data);
            return await Post(endereco, value);
        }

        public async Task<string> Post(Uri endereco, string data)
        {
            using (var client = await RecuperarConexao())
            {
                var result = await client.PostAsync(endereco, new StringContent(data, Encoding.UTF8, "application/json"));
                return await RetornarResposta(result);
            }
        }

        #endregion

        #region Post E=Mail

        public async Task<string> PostEMail<T>(Uri endereco, T data)
        {
            var value = JsonConvert.SerializeObject(data);
            return await PostEMail(endereco, value);
        }

        public async Task<string> PostEMail(Uri endereco, string data)
        {
            var client = new HttpClient();
            var result = await client.PostAsync(endereco, new StringContent(data, Encoding.UTF8, "application/json"));
            return await RetornarResposta(result);
        }

        #endregion

    }
}
