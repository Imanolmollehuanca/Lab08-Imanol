using Lab08_Imanol.DTOs;

namespace Lab08_Imanol.Application.Ports.Outbound;

public interface IClienteRepository
{
    Task<List<ClientOrderDto>> ObtenerClientesConPedidosAsync(CancellationToken cancellationToken = default);
    Task<List<SalesByClientDto>> ObtenerVentasPorClienteAsync(CancellationToken cancellationToken = default);
}
