using Nackademin_Umbraco.Business.ScheduledJods.Interface;
using Nackademin_Umbraco.Business.ScheduledJods;
using Nackademin_Umbraco.Business.Services;

WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

builder.CreateUmbracoBuilder()
    .AddBackOffice()
    .AddWebsite()
    .AddDeliveryApi()
    .AddComposers()
    .Build();

builder.Services.AddScoped<IMovieService, MovieService>();
builder.Services.AddScoped<IMoviesJob, MoviesJob>();


WebApplication app = builder.Build();

await app.BootUmbracoAsync();

app.UseUmbraco()
    .WithMiddleware(u =>
    {
        u.UseBackOffice();
        u.UseWebsite();
    })
    .WithEndpoints(u =>
    {
        u.UseBackOfficeEndpoints();
        u.UseWebsiteEndpoints();
    });

await app.RunAsync();
