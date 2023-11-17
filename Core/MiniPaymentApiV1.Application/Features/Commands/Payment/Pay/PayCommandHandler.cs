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
            await _paymentService.PayAsync(new()
            {
                TotalAmount = request.TotalAmount,
                NetAmount = request.NetAmount,
                Status = request.Status,
                OrderReference = request.OrderReference

            });

            return new();
        }
    }
}
