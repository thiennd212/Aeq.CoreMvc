using Volo.Abp.Modularity;

namespace Aeq.CoreMvc;

[DependsOn(
    typeof(CoreMvcDomainModule),
    typeof(CoreMvcTestBaseModule)
)]
public class CoreMvcDomainTestModule : AbpModule
{

}
