using AbpSampleApp.AccessManagment.ExtendedService;
using Castle.MicroKernel.Registration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Volo.Abp.Account;
using Volo.Abp.AutoMapper;
using Volo.Abp.FeatureManagement;
using Volo.Abp.Identity;
using Volo.Abp.Modularity;
using Volo.Abp.PermissionManagement;
using Volo.Abp.SettingManagement;
using Volo.Abp.TenantManagement;

namespace AbpSampleApp.AccessManagment;

[DependsOn(
    typeof(AccessManagmentDomainModule),
    typeof(AbpAccountApplicationModule),
    typeof(AccessManagmentApplicationContractsModule),
    typeof(AbpIdentityApplicationModule),
    typeof(AbpPermissionManagementApplicationModule),
    typeof(AbpTenantManagementApplicationModule),
    typeof(AbpFeatureManagementApplicationModule),
    typeof(AbpSettingManagementApplicationModule)
    )]
public class AccessManagmentApplicationModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpAutoMapperOptions>(options =>
        {
            options.AddMaps<AccessManagmentApplicationModule>();
        });
        //context.Services.AddDefaultRepository(typeof(Volo.Abp.Identity.IdentityUser), typeof(MyEfCoreIdentityUserRepository),
        //replaceExisting: true);

    }
}
