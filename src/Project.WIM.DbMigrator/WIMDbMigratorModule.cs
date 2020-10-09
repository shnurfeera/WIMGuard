using Project.WIM.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace Project.WIM.DbMigrator
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(WIMEntityFrameworkCoreDbMigrationsModule),
        typeof(WIMApplicationContractsModule)
        )]
    public class WIMDbMigratorModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
        }
    }
}
