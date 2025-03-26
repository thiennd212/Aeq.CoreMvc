using Volo.Abp.Modularity;

namespace Aeq.CoreMvc;

public abstract class CoreMvcApplicationTestBase<TStartupModule> : CoreMvcTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
