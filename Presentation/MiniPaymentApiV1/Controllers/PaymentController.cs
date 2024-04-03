using MediatR;
using Microsoft.AspNetCore.Mvc;
using MiniPaymentApiV1.Application.Consts;
using MiniPaymentApiV1.Application.CustomAttributes;
using MiniPaymentApiV1.Application.Enums;
using MiniPaymentApiV1.Application.Features.Commands.Payment.Pay;

namespace MiniPaymentApiV1.Controllers
{


    [Route("api/[controller]")]
    [ApiController]
    //[Authorize(AuthenticationSchemes = "Admin")]
    public class PaymentController : ControllerBase
    {
        readonly IMediator _mediator;
        public PaymentController(IMediator mediator)
        {
            _mediator = mediator;
        }

        //    
        [HttpPost]
        [AuthorizeDefinition(Menu = AuthorizeDefinitionConstants.Payment, ActionType = ActionType.Writing, Definition = "Create Payment")]
        public async Task<ActionResult> Pay(PayCommandRequest payCommandRequest)
        {
            PayCommandResponse response = await _mediator.Send(payCommandRequest);
            return Ok(response);
        }

        
    }
}
