using ttshang.Localization;
using Volo.Abp.Application.Services;

namespace ttshang;

/* Inherit your application services from this class.
 */
public abstract class ttshangAppService : ApplicationService
{
    protected ttshangAppService()
    {
        LocalizationResource = typeof(ttshangResource);
    }
}
