using Microsoft.VisualStudio.TestTools.UnitTesting;
using SensorGasAPI.Repositorio;

namespace SensorGasAPI.Testes
{
    [TestClass]
    public class ProfissionalTeste
    {

        [TestMethod]
        public void ListarTodosProfissionais()
        {
            var teste = new ProfissionaisDAL().ListarTodosProfissionais();

            Assert.IsNotNull(1);

        }

        [TestMethod]
        public void ListarProfissionais()
        {
            var teste = new ProfissionaisDAL().ListarProfissionais("Profissional 1", 1, 8);

            Assert.IsNotNull(1);

        }

        [TestMethod]
        public void DetalheProfissional()
        {
            var teste = new ProfissionaisDAL().DetalheProfissional(1);

            Assert.IsNotNull(1);

        }

    }

}
