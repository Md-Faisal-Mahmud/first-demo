using FirstDemo.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace FirstDemo.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(FirstDemoEntityFrameworkCoreModule),
    typeof(FirstDemoApplicationContractsModule)
    )]
public class FirstDemoDbMigratorModule : AbpModule
{
}
