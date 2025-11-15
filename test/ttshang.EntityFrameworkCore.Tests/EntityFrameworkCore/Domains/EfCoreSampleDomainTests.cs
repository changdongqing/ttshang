using ttshang.Samples;
using Xunit;

namespace ttshang.EntityFrameworkCore.Domains;

[Collection(ttshangTestConsts.CollectionDefinitionName)]
public class EfCoreSampleDomainTests : SampleDomainTests<ttshangEntityFrameworkCoreTestModule>
{

}
