using Microsoft.Extensions.DependencyInjection;

namespace MiniPaymentApiV1.Application
{
    public static class ServiceRegistration
    {
        public static void AddApplicationServices(this IServiceCollection collection)
        {
            collection.AddHttpClient();
        }
    }
}
