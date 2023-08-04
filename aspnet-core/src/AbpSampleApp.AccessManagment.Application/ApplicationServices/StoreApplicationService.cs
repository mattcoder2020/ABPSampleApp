//using Abp.Application.Services.Dto;
using Abp.Linq.Extensions;
using AbpSampleApp.AccessManagment.AggregateRoots;
using AbpSampleApp.AccessManagment.ApplicatinServices;
using AbpSampleApp.AccessManagment.Dto;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;
using Volo.Abp.Linq;

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
        public async Task<PagedResultDto<StoreDto>> QueryByFiltration(StoreQueryDTO q)
        {
            var query = await _storeRepository.GetQueryableAsync();
            query = query.Where(e => (q.Id == null || e.Id == q.Id)
            && (q.Name.IsNullOrEmpty() || e.Name.Contains(q.Name))
            && (q.CreationDate == null || e.CreationTime.Date == q.CreationDate));

            //if (q.Id.HasValue)
            //{
            //    query = query.Where(store => store.Id == q.Id.Value);
            //}

            //if (!string.IsNullOrEmpty(q.Name))
            //{
            //    query = query.Where(store => store.Name.Contains(q.Name));
            //}

            //if (q.CreationDate.HasValue)
            //{
            //    query = query.Where(store => store.CreationTime == q.CreationDate.Value);
            //}

            var totalCount = await query.CountAsync();

            //var filteredQuery = ApplySorting(query, q);

            var items = await query.ToListAsync();

            var dtos = ObjectMapper.Map<List<Store>, List<StoreDto>>(items);

            return new PagedResultDto<StoreDto>(totalCount, dtos);
            
        }
        //public async Task<PagedResultDto<Store>> QueryByFiltration(StoreQueryDTO q)
        //{
        //    //how to query and return pageinated entities 

        //    return await base.GetListAsync()
        //    //return await _storeRepository.GetListAsync(e =>
        //    //    (q.Id == null || e.Id == q.Id)
        //    // && (q.Name.IsNullOrEmpty() || e.Name.Contains(q.Name))
        //    //  && (q.CreationDate == null || e.CreationTime.Date == q.CreationDate), false);
        //    base.del
        //    var pagedRequestDto = new PagedAndSortedResultRequestDto();
        //    pagedRequestDto = pagedRequestDto..WhereIf<StoreQueryDTO, bool>(true, (e =>
        //        (q.Id == null || e.Id == q.Id)
        //     && (q.Name.IsNullOrEmpty() || e.Name.Contains(q.Name))
        //      && (q.CreationDate == null || e.CreationTime.Date == q.CreationDate)));


        //    base.GetListAsync()
        //    return await _storeRepository..GetPagedListAsync(e => e.Name.Contains(q.Name));

        //}

        //public async  Task<PagedResultDto<StoreDto>> QueryByFiltration(StoreQueryDTO q)
        //{
        //    PagedAndSortedResultRequestDto input;
        //    var queryable = await base.CreateFilteredQueryAsync(input);

        //    // You can add additional filtering, sorting, or any other operations here if needed.

        //    var totalCount = await AsyncExecuter.CountAsync(queryable);
        //    var items = await AsyncExecuter.ToListAsync(queryable.PageBy(input));

        //    return new PagedResultDto<StoreDto>(totalCount, ObjectMapper.Map<List<Store>, List<StoreDto>>(items));
        //}



    }
}
