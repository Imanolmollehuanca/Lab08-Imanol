using Lab08_Imanol.Models;
using Lab08_Imanol.Repositories;

namespace Lab08_Imanol.Services.Implementation;

public class ProductService : IProductService
{
    private readonly IProductRepository _productRepository;

    public ProductService(IProductRepository productRepository)
    {
        _productRepository = productRepository;
    }

    public List<Product> GetProductsByPrice(decimal price)
    {
        return _productRepository.GetProductsByPrice(price);
    }

    public Product? GetMostExpensiveProduct()
    {
        return _productRepository.GetMostExpensiveProduct();
    }

    public decimal GetAverageProductPrice()
    {
        return _productRepository.GetAverageProductPrice();
    }

    public List<Product> GetProductsWithoutDescription()
    {
        return _productRepository.GetProductsWithoutDescription();
    }
}