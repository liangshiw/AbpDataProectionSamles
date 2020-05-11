using System;
using System.Collections.Generic;
using System.Text;
using Qa.DataProtection.Localization;
using Volo.Abp.Application.Services;

namespace Qa.DataProtection
{
    /* Inherit your application services from this class.
     */
    public abstract class DataProtectionAppService : ApplicationService
    {
        protected DataProtectionAppService()
        {
            LocalizationResource = typeof(DataProtectionResource);
        }
    }
}
