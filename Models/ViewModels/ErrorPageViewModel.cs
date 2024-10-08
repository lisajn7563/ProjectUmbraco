﻿using Umbraco.Cms.Core.Web;
using Umbraco.Cms.Web.Common.PublishedModels;

namespace Nackademin_Umbraco.Models.ViewModels
{
    public class ErrorPageViewModel : BasePageModel<Error>
    {
        public ErrorPageViewModel(Error content, IUmbracoContextAccessor umbracoContextAccessor) : base(content, umbracoContextAccessor)
        {
        }
    }
}
