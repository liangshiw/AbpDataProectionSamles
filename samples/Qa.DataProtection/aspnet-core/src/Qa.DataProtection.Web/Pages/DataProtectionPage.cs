using Microsoft.AspNetCore.Mvc.Localization;
using Microsoft.AspNetCore.Mvc.Razor.Internal;
using Qa.DataProtection.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace Qa.DataProtection.Web.Pages
{
    /* Inherit your UI Pages from this class. To do that, add this line to your Pages (.cshtml files under the Page folder):
     * @inherits Qa.DataProtection.Web.Pages.DataProtectionPage
     */
    public abstract class DataProtectionPage : AbpPage
    {
        [RazorInject]
        public IHtmlLocalizer<DataProtectionResource> L { get; set; }
    }
}
