using Lab08_Imanol.DTOs;

namespace Lab08_Imanol.Application.Ports.Outbound;

public interface IProductRepository
{
    Task<List<ProductDto>> ObtenerProductosAsync(CancellationToken cancellationToken = default);
}
