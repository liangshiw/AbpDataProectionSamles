using Volo.Abp.Http.Client.IdentityModel;
using Volo.Abp.Modularity;

namespace Qa.UseExistDbContext.HttpApi.Client.ConsoleTestApp
{
    [DependsOn(
        typeof(UseExistDbContextHttpApiClientModule),
        typeof(AbpHttpClientIdentityModelModule)
        )]
    public class UseExistDbContextConsoleApiClientModule : AbpModule
    {
        
    }
}
