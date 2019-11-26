using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace SensorGasAPI.Testes
{
    [TestClass]
    public class TesteUtilitarios
    {

        [TestMethod]
        public void TesteLog()
        {
            Utilitarios.Eventos.GravarEventos("TESTE");

            //assert
            Assert.IsNotNull(1);
        }



    }
}
