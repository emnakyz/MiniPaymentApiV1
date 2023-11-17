using MiniPaymentApiV1.Domain.Entities.Common;
using MiniPaymentApiV1.Domain.Enums;

namespace MiniPaymentApiV1.Domain.Entities
{
    public class TransactionDetails : BaseEntity
    {

        public Guid TransactionId { get; set; }
        public string TransactionType { get; set; }
        public string Status { get; set; }
        public decimal Amount { get; set; }

        public Transaction Transaction { get; set; }
    }
}
