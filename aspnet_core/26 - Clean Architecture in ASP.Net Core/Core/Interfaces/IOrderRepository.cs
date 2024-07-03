using Core.Entities;

namespace Core.Interfaces
{
    public interface IOrderRepository
    {
        Task<Order> GetByIdAsync(Guid id);
        Task<IEnumerable<Order>> GetAllAsync();
        Task AddAsync(Order order);
        Task UpdateAsync(Order order);
        Task DeleteAsync(Order order);
    }
}
