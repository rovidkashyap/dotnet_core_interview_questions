using MediatR;

namespace cqrs_pattern_in_dotnet_core.CQRS_Pattern.Command
{
    public class CreateOrderCommand : IRequest<Guid>
    {
        public string ProductName { get; set; }
        public int Quantity { get; set; }
    }
}
