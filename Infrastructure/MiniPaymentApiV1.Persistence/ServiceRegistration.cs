using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MiniPaymentApiV1.Persistence.Contexts;

namespace MiniPaymentApiV1.Persistence
{
    public static class ServiceRegistration
    {
        public static void AddPersistenceServices(this IServiceCollection services)
        {
            services.AddDbContext<MiniPaymentAPIDbContext>(options => options.UseSqlServer(Configuration.ConnectionString));

        }
    }
}
