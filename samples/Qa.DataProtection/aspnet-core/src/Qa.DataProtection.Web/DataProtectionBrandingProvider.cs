using Volo.Abp.AspNetCore.Mvc.UI.Theme.Shared.Components;
using Volo.Abp.DependencyInjection;

namespace Qa.DataProtection.Web
{
    [Dependency(ReplaceServices = true)]
    public class DataProtectionBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "DataProtection";
    }
}
