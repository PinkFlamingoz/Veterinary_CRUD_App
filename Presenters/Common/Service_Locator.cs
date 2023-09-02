using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veterinary_CRUD_App.Presenters.Common
{
    public static class Service_Locator
    {
        // This holds a reference to the built service provider from the Dependency Injection library.
        private static ServiceProvider? service_provider;

        // Retrieve a service from the DI container based on the given type T.
        public static T? Get_Service<T>() where T : class
        {
            if (service_provider == null)
            {
                throw new InvalidOperationException("Service provider is not set.");
            }
            return service_provider.GetRequiredService<T>();
        }

        // Overloaded method to get a service based on a runtime type, rather than a compile-time generic type.
        public static object? Get_Service(Type service_type)
        {
            return service_provider?.GetService(service_type);
        }

        // Allows setting the service provider. Used after building the DI container.
        public static void Set_Service_Provider(ServiceProvider Service_provider)
        {
            service_provider = Service_provider;
        }
    }
}