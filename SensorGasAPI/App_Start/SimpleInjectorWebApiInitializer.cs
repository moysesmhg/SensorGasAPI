[assembly: WebActivator.PostApplicationStartMethod(typeof(SensorGasAPI.App_Start.SimpleInjectorWebApiInitializer), "Initialize")]

namespace SensorGasAPI.App_Start
{
    using System.Web.Http;
    using SimpleInjector;
    using SimpleInjector.Lifestyles;
    using SimpleInjector.Integration.WebApi;    
    using SensorGasAPI.IOC;
    using System;

    public static class SimpleInjectorWebApiInitializer
    {
        /// <summary>Initialize the container and register it as Web API Dependency Resolver.</summary>
        public static void Initialize()
        {
            var container = new Container();
            container.Options.DefaultScopedLifestyle = new WebApiRequestLifestyle();

            InitializeContainer(container);

            container.RegisterWebApiControllers(GlobalConfiguration.Configuration);

            container.Verify();

            GlobalConfiguration.Configuration.DependencyResolver =
                new SimpleInjectorWebApiDependencyResolver(container);
        }

        private static void InitializeContainer(Container container)
        {

            SimpleInjectorContainer.RegisterServices(container);

            // For instance:
            // container.Register<IUserRepository, SqlUserRepository>(Lifestyle.Scoped);
        }
    }
}