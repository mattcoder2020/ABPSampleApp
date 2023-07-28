using Volo.Abp.Modularity;

namespace AbpSampleApp.AccessManagment;

[DependsOn(
    typeof(AccessManagmentApplicationModule),
    typeof(AccessManagmentDomainTestModule)
    )]
public class AccessManagmentApplicationTestModule : AbpModule
{

}
