using MediatR;
using MiniPaymentApiV1.Application.Abstractions.Services;
using MiniPaymentApiV1.Application.Repositories;

namespace MiniPaymentApiV1.Application.Features.Commands.Payment.Pay
{


    public class PayCommandHandler : IRequestHandler<PayCommandRequest, PayCommandResponse>
    {

        readonly IPaymentService _paymentService;

        public PayCommandHandler(IPaymentService paymentService)
        {
            _paymentService = paymentService;

        }

        public async Task<PayCommandResponse> Handle(PayCommandRequest request, CancellationToken cancellationToken)
        {

            //PayCommandResponse response = await _paymentService.PayAsync(new()
            //{
            //    //TotalAmount = request.TotalAmount,
            //    //NetAmount = request.NetAmount,
            //    //Status = request.Status,
            //    //OrderReference = request.OrderReference

            //    BankId = request.BankId,
            //    TotalAmount = request.TotalAmount,
            //    NetAmount = request.NetAmount,
            //    //Status = request.Status,
            //    OrderReference = request.OrderReference,


            //});


            PayCommandResponse response = await _paymentService.PayAsync(new()
            {
                BankId = request.BankId,
                TotalAmount = request.TotalAmount,
                NetAmount = request.NetAmount,
                OrderReference = request.OrderReference,
            });

            return new()
            {
                Message = response.Message,
            };
        }
    }
}
