using Volo.Abp.Http.Client.IdentityModel;
using Volo.Abp.Modularity;

namespace Project.WIM.HttpApi.Client.ConsoleTestApp
{
    [DependsOn(
        typeof(WIMHttpApiClientModule),
        typeof(AbpHttpClientIdentityModelModule)
        )]
    public class WIMConsoleApiClientModule : AbpModule
    {
        
    }
}
