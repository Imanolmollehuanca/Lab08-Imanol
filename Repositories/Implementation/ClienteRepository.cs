using Lab08_Imanol.DTOs;
using Lab08_Imanol.Models;
using Microsoft.EntityFrameworkCore;

namespace Lab08_Imanol.Repositories.Implementation;

public class ClientRepository : IClientRepository
{
    private readonly ApplicationDbContext _context;

    public ClientRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public List<Client> GetClientsByName(string name)
    {
        return _context.Clients
            .Where(c => c.Name.StartsWith(name))
            .Select(c => new Client
            {
                Clientid = c.Clientid,
                Name = c.Name,
                Email = c.Email,
                Orders = new List<Order>()
            })
            .ToList();
    }

    public List<ClientOrderDto> ObtenerClientesConPedidos()
    {
        var clientOrders = _context.Clients
            .AsNoTracking()
            .Select(client => new ClientOrderDto
            {
                ClientName = client.Name,
                Orders = client.Orders
                    .Select(order => new OrderDto
                    {
                        OrderId = order.Orderid,
                        OrderDate = order.OrderDate
                    }).ToList()
            }).ToList();

        return clientOrders;
    }
    
    public List<object> ObtenerClientesConTotalProductos()
    {
        var clientsWithProductCount = _context.Clients
            .AsNoTracking()
            .Select(client => new
            {
                ClientName = client.Name,
                TotalProducts = client.Orders
                    .Sum(order => order.Orderdetails
                        .Sum(detail => detail.Quantity))
            })
            .ToList<object>();

        return clientsWithProductCount;
    }

}