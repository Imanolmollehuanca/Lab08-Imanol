using Lab08_Imanol.DTOs;

namespace Lab08_Imanol.Application.Ports.Outbound;

public interface IOrderRepository
{
    Task<List<OrderDto>> ObtenerPedidosAsync(CancellationToken cancellationToken = default);
}
