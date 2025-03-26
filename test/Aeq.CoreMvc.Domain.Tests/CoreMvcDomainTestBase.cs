using Volo.Abp.Modularity;

namespace Aeq.CoreMvc;

/* Inherit from this class for your domain layer tests. */
public abstract class CoreMvcDomainTestBase<TStartupModule> : CoreMvcTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
