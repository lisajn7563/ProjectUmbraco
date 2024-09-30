using Nackademin_Umbraco.Models;

namespace Nackademin_Umbraco.Business.Services
{
    public interface IMovieService
    {
        Task<List<MovieDetails>> GetMoviesWithDetalisAsync(string query);
    }
}
