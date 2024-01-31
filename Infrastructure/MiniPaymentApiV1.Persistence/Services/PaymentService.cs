using MiniPaymentApiV1.Application.Abstractions.Services;
using MiniPaymentApiV1.Application.DTOs.Payment;
using MiniPaymentApiV1.Application.Features.Commands.Payment.Pay;
using MiniPaymentApiV1.Application.Repositories;
using MiniPaymentApiV1.Domain.Entities;
using MiniPaymentApiV1.Domain.Enums;

namespace MiniPaymentApiV1.Persistence.Services
{

    public class PaymentService : IPaymentService
    {

        readonly ITransactionWriteRepository _transactionWriteRepository;
        readonly ITransactionReadRepository _transactionReadRepository;
        readonly ITransactionDetailsWriteRepository _transactionDetailsWriteRepository;
        readonly ITransactionDetailsReadRepository _transactionDetailsReadRepository;
        public PaymentService(ITransactionWriteRepository transactionWriteRepository, ITransactionDetailsWriteRepository transactionDetailsWriteRepository, ITransactionReadRepository transactionReadRepository, ITransactionDetailsReadRepository transactionDetailsReadRepository)
        {

            _transactionWriteRepository = transactionWriteRepository;
            _transactionDetailsWriteRepository = transactionDetailsWriteRepository;
            _transactionReadRepository = transactionReadRepository;
            _transactionDetailsReadRepository = transactionDetailsReadRepository;

        }

        public Task CancelAsync(Guid transactionId)
        {
            throw new NotImplementedException();
        }

        public Task<List<Transaction>> GetTransactionsAsync(int bankId, TransactionStatus? status, string orderReference, DateTime? startDate, DateTime? endDate)
        {
            throw new NotImplementedException();
        }

        public async Task<PayCommandResponse> PayAsync(CreateTransaction transaction)
        {


            await _transactionWriteRepository.AddAsync(new()
            {

                Id = Guid.NewGuid(),
                BankId = transaction.BankId,
                TotalAmount = transaction.TotalAmount,
                NetAmount = transaction.NetAmount,
                Status = "Success", 
                OrderReference = transaction.OrderReference,
                TransactionDate = DateTime.Now
            });
            await _transactionWriteRepository.SaveAsync();

          
            PayCommandResponse response = new() { Message = "Payment successful." };         
            return response;
        }

        public Task RefundAsync(Guid transactionId)
        {
            throw new NotImplementedException();
        }
    }
}
