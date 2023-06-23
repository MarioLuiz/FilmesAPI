using FilmesAPI.Data;
using FilmesAPI.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace FilmesAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class FilmeController : ControllerBase
{
    private FilmeContext _context;

    public FilmeController(FilmeContext context)
    {
        this._context = context;
    }

    [HttpPost]
    public IActionResult AdicionarFilme([FromBody] Filme filme)
    {
        _context.filmes.Add(filme);
        _context.SaveChanges();
        return CreatedAtAction(nameof(RetornaFilmePorId), new { id = filme.Id }, filme);
    }

    [HttpGet]
    public IEnumerable<Filme> RetornaFilmes([FromQuery] int skip = 0, [FromQuery] int take = 50)
    {
        return _context.filmes.Skip(skip).Take(take);
    }

    [HttpGet("{id}")]
    public IActionResult RetornaFilmePorId(int id)
    {
        var filme = _context.filmes.FirstOrDefault(filme => filme.Id == id);
        if (filme == null) return NotFound();
        return Ok(filme);
    }
}