using MiniPaymentApiV1.Domain.Entities;

namespace MiniPaymentApiV1.Application.Repositories
{
    public interface ITransactionWriteRepository : IWriteRepository<Transaction>
    {
    }
}
