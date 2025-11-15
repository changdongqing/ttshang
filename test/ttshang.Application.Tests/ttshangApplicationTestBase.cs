using Volo.Abp.Modularity;

namespace ttshang;

public abstract class ttshangApplicationTestBase<TStartupModule> : ttshangTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
