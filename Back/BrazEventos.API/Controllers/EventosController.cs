using BrazEventos.API.Data;
using BrazEventos.API.Models;
using Microsoft.AspNetCore.Mvc;

namespace BrazEventos.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class EventosController : ControllerBase
{
    private readonly DataContext _context;

    public EventosController(DataContext context)
    {
        _context = context;
    }

    [HttpGet]
    public IEnumerable<Evento> Get()
    {
        return _context.Eventos;
    }

    [HttpGet("{id}")]
    public Evento GetById(int id)
    {
        return _context.Eventos.FirstOrDefault(
            evento => evento.EventoID == id
        );
    }
}
