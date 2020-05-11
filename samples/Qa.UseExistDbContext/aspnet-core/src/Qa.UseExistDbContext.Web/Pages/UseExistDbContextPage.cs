using Microsoft.AspNetCore.Mvc.Localization;
using Microsoft.AspNetCore.Mvc.Razor.Internal;
using Qa.UseExistDbContext.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace Qa.UseExistDbContext.Web.Pages
{
    /* Inherit your UI Pages from this class. To do that, add this line to your Pages (.cshtml files under the Page folder):
     * @inherits Qa.UseExistDbContext.Web.Pages.UseExistDbContextPage
     */
    public abstract class UseExistDbContextPage : AbpPage
    {
        [RazorInject]
        public IHtmlLocalizer<UseExistDbContextResource> L { get; set; }
    }
}
