using Volo.Abp.Modularity;

namespace ttshang;

/* Inherit from this class for your domain layer tests. */
public abstract class ttshangDomainTestBase<TStartupModule> : ttshangTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
