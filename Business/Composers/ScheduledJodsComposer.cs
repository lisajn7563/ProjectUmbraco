using Hangfire;
using Nackademin_Umbraco.Business.ScheduledJods.Interface;
using Umbraco.Cms.Core.Composing;

namespace Nackademin_Umbraco.Business.Composers
{
    public class ScheduledJodsComposer : IComposer
    {
        public void Compose(IUmbracoBuilder builder)
        {
            RecurringJob.AddOrUpdate<IMoviesJob>(
              "Remove movies",
              x => x.RemoveMovies(null),
              Cron.Never);
        }
    }
}
