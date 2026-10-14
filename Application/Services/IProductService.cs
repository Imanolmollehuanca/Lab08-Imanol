using Lab08_Imanol.DTOs;

namespace Lab08_Imanol.Application.Services;

public interface IProductService
{
    Task<List<ProductDto>> GetProductsAsync(CancellationToken cancellationToken = default);
}
