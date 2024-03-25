using Volo.Abp.Modularity;

namespace FirstDemo;

[DependsOn(
    typeof(FirstDemoApplicationModule),
    typeof(FirstDemoDomainTestModule)
)]
public class FirstDemoApplicationTestModule : AbpModule
{

}
