﻿using Microsoft.AspNetCore.Mvc;
using Nackademin_Umbraco.Business.Services;
using Nackademin_Umbraco.Models.ViewModels;
using Umbraco.Cms.Core.Cache;
using Umbraco.Cms.Core.Logging;
using Umbraco.Cms.Core.Routing;
using Umbraco.Cms.Core.Services;
using Umbraco.Cms.Core.Web;
using Umbraco.Cms.Infrastructure.Persistence;
using Umbraco.Cms.Web.Common.PublishedModels;
using Umbraco.Cms.Web.Website.Controllers;

namespace Nackademin_Umbraco.Controllers
{
    public class SearchSurfaceController : SurfaceController
    {
        private readonly IMovieService _movieService;
        private readonly IUmbracoContextAccessor _umbracoContextAccessor;

        public SearchSurfaceController(IMovieService movieService, IUmbracoContextAccessor umbracoContextAccessor, IUmbracoDatabaseFactory databaseFactory, ServiceContext services, AppCaches appCaches, IProfilingLogger profilingLogger, IPublishedUrlProvider publishedUrlProvider) : base(umbracoContextAccessor, databaseFactory, services, appCaches, profilingLogger, publishedUrlProvider)
        {
            _movieService = movieService;
            _umbracoContextAccessor = umbracoContextAccessor;
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> SearchMovie(string query)
        {
            var searchPage = CurrentPage as Search;

            var model = new SearchPageViewModel(searchPage, _umbracoContextAccessor)
            {
                Movies = await _movieService.GetMoviesWithDetalisAsync(query),
            };
            return View("search", model);
        }
    }
}
