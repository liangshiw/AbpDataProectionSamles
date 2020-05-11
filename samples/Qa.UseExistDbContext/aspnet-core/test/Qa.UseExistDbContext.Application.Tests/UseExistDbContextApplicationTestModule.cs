using Volo.Abp.Modularity;

namespace Qa.UseExistDbContext
{
    [DependsOn(
        typeof(UseExistDbContextApplicationModule),
        typeof(UseExistDbContextDomainTestModule)
        )]
    public class UseExistDbContextApplicationTestModule : AbpModule
    {

    }
}