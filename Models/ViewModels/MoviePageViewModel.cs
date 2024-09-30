using Umbraco.Cms.Core.Web;
using Umbraco.Cms.Web.Common.PublishedModels;

namespace Nackademin_Umbraco.Models.ViewModels
{
    public class MoviePageViewModel : BasePageModel<Search>
    {
        public MoviePageViewModel(Search content, IUmbracoContextAccessor umbracoContextAccessor) : base(content, umbracoContextAccessor)
        {
        }

        public MovieDetails Movie {  get; set; }
    }
}
