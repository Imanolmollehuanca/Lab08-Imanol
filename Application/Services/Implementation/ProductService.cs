using Lab08_Imanol.DTOs;
using Lab08_Imanol.Application.Ports.Outbound;

namespace Lab08_Imanol.Application.Services.Implementation;

public class ProductService : IProductService
{
    private readonly IProductRepository _repository;

    public ProductService(IProductRepository repository)
    {
        _repository = repository;
    }

    public Task<List<ProductDto>> GetProductsAsync(CancellationToken cancellationToken = default)
    {
        return _repository.ObtenerProductosAsync(cancellationToken);
    }
}
