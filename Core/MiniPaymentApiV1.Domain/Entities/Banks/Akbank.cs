namespace MiniPaymentApiV1.Domain.Entities.Banks
{
    public class Akbank : BankBase
    {
        public override void Cancel(Guid transactionId)
        {
            throw new NotImplementedException();
        }

        public override void Pay(Transaction transaction)
        {
            throw new NotImplementedException();
        }

        public override void Refund(Guid transactionId)
        {
            throw new NotImplementedException();
        }
    }
}
