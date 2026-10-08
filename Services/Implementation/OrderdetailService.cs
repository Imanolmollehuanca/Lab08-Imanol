using Lab08_Imanol.Repositories;
using Lab08_Imanol.Repositories.Implementation;

namespace Lab08_Imanol.Services.Implementation;

public class OrderdetailService : IOrderdetailService
{
    private readonly IOrderdetailRepository _repository;

    public OrderdetailService(IOrderdetailRepository repository)
    {
        _repository = repository;
    }

    public List<object> GetProductsByOrder(int orderId)
    {
        return _repository.GetProductsByOrder(orderId);
    }

    public int GetTotalQuantityByOrder(int orderId)
    {
        return _repository.GetTotalQuantityByOrder(orderId);
    }

    public List<object> GetAllOrderDetails()
    {
        return _repository.GetAllOrderDetails();
    }

    public List<object> GetClientsByProduct(int productId)
    {
        return _repository.GetClientsByProduct(productId);
    }
}