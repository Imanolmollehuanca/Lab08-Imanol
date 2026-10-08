using Lab08_Imanol.Models;

namespace Lab08_Imanol.Repositories;

public interface IOrderDetailRepository
{
    List<object> GetProductsByOrder(int orderId);
    int GetTotalQuantityByOrder(int orderId);
    List<object> GetAllOrderDetails();
    List<object> GetClientsByProduct(int productId);
}