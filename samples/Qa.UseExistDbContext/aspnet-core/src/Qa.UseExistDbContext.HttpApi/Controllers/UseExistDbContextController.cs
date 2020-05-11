using Qa.UseExistDbContext.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Qa.UseExistDbContext.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class UseExistDbContextController : AbpController
    {
        protected UseExistDbContextController()
        {
            LocalizationResource = typeof(UseExistDbContextResource);
        }
    }
}