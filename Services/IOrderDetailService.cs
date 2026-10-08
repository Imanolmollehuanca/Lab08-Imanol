using Lab08_Imanol.Models;

namespace Lab08_Imanol.Services;

public interface IOrderdetailService
{
    List<object> GetProductsByOrder(int orderId);
    int GetTotalQuantityByOrder(int orderId);
    List<object> GetAllOrderDetails();
    List<object> GetClientsByProduct(int productId);
}