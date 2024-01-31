using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniPaymentApiV1.Application.DTOs.Payment
{

    public class CreateTransaction
    {
        public string? BankId { get; set; }
        public decimal TotalAmount { get; set; }
        public decimal NetAmount { get; set; }
        public string Status { get; set; }
        public string OrderReference { get; set; }
    }
}
