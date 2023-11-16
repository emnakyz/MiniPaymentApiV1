using MiniPaymentApiV1.Application.Repositories;
using MiniPaymentApiV1.Domain.Entities;
using MiniPaymentApiV1.Persistence.Contexts;

namespace MiniPaymentApiV1.Persistence.Repositories
{
    public class TransactionWriteRepository : WriteRepository<Transaction>, ITransactionWriteRepository
    {
        public TransactionWriteRepository(MiniPaymentAPIDbContext context) : base(context)
        {
        }
    }
}
