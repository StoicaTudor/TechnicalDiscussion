using AutoMapper;
using TechnicalTest.Application.Services;
using TechnicalTest.Core.Mappers;
using TechnicalTest.Core.Service.SearchAvailability;
using TechnicalTest.Infrastructure.Repositories;
using Unity;
using Unity.Injection;

namespace TechnicalTest.Application
{
    public class IocConfig
    {
        private static readonly IUnityContainer Container = new UnityContainer();
        private static bool _containerIsRegistered = false;

        private static void RegisterComponents()
        {
            Container.RegisterType<ISearchAvailability, SearchAvailability>();
            Container.RegisterType<IOffersSearcher, OffersSearcher>();
            Container.RegisterType<IOffersRepository, JsonOffersRepository>();
            
            Container.RegisterType<IMapper, Mapper>(
                new InjectionConstructor(new MapperConfiguration(cfg =>
                {
                    cfg.AddProfile(new OfferRequestProfile());
                    cfg.AddProfile(new OfferProfile());
                }))
            );
        }

        public static IUnityContainer GetConfiguredContainer()
        {
            if (!_containerIsRegistered)
                RegisterComponents();

            return Container;
        }
    }
}