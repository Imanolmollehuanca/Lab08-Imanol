using Lab08_Imanol.Services;
using Microsoft.AspNetCore.Mvc;

namespace Lab08_Imanol.Controllers;

[ApiController]
[Route("api/[controller]")]
public class OrderdetailsController : ControllerBase
{
    private readonly IOrderdetailService _service;

    public OrderdetailsController(IOrderdetailService service)
    {
        _service = service;
    }

    [HttpGet("by-order/{orderId}")]
    public IActionResult GetProductsByOrder(int orderId)
    {
        var result = _service.GetProductsByOrder(orderId);

        return Ok(result);
    }

    [HttpGet("total-quantity/{orderId}")]
    public IActionResult GetTotalQuantityByOrder(int orderId)
    {
        var total = _service.GetTotalQuantityByOrder(orderId);

        return Ok(total);
    }

    [HttpGet("all-details")]
    public IActionResult GetAllOrderDetails()
    {
        var result = _service.GetAllOrderDetails();

        return Ok(result);
    }
    [HttpGet("clients-by-product/{productId}")]
    public IActionResult GetClientsByProduct(int productId)
    {
        var clients = _service.GetClientsByProduct(productId);

        return Ok(clients);
    }
}