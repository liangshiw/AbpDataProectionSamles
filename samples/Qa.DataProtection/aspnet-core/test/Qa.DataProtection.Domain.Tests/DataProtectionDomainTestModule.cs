using Qa.DataProtection.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Qa.DataProtection
{
    [DependsOn(
        typeof(DataProtectionEntityFrameworkCoreTestModule)
        )]
    public class DataProtectionDomainTestModule : AbpModule
    {

    }
}