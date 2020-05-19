using System.Threading.Tasks;

namespace Chaney.Blog.Data
{
    public interface IBlogDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
