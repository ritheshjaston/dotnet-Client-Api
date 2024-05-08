using System.Threading.Tasks;

namespace Rithesh.BookStore.Data;

public interface IBookStoreDbSchemaMigrator
{
    Task MigrateAsync();
}
