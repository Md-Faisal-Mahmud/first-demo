using System;
using System.Collections.Generic;
using System.Text;
using FirstDemo.Localization;
using Volo.Abp.Application.Services;

namespace FirstDemo;

/* Inherit your application services from this class.
 */
public abstract class FirstDemoAppService : ApplicationService
{
    protected FirstDemoAppService()
    {
        LocalizationResource = typeof(FirstDemoResource);
    }
}
