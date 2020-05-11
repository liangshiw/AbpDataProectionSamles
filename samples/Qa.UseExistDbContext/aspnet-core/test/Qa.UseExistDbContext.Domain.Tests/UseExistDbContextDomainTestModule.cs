using Qa.UseExistDbContext.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Qa.UseExistDbContext
{
    [DependsOn(
        typeof(UseExistDbContextEntityFrameworkCoreTestModule)
        )]
    public class UseExistDbContextDomainTestModule : AbpModule
    {

    }
}