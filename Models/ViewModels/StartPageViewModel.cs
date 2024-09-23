using Umbraco.Cms.Core.Web;
using Umbraco.Cms.Web.Common.PublishedModels;

namespace Nackademin_Umbraco.Models.ViewModels
{
    public class StartPageViewModel : BasePageModel<Start>
    {
        public StartPageViewModel(Start content, IUmbracoContextAccessor umbracoContextAccessor) : base(content, umbracoContextAccessor)
        {
        }
    }
}
