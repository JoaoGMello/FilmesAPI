using FilmesAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace FilmesAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FilmeController : ControllerBase
    {
        private static List<Filme> filmes = new List<Filme>();
        private static int Id = 0;

        [HttpPost]
        public void AdicionarFilme([FromBody] Filme filme)
        {
            filme.Id = Id++;
            filmes.Add(filme);
            Console.WriteLine(filme.Titulo);
            Console.WriteLine(filme.Duracao);
        }

        [HttpGet]
        public IEnumerable<Filme> GetFilmes()
        {
            return filmes;
        }

        [HttpGet("{id}")]
        public Filme? GetFilmeByYd(int id)
        {
            return filmes.FirstOrDefault(filme => filme.Id == id);
        }
    }
}
