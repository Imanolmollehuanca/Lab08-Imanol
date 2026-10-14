using Lab08_Imanol.DTOs;

namespace Lab08_Imanol.Application.Services;

public interface IClientService
{
    Task<List<ClientOrderDto>> GetClientsWithOrdersAsync(CancellationToken cancellationToken = default);
    Task<List<SalesByClientDto>> GetSalesByClientAsync(CancellationToken cancellationToken = default);
}
