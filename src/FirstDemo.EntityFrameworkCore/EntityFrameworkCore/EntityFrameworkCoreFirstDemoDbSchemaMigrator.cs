using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using FirstDemo.Data;
using Volo.Abp.DependencyInjection;

namespace FirstDemo.EntityFrameworkCore;

public class EntityFrameworkCoreFirstDemoDbSchemaMigrator
    : IFirstDemoDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreFirstDemoDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolve the FirstDemoDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<FirstDemoDbContext>()
            .Database
            .MigrateAsync();
    }
}
