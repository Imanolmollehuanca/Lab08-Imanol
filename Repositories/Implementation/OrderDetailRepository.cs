using Lab08_Imanol.Models;
using Lab08_Imanol.Repositories;

namespace Lab08_Imanol.Repositories.Implementation;

public class OrderdetailRepository : IOrderdetailRepository
{
    private readonly ApplicationDbContext _context;

    public OrderdetailRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public List<object> GetProductsByOrder(int orderId)
    {
        return _context.Orderdetails
            .Where(od => od.Orderid == orderId)
            .Select(od => new
            {
                ProductName = od.Product.Name,
                Quantity = od.Quantity
            })
            .Cast<object>()
            .ToList();
    }

    public int GetTotalQuantityByOrder(int orderId)
    {
        return _context.Orderdetails
            .Where(od => od.Orderid == orderId)
            .Select(od => od.Quantity)
            .Sum();
    }

    public List<object> GetAllOrderDetails()
    {
        return _context.Orderdetails
            .Where(od => od.Orderid > 0)
            .Select(od => new
            {
                OrderId = od.Orderid,
                ProductName = od.Product.Name,
                Quantity = od.Quantity
            })
            .Cast<object>()
            .ToList();
    }

    public List<object> GetClientsByProduct(int productId)
    {
        return _context.Orderdetails
            .Where(od => od.Productid == productId)
            .Select(od => new
            {
                ClientName = od.Order.Client.Name
            })
            .Distinct()
            .Cast<object>()
            .ToList();
    }
}

public interface IOrderdetailRepository
{
    List<object> GetClientsByProduct(int productId);
    List<object> GetAllOrderDetails();
    int GetTotalQuantityByOrder(int orderId);
    List<object> GetProductsByOrder(int orderId);
}