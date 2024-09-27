using Umbraco.Cms.Core.Models.PublishedContent;

namespace Nackademin_Umbraco.Interfaces
{
    public interface IPageModel : IPublishedContent
    {
        IPublishedContent Content { get; }
    }
}
