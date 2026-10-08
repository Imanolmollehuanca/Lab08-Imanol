using Lab08_Imanol.Services;
using Microsoft.AspNetCore.Mvc;

namespace Lab08_Imanol.Controllers;

[ApiController]
[Route("api/[controller]")]
public class OrdersController : ControllerBase
{
    private readonly IOrderService _orderService;

    public OrdersController(IOrderService orderService)
    {
        _orderService = orderService;
    }

    [HttpGet("after-date")]
    public IActionResult GetOrdersAfterDate([FromQuery] DateTime date)
    {
        var orders = _orderService.GetOrdersAfterDate(date);

        return Ok(orders);
    }
    [HttpGet("client-most-orders")]
    public IActionResult GetClientWithMostOrders()
    {
        var result = _orderService.GetClientWithMostOrders();

        return Ok(result);
    }
    [HttpGet("products-by-client/{clientId}")]
    public IActionResult GetProductsByClient(int clientId)
    {
        var products = _orderService.GetProductsByClient(clientId);

        return Ok(products);
    }
    
}