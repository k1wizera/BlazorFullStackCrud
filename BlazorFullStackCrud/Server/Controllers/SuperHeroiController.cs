using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlazorFullStackCrud.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SuperHeroiController : ControllerBase
    {
        public static List<Quadrinho> quadrinhos = new List<Quadrinho> {
        new Quadrinho {Id = 1, Nome="Marvel"},
        new Quadrinho {Id = 2, Nome = "Dc"}
        };

        public static List<SuperHeroi> herois = new List<SuperHeroi>
        {
            new SuperHeroi
            {
                Id = 1,
                PrimeiroNome = "Peter",
                UltimoNome = "Parker",
                NomeDeHeroi = "Homem-Aranha",
                Quadrinho = quadrinhos[0]
            },
             new SuperHeroi
            {
                Id = 2,
                PrimeiroNome = "Bruce",
                UltimoNome = "Wayne",
                NomeDeHeroi = "Batman",
                Quadrinho = quadrinhos[1]
            }
        };
        [HttpGet]
        public async Task<ActionResult<List<SuperHeroi>>> ListarSuperHerois()
        {
            return Ok(herois);
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<ActionResult<SuperHeroi>> ListarUmSuperHeroi(int id)
        {
            var heroi = herois.FirstOrDefault(h => h.Id == id);
            if (heroi == null)
            {
                return NotFound("Desculpe, nenhum herói por aqui. :(");
            }
            return Ok(heroi);
        }
    }
}
