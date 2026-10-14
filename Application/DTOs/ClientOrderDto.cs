using System.Collections.Generic;

namespace Lab08_Imanol.Application.DTOs;

public class ClientOrderDto
{
    public string? ClientName { get; set; }
    public List<OrderDto>? Orders { get; set; }
}