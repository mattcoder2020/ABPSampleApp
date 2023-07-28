using AbpSampleApp.AccessManagment.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace AbpSampleApp.AccessManagment;

[DependsOn(
    typeof(AccessManagmentEntityFrameworkCoreTestModule)
    )]
public class AccessManagmentDomainTestModule : AbpModule
{

}
