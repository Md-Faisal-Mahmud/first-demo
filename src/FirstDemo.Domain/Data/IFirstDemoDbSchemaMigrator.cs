using System.Threading.Tasks;

namespace FirstDemo.Data;

public interface IFirstDemoDbSchemaMigrator
{
    Task MigrateAsync();
}
