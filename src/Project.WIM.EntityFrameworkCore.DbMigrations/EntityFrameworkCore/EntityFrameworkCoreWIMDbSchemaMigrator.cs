using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Project.WIM.Data;
using Volo.Abp.DependencyInjection;

namespace Project.WIM.EntityFrameworkCore
{
    public class EntityFrameworkCoreWIMDbSchemaMigrator
        : IWIMDbSchemaMigrator, ITransientDependency
    {
        private readonly IServiceProvider _serviceProvider;

        public EntityFrameworkCoreWIMDbSchemaMigrator(
            IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public async Task MigrateAsync()
        {
            /* We intentionally resolving the WIMMigrationsDbContext
             * from IServiceProvider (instead of directly injecting it)
             * to properly get the connection string of the current tenant in the
             * current scope.
             */

            await _serviceProvider
                .GetRequiredService<WIMMigrationsDbContext>()
                .Database
                .MigrateAsync();
        }
    }
}