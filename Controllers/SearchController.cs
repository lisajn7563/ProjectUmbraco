﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewEngines;
using Nackademin_Umbraco.Models.ViewModels;
using Umbraco.Cms.Core.Web;
using Umbraco.Cms.Web.Common.Controllers;
using Umbraco.Cms.Web.Common.PublishedModels;

namespace Nackademin_Umbraco.Controllers
{
    public class SearchController : RenderController
    {
        private readonly IUmbracoContextAccessor _umbracoContextAccessor;

        public SearchController(ILogger<RenderController> logger, ICompositeViewEngine compositeViewEngine, IUmbracoContextAccessor umbracoContextAccessor) : base(logger, compositeViewEngine, umbracoContextAccessor)
        {
            _umbracoContextAccessor = umbracoContextAccessor;
        }

        public override IActionResult Index()
        {
            var searchPage = CurrentPage as Search;

            if (searchPage != null)
            {
                var model = new SearchPageViewModel(searchPage, _umbracoContextAccessor);

                return View("search", model);
            }

            return null;
        }
    }
}
