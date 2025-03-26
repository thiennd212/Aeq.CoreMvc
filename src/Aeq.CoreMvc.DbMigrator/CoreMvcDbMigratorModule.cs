using Aeq.CoreMvc.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace Aeq.CoreMvc.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(CoreMvcEntityFrameworkCoreModule),
    typeof(CoreMvcApplicationContractsModule)
    )]
public class CoreMvcDbMigratorModule : AbpModule
{
}
