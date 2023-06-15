using FilmesAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace FilmesAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class FilmeController : ControllerBase
{
    private static List<Filme> filmes = new List<Filme>();

    [HttpPost]
    public void AdicionarFilme([FromBody] Filme filme)
    {
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
}