using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MiniPaymentApiV1.Application.Abstractions.Services;
using MiniPaymentApiV1.Application.Repositories;
using MiniPaymentApiV1.Persistence.Contexts;
using MiniPaymentApiV1.Persistence.Repositories;
using MiniPaymentApiV1.Persistence.Services;

namespace MiniPaymentApiV1.Persistence
{
    public static class ServiceRegistration
    {
        public static void AddPersistenceServices(this IServiceCollection services)
        {
            services.AddDbContext<MiniPaymentAPIDbContext>(options => options.UseSqlServer(Configuration.ConnectionString));


            services.AddScoped<ITransactionReadRepository, TransactionReadRepository>();
            services.AddScoped<ITransactionWriteRepository, TransactionWriteRepository>();
            services.AddScoped<ITransactionDetailsReadRepository, TransactionDetailsReadRepository>();
            services.AddScoped<ITransactionDetailsWriteRepository, TransactionDetailsWriteRepository>();




            services.AddScoped<IPaymentService, PaymentService>();
         

        }
    }
}
