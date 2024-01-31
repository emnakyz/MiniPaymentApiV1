using MediatR;
using MiniPaymentApiV1.Application.Abstractions.Services;
using MiniPaymentApiV1.Application.Features.Commands.Payment.Pay;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniPaymentApiV1.Application.Features.Commands.Payment.Cancel
{
    public class CancelCommandHandler : IRequestHandler<CancelCommandRequest, CancelCommandResponse>
    {

        readonly IPaymentService _paymentService;

        public CancelCommandHandler(IPaymentService paymentService)
        {
            _paymentService = paymentService;

        }

        public Task<CancelCommandResponse> Handle(CancelCommandRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
