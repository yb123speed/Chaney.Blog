using Microsoft.AspNetCore.Mvc.Localization;
using Microsoft.AspNetCore.Mvc.Razor.Internal;
using Chaney.Blog.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace Chaney.Blog.HttpApi.Hosting.Pages
{
    /* Inherit your UI Pages from this class. To do that, add this line to your Pages (.cshtml files under the Page folder):
     * @inherits Chaney.Blog.HttpApi.Hosting.Pages.BlogPage
     */
    public abstract class BlogPage : AbpPage
    {
        [RazorInject]
        public IHtmlLocalizer<BlogResource> L { get; set; }
    }
}
