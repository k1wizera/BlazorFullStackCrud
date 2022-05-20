namespace BlazorFullStackCrud.Client.Services.SuperHeroiService
{
    public interface ISuperHeroiService
    {
        List<SuperHeroi> Herois { get; set; }
        List<Quadrinho> Quadrinhos { get; set; }
        Task GetQuadrinhos();
        Task GetSuperHerois();
        Task<SuperHeroi> GetUmSuperHeroi(int  id);
    }
}
