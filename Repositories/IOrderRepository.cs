using Lab08_Imanol.Models;

namespace Lab08_Imanol.Repositories;

public interface IOrderRepository
{
    List<Order> GetOrdersAfterDate(DateTime date);
    object? GetClientWithMostOrders();
    List<object> GetProductsByClient(int clientId);
}