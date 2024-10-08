﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewEngines;
using Nackademin_Umbraco.Models.ViewModels;
using Umbraco.Cms.Core.Web;
using Umbraco.Cms.Web.Common.Controllers;
using Umbraco.Cms.Web.Common.PublishedModels;

namespace Nackademin_Umbraco.Controllers
{
    public class ErrorController : RenderController
    {
        private readonly IUmbracoContextAccessor _umbracoContextAccessor;
        public ErrorController(ILogger<RenderController> logger, ICompositeViewEngine compositeViewEngine, IUmbracoContextAccessor umbracoContextAccessor) : base(logger, compositeViewEngine, umbracoContextAccessor)
        {
            _umbracoContextAccessor = umbracoContextAccessor;
        }

        public override IActionResult Index()
        {
            var errorPage = CurrentPage as Error;

            if (errorPage != null)
            {
                var model = new ErrorPageViewModel(errorPage, _umbracoContextAccessor);

                return View("error", model);
            }
            return null;
        }
    }
}
