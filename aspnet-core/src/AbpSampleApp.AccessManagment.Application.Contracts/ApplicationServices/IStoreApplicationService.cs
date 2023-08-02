using AbpSampleApp.AccessManagment.Dto;
using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace AbpSampleApp.AccessManagment.ApplicatinServices
{
    public interface IStoreApplicationService : ICrudAppService<StoreDto, Guid, PagedAndSortedResultRequestDto, CreateStoreDto>  
    {
    }
}
