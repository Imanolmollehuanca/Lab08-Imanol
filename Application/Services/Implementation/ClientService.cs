using Lab08_Imanol.DTOs;
using Lab08_Imanol.Application.Ports.Outbound;

namespace Lab08_Imanol.Application.Services.Implementation;

public class ClientService : IClientService
{
    private readonly IClienteRepository _repository;

    public ClientService(IClienteRepository repository)
    {
        _repository = repository;
    }

    public Task<List<ClientOrderDto>> GetClientsWithOrdersAsync(CancellationToken cancellationToken = default)
    {
        return _repository.ObtenerClientesConPedidosAsync(cancellationToken);
    }

    public Task<List<SalesByClientDto>> GetSalesByClientAsync(CancellationToken cancellationToken = default)
    {
        return _repository.ObtenerVentasPorClienteAsync(cancellationToken);
    }
}
