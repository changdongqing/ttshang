using Xunit;

namespace ttshang.EntityFrameworkCore;

[CollectionDefinition(ttshangTestConsts.CollectionDefinitionName)]
public class ttshangEntityFrameworkCoreCollection : ICollectionFixture<ttshangEntityFrameworkCoreFixture>
{

}
