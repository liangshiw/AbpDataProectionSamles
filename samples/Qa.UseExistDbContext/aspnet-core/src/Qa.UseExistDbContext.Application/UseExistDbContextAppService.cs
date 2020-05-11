using System;
using System.Collections.Generic;
using System.Text;
using Qa.UseExistDbContext.Localization;
using Volo.Abp.Application.Services;

namespace Qa.UseExistDbContext
{
    /* Inherit your application services from this class.
     */
    public abstract class UseExistDbContextAppService : ApplicationService
    {
        protected UseExistDbContextAppService()
        {
            LocalizationResource = typeof(UseExistDbContextResource);
        }
    }
}
