using Microsoft.AspNetCore.Mvc;

namespace BrazEventos.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class EventoController : ControllerBase
{
    public EventoController()
    {
    }

    [HttpGet(Name = "GetEvento")]
    public string Get()
    {
        return "teste";
    }
}
