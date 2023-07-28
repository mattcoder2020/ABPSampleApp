using System;
using System.Collections.Generic;
using System.Text;
using AbpSampleApp.AccessManagment.Localization;
using Volo.Abp.Application.Services;

namespace AbpSampleApp.AccessManagment;

/* Inherit your application services from this class.
 */
public abstract class AccessManagmentAppService : ApplicationService
{
    protected AccessManagmentAppService()
    {
        LocalizationResource = typeof(AccessManagmentResource);
    }
}
