using Microsoft.Practices.Unity;
using System.Web.Http;
using Unity.WebApi;
using StudentInformation.Repositroy;
using StudentInformation.Repositroy.Interface;
using StudentInformation.Repositroy.Concreate;
using StudentInformation.Service.Concreate;
using StudentInformation.Service.Interface;

namespace StudentInformation
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();
            
            // register all your components with the container here
            // it is NOT necessary to register your controllers
            
              container.RegisterType<IProductRepositroy, ProductRepositroy>();
            container.RegisterType<IProducrService, ProducrService>();
            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
        }
    }
}