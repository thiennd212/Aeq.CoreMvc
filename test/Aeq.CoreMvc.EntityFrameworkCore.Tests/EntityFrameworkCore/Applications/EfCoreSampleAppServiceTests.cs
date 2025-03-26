using Aeq.CoreMvc.Samples;
using Xunit;

namespace Aeq.CoreMvc.EntityFrameworkCore.Applications;

[Collection(CoreMvcTestConsts.CollectionDefinitionName)]
public class EfCoreSampleAppServiceTests : SampleAppServiceTests<CoreMvcEntityFrameworkCoreTestModule>
{

}
