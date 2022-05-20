using System.Net.Http.Json;

namespace BlazorFullStackCrud.Client.Services.SuperHeroiService
{
    public class SuperHeroiService : ISuperHeroiService
    {
        private readonly HttpClient _http;
        public SuperHeroiService(HttpClient http)
        {
            _http = http;
        }
        public List<SuperHeroi> Herois { get; set; } = new List<SuperHeroi>();
        public List<Quadrinho> Quadrinhos { get; set; } = new List<Quadrinho>();

        public Task GetQuadrinhos()
        {
            throw new NotImplementedException();
        }

        public async Task<SuperHeroi> GetUmSuperHeroi(int id)
        {
            var result = await _http.GetFromJsonAsync<SuperHeroi>($"api/superheroi/{id}");
            if (result != null)
                return result;
            throw new Exception("Herói não encontrado!");
        }

        public async Task GetSuperHerois()
        {
            var result = await _http.GetFromJsonAsync<List<SuperHeroi>>("api/superheroi");
            if (result != null)
                Herois = result;
        }
    }
}
