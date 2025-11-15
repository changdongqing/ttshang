using System.Threading.Tasks;

namespace ttshang.Data;

public interface IttshangDbSchemaMigrator
{
    Task MigrateAsync();
}
