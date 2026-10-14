using Lab08_Imanol.Models;
using Lab08_Imanol.DTOs;
using Microsoft.EntityFrameworkCore;

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
    
    
    public List<OrderDetailsDto> ObtenerPedidosConDetalles()
    {
        var ordersWithDetails = _context.Orders
            .Include(order => order.Orderdetails)
            .ThenInclude(orderDetail => orderDetail.Product)
            .AsNoTracking()
            .Select(order => new OrderDetailsDto
            {
                OrderId = order.Orderid,
                OrderDate = order.OrderDate,
                Products = order.Orderdetails
                    .Select(od => new ProductDto
                    {
                        ProductName = od.Product.Name,
                        Quantity = od.Quantity,
                        Price = od.Product.Price
                    })
                    .ToList()
            })
            .ToList();

        return ordersWithDetails;
    }
    
    public List<SalesByClientDto> ObtenerVentasPorCliente()
    {
        return _context.Orders
            .Include(order => order.Orderdetails)
            .ThenInclude(orderDetail => orderDetail.Product)
            .AsNoTracking()
            .GroupBy(order => order.ClientId)
            .Select(group => new SalesByClientDto
            {
                ClientName = _context.Clients
                    .FirstOrDefault(c => c.Clientid == group.Key)!.Name,
                TotalSales = group.Sum(order => order.Orderdetails
                    .Sum(detail => detail.Quantity * detail.Product.Price))
            })
            .OrderByDescending(s => s.TotalSales)
            .ToList();
    }


}