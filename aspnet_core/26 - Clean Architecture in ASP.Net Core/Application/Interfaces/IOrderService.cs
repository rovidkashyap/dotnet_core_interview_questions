using Core.Entities;

namespace Application.Interfaces
{
    public interface IOrderService
    {
        Task<Order> GetOrderByIdAsync(Guid id);
        Task<IEnumerable<Order>> GetAllOrdersAsync();
        Task AddOrderAsync(Order order);
        Task UpdateOrderAsync(Order order);
        Task DeleteOrderAsync(Guid id);
    }
}
