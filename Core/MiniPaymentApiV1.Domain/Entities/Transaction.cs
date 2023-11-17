using MiniPaymentApiV1.Domain.Entities.Common;
using System.Transactions;

namespace MiniPaymentApiV1.Domain.Entities
{
    public class Transaction : BaseEntity
    {


        public string? BankId { get; set; }
        public decimal TotalAmount { get; set; }
        public decimal NetAmount { get; set; }
        public string Status { get; set; }
        public string OrderReference { get; set; }
        public DateTime? TransactionDate { get; set; }
        public List<TransactionDetails> TransactionDetails { get; set; }

    }
}
