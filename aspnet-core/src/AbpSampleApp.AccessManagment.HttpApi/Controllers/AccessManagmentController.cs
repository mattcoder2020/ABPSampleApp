using AbpSampleApp.AccessManagment.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace AbpSampleApp.AccessManagment.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class AccessManagmentController : AbpControllerBase
{
    protected AccessManagmentController()
    {
        LocalizationResource = typeof(AccessManagmentResource);
    }
}
