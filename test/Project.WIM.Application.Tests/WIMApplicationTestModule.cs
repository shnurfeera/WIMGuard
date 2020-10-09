using Volo.Abp.Modularity;

namespace Project.WIM
{
    [DependsOn(
        typeof(WIMApplicationModule),
        typeof(WIMDomainTestModule)
        )]
    public class WIMApplicationTestModule : AbpModule
    {

    }
}