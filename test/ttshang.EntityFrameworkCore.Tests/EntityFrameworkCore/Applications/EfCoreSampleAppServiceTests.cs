using ttshang.Samples;
using Xunit;

namespace ttshang.EntityFrameworkCore.Applications;

[Collection(ttshangTestConsts.CollectionDefinitionName)]
public class EfCoreSampleAppServiceTests : SampleAppServiceTests<ttshangEntityFrameworkCoreTestModule>
{

}
