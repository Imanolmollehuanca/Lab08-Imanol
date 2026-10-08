using Lab08_Imanol.Models;
using Lab08_Imanol.Repositories;

namespace Lab08_Imanol.Services.Implementation;

public class OrderService : IOrderService
{
    private readonly IOrderRepository _orderRepository;

    public OrderService(IOrderRepository orderRepository)
    {
        _orderRepository = orderRepository;
    }

    public List<Order> GetOrdersAfterDate(DateTime date)
    {
        return _orderRepository.GetOrdersAfterDate(date);
    }

    public object? GetClientWithMostOrders()
    {
        return _orderRepository.GetClientWithMostOrders();
    }

    public List<object> GetProductsByClient(int clientId)
    {
        return _orderRepository.GetProductsByClient(clientId);
    }
}