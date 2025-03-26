using Volo.Abp.Modularity;

namespace Aeq.CoreMvc;

[DependsOn(
    typeof(CoreMvcApplicationModule),
    typeof(CoreMvcDomainTestModule)
)]
public class CoreMvcApplicationTestModule : AbpModule
{

}
