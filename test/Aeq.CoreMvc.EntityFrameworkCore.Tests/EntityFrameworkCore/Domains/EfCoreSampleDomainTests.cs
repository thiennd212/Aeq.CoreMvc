using Aeq.CoreMvc.Samples;
using Xunit;

namespace Aeq.CoreMvc.EntityFrameworkCore.Domains;

[Collection(CoreMvcTestConsts.CollectionDefinitionName)]
public class EfCoreSampleDomainTests : SampleDomainTests<CoreMvcEntityFrameworkCoreTestModule>
{

}
