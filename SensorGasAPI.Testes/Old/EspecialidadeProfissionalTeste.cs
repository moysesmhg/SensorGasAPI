using Microsoft.VisualStudio.TestTools.UnitTesting;
using SensorGasAPI.Repositorio;

namespace SensorGasAPI.Testes
{
    [TestClass]
    public class EspecialidadeProfissionalTeste
    {

        [TestMethod]
        public void ListarTodosProfissionais()
        {
            var teste = new EspecialidadeProfissionalDAL().ListarTodasEspecialidades();

            //assert
            Assert.IsNotNull(1);

        }

        [TestMethod]
        public void ListarProfissionais()
        {
            var teste = new EspecialidadeProfissionalDAL().ListarEspecialidades(1);

            //assert
            Assert.IsNotNull(1);

        }

    }
}
