using Hangfire.Server;

namespace Nackademin_Umbraco.Business.ScheduledJods.Interface
{
    public interface IMoviesJob
    {
        void RemoveMovies(PerformContext context);
    }
}
