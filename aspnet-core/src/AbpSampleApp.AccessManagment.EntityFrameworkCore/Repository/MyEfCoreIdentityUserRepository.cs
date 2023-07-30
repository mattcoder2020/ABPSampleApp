using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.Identity;
using Volo.Abp.Identity.EntityFrameworkCore;

namespace AbpSampleApp.AccessManagment.EntityFrameworkCore.Repository
{
    [ExposeServices(typeof(IMyIdentityUserRepository), IncludeDefaults = true)]
    public class MyEfCoreIdentityUserRepository
    : EfCoreIdentityUserRepository, IMyIdentityUserRepository
    {
        public MyEfCoreIdentityUserRepository(
            IDbContextProvider<IIdentityDbContext> dbContextProvider)
            : base(dbContextProvider)
        {
        }

        public Task DeleteAsync(Guid id, bool autoSave = false, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(IdentityUser entity, bool autoSave = false, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public async Task DeleteByEmailAddress(string email)
        {
            //var dbContext = await GetDbContextAsync();
            //var user = await dbContext.Users.FirstOrDefaultAsync(u => u.Email == email);
            //if (user != null)
            //{
            //    dbContext.Users.Remove(user);
            //}
        }

        public Task DeleteManyAsync(IEnumerable<Guid> ids, bool autoSave = false, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task DeleteManyAsync(IEnumerable<IdentityUser> entities, bool autoSave = false, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<IdentityUser> FindAsync(Guid id, bool includeDetails = true, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<List<IdentityUser>> FindByCreationDateRange(string email)
        {
            throw new NotImplementedException();
        }

        public Task<IdentityUser> FindByLoginAsync(string loginProvider, string providerKey, bool includeDetails = true, CancellationToken cancellationToken = default)
        {
            base.FindByLoginAsync(loginProvider, providerKey, includeDetails, cancellationToken);   

            throw new NotImplementedException();
        }

        public Task<IdentityUser> FindByNormalizedEmailAsync(string normalizedEmail, bool includeDetails = true, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<IdentityUser> FindByNormalizedUserNameAsync(string normalizedUserName, bool includeDetails = true, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<IdentityUser> FindByTenantIdAndUserNameAsync(string userName, Guid? tenantId, bool includeDetails = true, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<IdentityUser> GetAsync(Guid id, bool includeDetails = true, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<long> GetCountAsync(string filter = null, Guid? roleId = null, Guid? organizationUnitId = null, string userName = null, string phoneNumber = null, string emailAddress = null, string name = null, string surname = null, bool? isLockedOut = null, bool? notActive = null, bool? emailConfirmed = null, bool? isExternal = null, DateTime? maxCreationTime = null, DateTime? minCreationTime = null, DateTime? maxModifitionTime = null, DateTime? minModifitionTime = null, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<long> GetCountAsync(CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<List<IdentityUser>> GetListAsync(string sorting = null, int maxResultCount = int.MaxValue, int skipCount = 0, string filter = null, bool includeDetails = false, Guid? roleId = null, Guid? organizationUnitId = null, string userName = null, string phoneNumber = null, string emailAddress = null, string name = null, string surname = null, bool? isLockedOut = null, bool? notActive = null, bool? emailConfirmed = null, bool? isExternal = null, DateTime? maxCreationTime = null, DateTime? minCreationTime = null, DateTime? maxModifitionTime = null, DateTime? minModifitionTime = null, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<List<IdentityUser>> GetListAsync(bool includeDetails = false, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<List<IdentityUser>> GetListByClaimAsync(Claim claim, bool includeDetails = false, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<List<IdentityUser>> GetListByIdsAsync(IEnumerable<Guid> ids, bool includeDetails = false, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<List<IdentityUser>> GetListByNormalizedRoleNameAsync(string normalizedRoleName, bool includeDetails = false, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<List<OrganizationUnit>> GetOrganizationUnitsAsync(Guid id, bool includeDetails = false, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<List<IdentityUser>> GetPagedListAsync(int skipCount, int maxResultCount, string sorting, bool includeDetails = false, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<List<string>> GetRoleNamesAsync(Guid id, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<List<string>> GetRoleNamesInOrganizationUnitAsync(Guid id, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<List<IdentityRole>> GetRolesAsync(Guid id, bool includeDetails = false, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<List<IdentityUser>> GetUsersInOrganizationsListAsync(List<Guid> organizationUnitIds, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<List<IdentityUser>> GetUsersInOrganizationUnitAsync(Guid organizationUnitId, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<List<IdentityUser>> GetUsersInOrganizationUnitWithChildrenAsync(string code, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<IdentityUser> InsertAsync(IdentityUser entity, bool autoSave = false, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task InsertManyAsync(IEnumerable<IdentityUser> entities, bool autoSave = false, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<IdentityUser> UpdateAsync(IdentityUser entity, bool autoSave = false, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task UpdateManyAsync(IEnumerable<IdentityUser> entities, bool autoSave = false, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }
    }

}
