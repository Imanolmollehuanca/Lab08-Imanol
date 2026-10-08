using Lab08_Imanol.Models;

namespace Lab08_Imanol.Services;

public interface IProductService
{
    List<Product> GetProductsByPrice(decimal price);
    Product? GetMostExpensiveProduct();
    decimal GetAverageProductPrice();
    List<Product> GetProductsWithoutDescription();
}