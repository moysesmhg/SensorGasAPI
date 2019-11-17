using SimpleInjector;
using SensorGasAPI.Negocio;
using SensorGasAPI.Repositorio;

namespace SensorGasAPI.IOC
{
    public static class SimpleInjectorContainer
    {
        public static void RegisterServices(Container container)
        {
            // RegistroEmissao
            container.Register<IRegistroEmissaoService, RegistroEmissaoService>(Lifestyle.Scoped);
            container.Register<IRegistroEmissaoRepositorio, RegistroEmissaoRepositorio>(Lifestyle.Scoped);

            //container.Verify();
        }

    }

}
