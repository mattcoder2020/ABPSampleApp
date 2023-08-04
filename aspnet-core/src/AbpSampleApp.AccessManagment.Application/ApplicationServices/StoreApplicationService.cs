//using Abp.Application.Services.Dto;
using AbpSampleApp.AccessManagment.AggregateRoots;
using AbpSampleApp.AccessManagment.ApplicatinServices;
using AbpSampleApp.AccessManagment.Dto;
using System;
using System.Collections.Generic;
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
        private readonly IRepository<Store, Guid> _storeRepository;
        public StoreApplicationService(IRepository<Store, Guid> repository ):base(repository)
        {
            _storeRepository = repository;
        }

        //public async Task<List<Store>> QueryByFiltration(StoreQueryDTO q)
        //{
        //    //return await _storeRepository.GetListAsync(e => 
        //    //    (q.Id == null  || e.Id == q.Id)
        //    // && (q.Name.IsNullOrEmpty() || e.Name.Contains(q.Name))
        //    //  && (q.CreationDate== null || e.CreationTime.Date == q.CreationDate), false);

        //    return await _storeRepository..GetPagedListAsync(e => e.Name.Contains(q.Name));
          
        //}

        public async  Task<PagedResultDto<StoreDto>> QueryByFiltration(StoreQueryDTO q)
        {
            PagedAndSortedResultRequestDto input;
            var queryable = await base.CreateFilteredQueryAsync(input);

            // You can add additional filtering, sorting, or any other operations here if needed.

            var totalCount = await AsyncExecuter.CountAsync(queryable);
            var items = await AsyncExecuter.ToListAsync(queryable.PageBy(input));

            return new PagedResultDto<StoreDto>(totalCount, ObjectMapper.Map<List<Store>, List<StoreDto>>(items));
        }



    }
}
