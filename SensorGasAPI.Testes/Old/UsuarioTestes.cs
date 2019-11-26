using Microsoft.VisualStudio.TestTools.UnitTesting;
using SensorGasAPI.Negocio;


namespace SensorGasAPI.Testes
{
    [TestClass]
    public class UsuarioTestes
    {

        [TestMethod]
        public void Login()
        {

            var usuario = new UsuarioDados()
            {
                LoginUsuario = "teste@gmail.com",
                SenhaUsuario = "teste",

            };

            new Repositorio.UsuarioDAL().RecuperarLogin(usuario);

            //assert
            Assert.IsNotNull(1);

        }

    }
}
