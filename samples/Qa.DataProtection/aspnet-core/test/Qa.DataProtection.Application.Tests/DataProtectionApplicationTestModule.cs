using Volo.Abp.Modularity;

namespace Qa.DataProtection
{
    [DependsOn(
        typeof(DataProtectionApplicationModule),
        typeof(DataProtectionDomainTestModule)
        )]
    public class DataProtectionApplicationTestModule : AbpModule
    {

    }
}