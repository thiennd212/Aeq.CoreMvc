using System.Threading.Tasks;

namespace Aeq.CoreMvc.Data;

public interface ICoreMvcDbSchemaMigrator
{
    Task MigrateAsync();
}
