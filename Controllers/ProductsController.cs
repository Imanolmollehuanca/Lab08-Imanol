using Lab08_Imanol.Services;
using Microsoft.AspNetCore.Mvc;

namespace Lab08_Imanol.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ProductsController : ControllerBase
{
    private readonly IProductService _productService;

    public ProductsController(IProductService productService)
    {
        _productService = productService;
    }

    [HttpGet("by-price")]
    public IActionResult GetProductsByPrice([FromQuery] decimal price)
    {
        var products = _productService.GetProductsByPrice(price);

        return Ok(products);
    }

    [HttpGet("most-expensive")]
    public IActionResult GetMostExpensiveProduct()
    {
        var product = _productService.GetMostExpensiveProduct();

        return Ok(product);
    }
    [HttpGet("average-price")]
    public IActionResult GetAverageProductPrice()
    {
        var average = _productService.GetAverageProductPrice();

        return Ok(average);
    }
    [HttpGet("without-description")]
    public IActionResult GetProductsWithoutDescription()
    {
        var products = _productService.GetProductsWithoutDescription();

        return Ok(products);
    }
}