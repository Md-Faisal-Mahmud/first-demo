using FirstDemo.Samples;
using Xunit;

namespace FirstDemo.EntityFrameworkCore.Applications;

[Collection(FirstDemoTestConsts.CollectionDefinitionName)]
public class EfCoreSampleAppServiceTests : SampleAppServiceTests<FirstDemoEntityFrameworkCoreTestModule>
{

}
