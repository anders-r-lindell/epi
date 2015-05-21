using Autofac;
using Autofac.Integration.Mvc;
using EPiServer;
using EPiServer.Configuration;
using EPiServer.Construction;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.Framework.Blobs;
using EPiServer.ServiceLocation;
using EPiServer.Web.Routing;

namespace EPi.Bootstrapper
{
    public class EPiBootstrapper
    {
        public static void Configure(ContainerBuilder builder)
        {
            RegisterServiceLocatorDependencies(builder);

            builder.RegisterControllers(typeof(EPiBootstrapper).Assembly);
            builder.RegisterModule<AutofacWebTypesModule>();
            builder.RegisterFilterProvider();
        }

        private static void RegisterServiceLocatorDependencies(ContainerBuilder builder)
        {
            builder.Register(c => ServiceLocator.Current.GetInstance<BlobFactory>()).ExternallyOwned();
            builder.Register(c => ServiceLocator.Current.GetInstance<ContentMediaResolver>()).ExternallyOwned();
            builder.Register(c => ServiceLocator.Current.GetInstance<IContentLoader>()).ExternallyOwned();
            builder.Register(c => ServiceLocator.Current.GetInstance<IContentRepository>()).ExternallyOwned();
            builder.Register(c => ServiceLocator.Current.GetInstance<IContentTypeRepository>()).ExternallyOwned();
            builder.Register(c => ServiceLocator.Current.GetInstance<ILanguageBranchRepository>()).ExternallyOwned();
            builder.Register(c => ServiceLocator.Current.GetInstance<IPublishedStateAssessor>()).ExternallyOwned();
            builder.Register(c => ServiceLocator.Current.GetInstance<ITabDefinitionRepository>()).ExternallyOwned();
            builder.Register(c => ServiceLocator.Current.GetInstance<PageRouteHelper>()).ExternallyOwned();
            builder.Register(c => ServiceLocator.Current.GetInstance<SearchPages>()).ExternallyOwned();
            builder.Register(c => ServiceLocator.Current.GetInstance<Settings>()).ExternallyOwned();
            builder.Register(c => ServiceLocator.Current.GetInstance<UrlResolver>()).ExternallyOwned();
            builder.Register(c => ServiceLocator.Current.GetInstance<IdentityMappingService>()).ExternallyOwned();
            builder.Register(c => ServiceLocator.Current.GetInstance<ContentFactory>()).ExternallyOwned();
            builder.Register(c => ServiceLocator.Current.GetInstance<IContentProviderManager>()).ExternallyOwned();
            builder.Register(c => ServiceLocator.Current.GetInstance<IdentityMappingService>()).ExternallyOwned();
        }
    }
}
