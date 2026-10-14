using Lab08_Imanol.DTOs;

namespace Lab08_Imanol.Application.Services;

public interface IOrderService
{
    Task<List<OrderDto>> GetOrdersAsync(CancellationToken cancellationToken = default);
}
