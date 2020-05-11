using Volo.Abp.AspNetCore.Mvc.UI.Theme.Shared.Components;
using Volo.Abp.DependencyInjection;

namespace Qa.UseExistDbContext.Web
{
    [Dependency(ReplaceServices = true)]
    public class UseExistDbContextBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "UseExistDbContext";
    }
}
