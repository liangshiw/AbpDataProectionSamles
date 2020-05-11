using Qa.DataProtection.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Qa.DataProtection.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class DataProtectionController : AbpController
    {
        protected DataProtectionController()
        {
            LocalizationResource = typeof(DataProtectionResource);
        }
    }
}