using FirstDemo.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace FirstDemo.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class FirstDemoController : AbpControllerBase
{
    protected FirstDemoController()
    {
        LocalizationResource = typeof(FirstDemoResource);
    }
}
