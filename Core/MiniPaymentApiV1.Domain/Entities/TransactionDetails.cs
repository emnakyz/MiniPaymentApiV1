using MiniPaymentApiV1.Domain.Entities.Common;

namespace MiniPaymentApiV1.Domain.Entities
{
    public class TransactionDetails : BaseEntity
    {

        public Guid TransactionId { get; set; }
        public Transaction Transaction { get; set; }
        public string TransactionType { get; set; }
        public bool Status { get; set; }
        public int Amount { get; set; }
    }
}
