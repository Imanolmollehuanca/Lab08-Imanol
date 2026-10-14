using Lab08_Imanol.DTOs;

namespace Lab08_Imanol.Application.Services;

public interface IOrderDetailService
{
    Task<List<OrderDetailsDto>> GetOrderDetailsAsync(CancellationToken cancellationToken = default);
}
