using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace ttshang.Data;

/* This is used if database provider does't define
 * IttshangDbSchemaMigrator implementation.
 */
public class NullttshangDbSchemaMigrator : IttshangDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
