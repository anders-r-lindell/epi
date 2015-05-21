using System.Web.Mvc;
using Autofac;
using Autofac.Integration.Mvc;

namespace EPi.Web
{
    public class EPiServerApplication : EPiServer.Global
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            
            var builder = new ContainerBuilder();

            CqFramework.Implementation.Autofac.Bootstrapping.Configure(builder);
            EPi.Bootstrapper.EPiBootstrapper.Configure(builder);

            var container = builder.Build();

            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
}