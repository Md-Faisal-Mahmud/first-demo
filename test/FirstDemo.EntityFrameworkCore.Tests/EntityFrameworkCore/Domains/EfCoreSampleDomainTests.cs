using FirstDemo.Samples;
using Xunit;

namespace FirstDemo.EntityFrameworkCore.Domains;

[Collection(FirstDemoTestConsts.CollectionDefinitionName)]
public class EfCoreSampleDomainTests : SampleDomainTests<FirstDemoEntityFrameworkCoreTestModule>
{

}
