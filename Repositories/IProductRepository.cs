using Lab08_Imanol.Models;

namespace Lab08_Imanol.Repositories;

public interface IProductRepository
{
    List<Product> GetProductsByPrice(decimal price);
    Product? GetMostExpensiveProduct();
    decimal GetAverageProductPrice();
    List<Product> GetProductsWithoutDescription();
    
}