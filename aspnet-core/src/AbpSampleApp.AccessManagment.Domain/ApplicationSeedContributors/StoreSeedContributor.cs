using AbpSampleApp.AccessManagment.AggregateRoots;
using AbpSampleApp.AccessManagment.Enums;
using System;
using System.Threading.Tasks;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Repositories;

namespace AbpSampleApp.AccessManagment.ApplicationSeedContributors
{
    public class StoreSeedContributor : IDataSeedContributor, ITransientDependency
    {
        private readonly IRepository<Store, Guid> _storeRepository;

        public StoreSeedContributor(IRepository<Store, Guid> storeRepository)
        {
            _storeRepository = storeRepository;
        }

        public async Task SeedAsync(DataSeedContext context)
        {
            //Check if the Store table is already populated
            if (await _storeRepository.GetCountAsync() > 0)
            {
                return; // Data already seeded
            }

            // Seed initial data for the Store aggregate root
            var stores = new[]
            {
            new Store
            {
                Name = "McDonald",
                FullName = "麦当劳",
                Address = "123 Main St",
                Phone = "555-1234",
                Status = StoreStatus.Opening
            },
            new Store
            {
                Name = "Kentucky",
                FullName = "肯德基",
                Address = "456 Elm St",
                Phone = "555-5678",
                Status = StoreStatus.Closed
            }
            // Add more store entries if needed
        };

            await _storeRepository.InsertManyAsync(stores, autoSave: true);
        }
    }

}
