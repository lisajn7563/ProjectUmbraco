using Hangfire.Console;
using Hangfire.Server;
using Nackademin_Umbraco.Business.ScheduledJods.Interface;

namespace Nackademin_Umbraco.Business.ScheduledJods
{
    public class MoviesJob : IMoviesJob
    {
        public void RemoveMovies(PerformContext context)
        {
            var progressBar = context.WriteProgressBar();

            var movies = new List<MyMovie>();

            for (int i = 0; i <= 10000; i++)
            {
                var movie = new MyMovie
                {
                    Name = i.ToString()
                };

                movies.Add(movie);
            }

            foreach (var item in movies.WithProgress(progressBar, movies.Count()))
            {
                context.WriteLine($"Movie {item.Name} added");
            }
        }

        private class MyMovie
        {
            public string Name { get; set; }
        }
    }

}
