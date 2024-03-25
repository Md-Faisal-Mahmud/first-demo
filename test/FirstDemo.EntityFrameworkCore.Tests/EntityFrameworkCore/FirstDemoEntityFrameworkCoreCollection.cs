using Xunit;

namespace FirstDemo.EntityFrameworkCore;

[CollectionDefinition(FirstDemoTestConsts.CollectionDefinitionName)]
public class FirstDemoEntityFrameworkCoreCollection : ICollectionFixture<FirstDemoEntityFrameworkCoreFixture>
{

}
