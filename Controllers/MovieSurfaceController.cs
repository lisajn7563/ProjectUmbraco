﻿using Microsoft.AspNetCore.Mvc;
using Nackademin_Umbraco.Models;
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
    public class MovieSurfaceController : SurfaceController
    {
        private readonly IUmbracoContextAccessor _umbracoContextAccessor;

        public MovieSurfaceController(IUmbracoContextAccessor umbracoContextAccessor, IUmbracoDatabaseFactory databaseFactory, ServiceContext services, AppCaches appCaches, IProfilingLogger profilingLogger, IPublishedUrlProvider publishedUrlProvider) : base(umbracoContextAccessor, databaseFactory, services, appCaches, profilingLogger, publishedUrlProvider)
        {
            _umbracoContextAccessor = umbracoContextAccessor;
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Index(MovieDetails item)
        {
            var page = CurrentPage as Search;

            var model = new MoviePageViewModel(page, _umbracoContextAccessor);
            model.Movie = item; 

            return View("movie", model);
        }
    }
}
