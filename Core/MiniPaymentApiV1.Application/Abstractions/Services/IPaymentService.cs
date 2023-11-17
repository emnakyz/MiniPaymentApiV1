using MiniPaymentApiV1.Application.DTOs.Payment;
using MiniPaymentApiV1.Domain.Entities;
using MiniPaymentApiV1.Domain.Enums;

namespace MiniPaymentApiV1.Application.Abstractions.Services
{
    public interface IPaymentService
    {


        public Task<List<Transaction>> GetTransactionsAsync(int bankId, TransactionStatus? status, string orderReference, DateTime? startDate, DateTime? endDate);
        public Task PayAsync(CreateTransaction transaction);
        public Task CancelAsync(Guid transactionId);
        public Task RefundAsync(Guid transactionId);

    }
}
