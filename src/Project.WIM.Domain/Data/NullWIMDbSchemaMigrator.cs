using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace Project.WIM.Data
{
    /* This is used if database provider does't define
     * IWIMDbSchemaMigrator implementation.
     */
    public class NullWIMDbSchemaMigrator : IWIMDbSchemaMigrator, ITransientDependency
    {
        public Task MigrateAsync()
        {
            return Task.CompletedTask;
        }
    }
}