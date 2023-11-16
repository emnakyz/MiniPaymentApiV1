using MiniPaymentApiV1.Domain.Entities.Common;

namespace MiniPaymentApiV1.Domain.Entities
{
    public class Transaction : BaseEntity
    {
        public int BankId { get; set; }
        public int TotalAmount { get; set; }
        public int NetAmount { get; set; }
        public bool Status { get; set; }
        public string OrderReferance { get; set; }
        public DateTime TransactionDate { get; set; }
        public ICollection<TransactionDetails> TransactionDetails { get; set; }
    }
}
