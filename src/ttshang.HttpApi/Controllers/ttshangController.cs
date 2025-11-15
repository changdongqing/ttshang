using ttshang.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace ttshang.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class ttshangController : AbpControllerBase
{
    protected ttshangController()
    {
        LocalizationResource = typeof(ttshangResource);
    }
}
