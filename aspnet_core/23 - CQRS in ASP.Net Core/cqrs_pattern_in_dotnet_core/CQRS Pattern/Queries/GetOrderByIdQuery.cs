using cqrs_pattern_in_dotnet_core.Models;
using MediatR;

namespace cqrs_pattern_in_dotnet_core.CQRS_Pattern.Queries
{
    public class GetOrderByIdQuery : IRequest<Order>
    {
        public Guid OrderId { get; set; }
    }
}
