//using Abp.Application.Services.Dto;
using AbpSampleApp.AccessManagment.AggregateRoots;
using AbpSampleApp.AccessManagment.ApplicatinServices;
using AbpSampleApp.AccessManagment.Dto;
using System;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace AbpSampleApp.AccessManagment.ApplicationServices
{
    public class StoreApplicationService:CrudAppService<
        Store,
        StoreDto,
        Guid,
        PagedAndSortedResultRequestDto,
        CreateStoreDto
        >, 
        IStoreApplicationService
    {
        public StoreApplicationService(IRepository<Store, Guid> repository ):base(repository)
        {
            
        }

       
    }
}
