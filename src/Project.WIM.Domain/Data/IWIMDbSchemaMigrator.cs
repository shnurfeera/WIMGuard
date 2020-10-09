using System.Threading.Tasks;

namespace Project.WIM.Data
{
    public interface IWIMDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
