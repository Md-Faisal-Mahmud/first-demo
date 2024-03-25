using Volo.Abp.Modularity;

namespace FirstDemo;

/* Inherit from this class for your domain layer tests. */
public abstract class FirstDemoDomainTestBase<TStartupModule> : FirstDemoTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
