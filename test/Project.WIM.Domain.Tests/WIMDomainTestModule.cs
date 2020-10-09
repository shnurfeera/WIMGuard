using Project.WIM.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Project.WIM
{
    [DependsOn(
        typeof(WIMEntityFrameworkCoreTestModule)
        )]
    public class WIMDomainTestModule : AbpModule
    {

    }
}