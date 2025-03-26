using Xunit;

namespace Aeq.CoreMvc.EntityFrameworkCore;

[CollectionDefinition(CoreMvcTestConsts.CollectionDefinitionName)]
public class CoreMvcEntityFrameworkCoreCollection : ICollectionFixture<CoreMvcEntityFrameworkCoreFixture>
{

}
