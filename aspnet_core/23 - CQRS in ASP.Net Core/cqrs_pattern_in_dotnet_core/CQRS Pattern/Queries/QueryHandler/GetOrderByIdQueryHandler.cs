using cqrs_pattern_in_dotnet_core.Models;
using MediatR;

namespace cqrs_pattern_in_dotnet_core.CQRS_Pattern.Queries.QueryHandler
{
    public class GetOrderByIdQueryHandler : IRequestHandler<GetOrderByIdQuery, Order>
    {
        private readonly ApplicationDbContext _context;
        public GetOrderByIdQueryHandler(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Order> Handle(GetOrderByIdQuery request, CancellationToken cancellationToken)
        {
            return await _context.Orders.FindAsync(new object[] { request.OrderId }, cancellationToken);
        }
    }
}
