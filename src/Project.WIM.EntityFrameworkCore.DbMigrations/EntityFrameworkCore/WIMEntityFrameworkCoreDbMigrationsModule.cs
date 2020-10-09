using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;

namespace Project.WIM.EntityFrameworkCore
{
    [DependsOn(
        typeof(WIMEntityFrameworkCoreModule)
        )]
    public class WIMEntityFrameworkCoreDbMigrationsModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<WIMMigrationsDbContext>();
        }
    }
}
