using ttshang.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace ttshang.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(ttshangEntityFrameworkCoreModule),
    typeof(ttshangApplicationContractsModule)
)]
public class ttshangDbMigratorModule : AbpModule
{
}
