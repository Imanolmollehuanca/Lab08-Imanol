using Lab08_Imanol.DTOs;
using Lab08_Imanol.Application.Ports.Outbound;

namespace Lab08_Imanol.Application.Services.Implementation;

public class OrderService : IOrderService
{
    private readonly IOrderRepository _repository;

    public OrderService(IOrderRepository repository)
    {
        _repository = repository;
    }

    public Task<List<OrderDto>> GetOrdersAsync(CancellationToken cancellationToken = default)
    {
        return _repository.ObtenerPedidosAsync(cancellationToken);
    }
}
