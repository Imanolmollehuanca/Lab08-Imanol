using Lab08_Imanol.Models;

namespace Lab08_Imanol.Services;

public interface IOrderService
{
    List<Order> GetOrdersAfterDate(DateTime date);
    object? GetClientWithMostOrders();
    List<object> GetProductsByClient(int clientId);
}