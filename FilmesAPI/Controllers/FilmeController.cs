using FilmesAPI.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace FilmesAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class FilmeController : ControllerBase
{
    private static List<Filme> filmes = new List<Filme>();
    private static int id = 0;

    [HttpPost]
    public void AdicionarFilme([FromBody] Filme filme)
    {
        filme.Id = id++;
        filmes.Add(filme);
        Console.WriteLine("\nTitulo do Filme: " + filme.Titulo);
        Console.WriteLine("Genero do Filme: " + filme.Genero);
        Console.WriteLine("Duração do Filme: " + filme.Duracao);
    }

    [HttpGet]
    public IEnumerable<Filme> RetornaFilmes()
    {
        return filmes;
    }

    [HttpGet("{id}")]
    public Filme? RetornaFilmePorId(int id)
    {
        return filmes.FirstOrDefault(filme => filme.Id == id);
    }
}