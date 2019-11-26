using Microsoft.VisualStudio.TestTools.UnitTesting;
using SensorGasAPI.Negocio;
using SensorGasAPI.Repositorio;
using Newtonsoft.Json;
using System;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace SensorGasAPI.Testes
{
    [TestClass]
    public class TesteService : Conexao
    {

        [TestMethod]
        public void TestarLogin()
        {
            var usuario = new UsuarioDados()
            {
                LoginUsuario = "moysesmhg@gmail.com",
                SenhaUsuario = "asd"
            };

            LoginProjecao resultado = null;

            Task.Run(async () =>
            {
                resultado = await this.Post<UsuarioDados, LoginProjecao>(new Uri(AppParametros.GetWebApiUrl + "login/validacao"), usuario);
            });

        }

        [TestMethod]
        public void TesterClasses()
        {
            var resultado = this.SelectList<ClasseProfissionalDados>(new Uri(AppParametros.GetWebApiUrl + "classe/todos"));
        }

    }

}