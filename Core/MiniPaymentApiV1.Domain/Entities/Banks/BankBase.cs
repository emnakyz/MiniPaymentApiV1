using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniPaymentApiV1.Domain.Entities.Banks
{
    public abstract class BankBase
    {
        public abstract void Pay(Transaction transaction);
        public abstract void Cancel(Guid transactionId);
        public abstract void Refund(Guid transactionId);
    }
}
