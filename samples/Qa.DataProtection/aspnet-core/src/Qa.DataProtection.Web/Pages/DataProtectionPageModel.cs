using Qa.DataProtection.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace Qa.DataProtection.Web.Pages
{
    /* Inherit your PageModel classes from this class.
     */
    public abstract class DataProtectionPageModel : AbpPageModel
    {
        protected DataProtectionPageModel()
        {
            LocalizationResourceType = typeof(DataProtectionResource);
        }
    }
}