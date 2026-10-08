using Lab08_Imanol.Models;

namespace Lab08_Imanol.Repositories.Implementation;

public class OrderRepository : IOrderRepository
{
    private readonly ApplicationDbContext _context;

    public OrderRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public List<Order> GetOrdersAfterDate(DateTime date)
    {
        return _context.Orders
            .Where(o => o.OrderDate > date)
            .ToList();
    }

    public object? GetClientWithMostOrders()
    {
        return _context.Orders
            .GroupBy(o => o.ClientId)
            .Select(g => new
            {
                ClientId = g.Key,
                OrderCount = g.Count()
            })
            .OrderByDescending(g => g.OrderCount)
            .FirstOrDefault();
    }

    public List<object> GetProductsByClient(int clientId)
    {
        return _context.Orders
            .Where(o => o.ClientId == (int)clientId)
            .SelectMany(o => o.Orderdetails)
            .Select(od => new
            {
                ProductName = od.Product.Name
            })
            .Cast<object>()
            .ToList();
    }
}