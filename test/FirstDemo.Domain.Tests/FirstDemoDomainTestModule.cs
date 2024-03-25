using Volo.Abp.Modularity;

namespace FirstDemo;

[DependsOn(
    typeof(FirstDemoDomainModule),
    typeof(FirstDemoTestBaseModule)
)]
public class FirstDemoDomainTestModule : AbpModule
{

}
