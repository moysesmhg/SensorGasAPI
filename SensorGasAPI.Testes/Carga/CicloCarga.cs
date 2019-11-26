using Microsoft.VisualStudio.TestTools.UnitTesting;
using SensorGasAPI.Repositorio;

namespace SensorGasAPI.Testes
{
    [TestClass]
    public class UsuarioCarga
    {
        private PrepararCarga Carga { get; set; }

        public UsuarioCarga()
        {
            // Realiza a criação de tabelas
            //this.CriarTabelas();
        }

        [TestMethod]
        public void ExecutarCiclo()
        {
            this.Carga = new PrepararCarga();
            this.Carga.CriarTabelas();
            this.Carga.RealizarCargas();
        }

        [TestMethod]
        public void CriarTabelas()
        {
            this.Carga = new PrepararCarga();
            this.Carga.CriarTabelas();
        }

        [TestMethod]
        public void RealizarCargas()
        {
            this.Carga = new PrepararCarga();
            this.Carga.RealizarCargas();
        }

    }

}