using Lab08_Imanol.Services;
using Microsoft.AspNetCore.Mvc;

namespace Lab08_Imanol.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ClientController : ControllerBase
{
    private readonly IClientService _clientService;

    public ClientController(IClientService clientService)
    {
        _clientService = clientService;
    }

    [HttpGet("by-name")]
    public IActionResult GetClientsByName([FromQuery] string name)
    {
        var clients = _clientService.GetClientsByName(name);
        return Ok(clients);
    }
}