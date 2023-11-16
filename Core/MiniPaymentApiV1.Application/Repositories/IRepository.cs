using Microsoft.EntityFrameworkCore;
using MiniPaymentApiV1.Domain.Entities.Common;

namespace MiniPaymentApiV1.Application.Repositories
{
    public interface IRepository<T> where T : BaseEntity
    {
        DbSet<T> Table { get; }
    }
}
