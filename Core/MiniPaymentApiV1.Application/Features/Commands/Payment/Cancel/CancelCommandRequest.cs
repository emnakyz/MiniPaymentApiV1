using MediatR;

namespace MiniPaymentApiV1.Application.Features.Commands.Payment.Cancel
{


    public class CancelCommandRequest : IRequest<CancelCommandResponse>
    {
        public string? BankId { get; set; }
        public decimal TotalAmount { get; set; }
        public decimal NetAmount { get; set; }
        public string OrderReference { get; set; }

    }
}
