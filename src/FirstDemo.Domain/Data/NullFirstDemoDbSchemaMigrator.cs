using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace FirstDemo.Data;

/* This is used if database provider does't define
 * IFirstDemoDbSchemaMigrator implementation.
 */
public class NullFirstDemoDbSchemaMigrator : IFirstDemoDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
