using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Aeq.CoreMvc.Data;
using Volo.Abp.DependencyInjection;

namespace Aeq.CoreMvc.EntityFrameworkCore;

public class EntityFrameworkCoreCoreMvcDbSchemaMigrator
    : ICoreMvcDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreCoreMvcDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolve the CoreMvcDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<CoreMvcDbContext>()
            .Database
            .MigrateAsync();
    }
}
