using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace Aeq.CoreMvc.Data;

/* This is used if database provider does't define
 * ICoreMvcDbSchemaMigrator implementation.
 */
public class NullCoreMvcDbSchemaMigrator : ICoreMvcDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
