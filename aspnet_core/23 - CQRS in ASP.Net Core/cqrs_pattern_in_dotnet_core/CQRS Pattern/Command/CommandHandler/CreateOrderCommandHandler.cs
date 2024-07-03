using cqrs_pattern_in_dotnet_core.Models;
using MediatR;

namespace cqrs_pattern_in_dotnet_core.CQRS_Pattern.Command.CommandHandler
{
    public class CreateOrderCommandHandler : IRequestHandler<CreateOrderCommand, Guid>
    {
        private readonly ApplicationDbContext _context;
        public CreateOrderCommandHandler(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Guid> Handle(CreateOrderCommand request, CancellationToken cancellationToken)
        {
            var order = new Order
            {
                Id = Guid.NewGuid(),
                ProductName = request.ProductName,
                Quantity = request.Quantity,
                OrderDate = DateTime.UtcNow
            };

            _context.Orders.Add(order);
            await _context.SaveChangesAsync(cancellationToken);

            return order.Id;
        }
    }
}
