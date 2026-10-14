using Lab08_Imanol.Models;

namespace Lab08_Imanol.DTOs;

public class OrderDetailsDto
{
    public int OrderId { get; set; }
    public DateTime OrderDate { get; set; }
    public List<ProductDto> Products { get; set; } = new();
}