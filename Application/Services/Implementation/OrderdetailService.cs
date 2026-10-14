using Lab08_Imanol.DTOs;
using Lab08_Imanol.Application.Ports.Outbound;

namespace Lab08_Imanol.Application.Services.Implementation;

public class OrderdetailService : IOrderDetailService
{
    private readonly IOrderDetailRepository _repository;

    public OrderdetailService(IOrderDetailRepository repository)
    {
        _repository = repository;
    }

    public Task<List<OrderDetailsDto>> GetOrderDetailsAsync(CancellationToken cancellationToken = default)
    {
        return _repository.ObtenerDetallesAsync(cancellationToken);
    }
}
