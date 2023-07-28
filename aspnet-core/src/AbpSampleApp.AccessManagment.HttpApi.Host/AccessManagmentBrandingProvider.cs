using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace AbpSampleApp.AccessManagment;

[Dependency(ReplaceServices = true)]
public class AccessManagmentBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "AccessManagment";
}
