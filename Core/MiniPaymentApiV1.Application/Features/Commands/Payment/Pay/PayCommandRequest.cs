using MediatR;

namespace MiniPaymentApiV1.Application.Features.Commands.Payment.Pay
{

    public class PayCommandRequest : IRequest<PayCommandResponse>
    {
        public decimal TotalAmount { get; set; }
        public decimal NetAmount { get; set; }
        public string Status { get; set; }
        public string OrderReference { get; set; }

    }

}
