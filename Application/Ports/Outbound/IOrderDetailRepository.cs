using Lab08_Imanol.DTOs;

namespace Lab08_Imanol.Application.Ports.Outbound;

public interface IOrderDetailRepository
{
    Task<List<OrderDetailsDto>> ObtenerDetallesAsync(CancellationToken cancellationToken = default);
}
