using Volo.Abp.Http.Client.IdentityModel;
using Volo.Abp.Modularity;

namespace Qa.DataProtection.HttpApi.Client.ConsoleTestApp
{
    [DependsOn(
        typeof(DataProtectionHttpApiClientModule),
        typeof(AbpHttpClientIdentityModelModule)
        )]
    public class DataProtectionConsoleApiClientModule : AbpModule
    {
        
    }
}
