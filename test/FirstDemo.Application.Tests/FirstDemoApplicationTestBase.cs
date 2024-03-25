using Volo.Abp.Modularity;

namespace FirstDemo;

public abstract class FirstDemoApplicationTestBase<TStartupModule> : FirstDemoTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
