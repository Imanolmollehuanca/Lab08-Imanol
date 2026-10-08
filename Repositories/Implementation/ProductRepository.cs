using Lab08_Imanol.Models;

namespace Lab08_Imanol.Repositories.Implementation;

public class ProductRepository : IProductRepository
{
    private readonly ApplicationDbContext _context;

    public ProductRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public List<Product> GetProductsByPrice(decimal price)
    {
        return _context.Products
            .Where(p => p.Price > price)
            .ToList();
    }

    public Product? GetMostExpensiveProduct()
    {
        return _context.Products
            .OrderByDescending(p => p.Price)
            .FirstOrDefault();
    }

    public decimal GetAverageProductPrice()
    {
        return _context.Products
            .Select(p => p.Price)
            .Average();
    }

    public List<Product> GetProductsWithoutDescription()
    {
        return _context.Products
            .Where(p => string.IsNullOrEmpty(p.Description))
            .ToList();
    }
}













