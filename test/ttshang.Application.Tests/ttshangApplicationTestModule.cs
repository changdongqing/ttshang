using Volo.Abp.Modularity;

namespace ttshang;

[DependsOn(
    typeof(ttshangApplicationModule),
    typeof(ttshangDomainTestModule)
)]
public class ttshangApplicationTestModule : AbpModule
{

}
