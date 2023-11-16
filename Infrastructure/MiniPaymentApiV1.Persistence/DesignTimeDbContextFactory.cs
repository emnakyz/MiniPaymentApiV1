using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using MiniPaymentApiV1.Persistence.Contexts;

namespace MiniPaymentApiV1.Persistence
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<MiniPaymentAPIDbContext>
    {
        public MiniPaymentAPIDbContext CreateDbContext(string[] args)
        {
            DbContextOptionsBuilder<MiniPaymentAPIDbContext> dbContextOptionsBuilder = new();
            dbContextOptionsBuilder.UseSqlServer(Configuration.ConnectionString);
            return new(dbContextOptionsBuilder.Options);
        }
    }
}
