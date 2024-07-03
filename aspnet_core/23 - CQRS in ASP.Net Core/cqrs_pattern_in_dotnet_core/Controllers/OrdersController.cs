using cqrs_pattern_in_dotnet_core.CQRS_Pattern.Command;
using cqrs_pattern_in_dotnet_core.CQRS_Pattern.Queries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace cqrs_pattern_in_dotnet_core.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OrdersController : ControllerBase
    {
        private readonly IMediator _mediator;
        public OrdersController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> CreateOrder(CreateOrderCommand command)
        {
            var orderId = await _mediator.Send(command);
            return Ok(orderId);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetOrderById(Guid id)
        {
            var query = new GetOrderByIdQuery { OrderId = id };
            var order = await _mediator.Send(query);
            return Ok(order);
        }
    }
}
