using Qa.UseExistDbContext.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace Qa.UseExistDbContext.Web.Pages
{
    /* Inherit your PageModel classes from this class.
     */
    public abstract class UseExistDbContextPageModel : AbpPageModel
    {
        protected UseExistDbContextPageModel()
        {
            LocalizationResourceType = typeof(UseExistDbContextResource);
        }
    }
}