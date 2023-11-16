using Microsoft.EntityFrameworkCore;
using MiniPaymentApiV1.Domain.Entities;

namespace MiniPaymentApiV1.Persistence.Contexts
{
    public class MiniPaymentAPIDbContext : DbContext
    {
        public MiniPaymentAPIDbContext(DbContextOptions options) : base(options)
        { }

        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<TransactionDetails> TransactionDetails { get; set; }


    }
}
