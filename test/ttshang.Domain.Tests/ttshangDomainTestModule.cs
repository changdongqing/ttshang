using Volo.Abp.Modularity;

namespace ttshang;

[DependsOn(
    typeof(ttshangDomainModule),
    typeof(ttshangTestBaseModule)
)]
public class ttshangDomainTestModule : AbpModule
{

}
