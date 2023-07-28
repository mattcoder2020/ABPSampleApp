using AbpSampleApp.AccessManagment.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace AbpSampleApp.AccessManagment.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(AccessManagmentEntityFrameworkCoreModule),
    typeof(AccessManagmentApplicationContractsModule)
    )]
public class AccessManagmentDbMigratorModule : AbpModule
{
}
