using Microsoft.EntityFrameworkCore;
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
    public class MyEfCoreIdentityUserRepository: EfCoreIdentityUserRepository, IMyIdentityUserRepository
    {
        public MyEfCoreIdentityUserRepository(
            IDbContextProvider<IIdentityDbContext> dbContextProvider)
            : base(dbContextProvider)
        {
        }

        public Task DeleteAsync(Guid id, bool autoSave = false, CancellationToken cancellationToken = default)
        {
             return base.DeleteAsync(id, autoSave, cancellationToken);
        }

        public Task DeleteAsync(IdentityUser entity, bool autoSave = false, CancellationToken cancellationToken = default)
        {
            return base.DeleteAsync(entity, autoSave, cancellationToken);
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
            return base.DeleteManyAsync(ids, autoSave, cancellationToken);
        }

        public Task DeleteManyAsync(IEnumerable<IdentityUser> entities, bool autoSave = false, CancellationToken cancellationToken = default)
        {
            return base.DeleteManyAsync(entities, autoSave, cancellationToken);
        }

        public Task<IdentityUser> FindAsync(Guid id, bool includeDetails = true, CancellationToken cancellationToken = default)
        {
            return base.FindAsync(id, includeDetails, cancellationToken);
        }

        public async Task<List<IdentityUser>> FindByCreationDateRange(DateTime from, DateTime to)
        {
            var dbContext = await GetDbContextAsync();
            var users = dbContext.Users.Where(u => u.CreationTime>=from.Date && u.CreationTime <=to.Date);
            return await users.ToListAsync();
        }

        public Task<IdentityUser> FindByLoginAsync(string loginProvider, string providerKey, bool includeDetails = true, CancellationToken cancellationToken = default)
        {
            return base.FindByLoginAsync(loginProvider, providerKey, includeDetails, cancellationToken);   

        }

        public Task<IdentityUser> FindByNormalizedEmailAsync(string normalizedEmail, bool includeDetails = true, CancellationToken cancellationToken = default)
        {
           return base.FindByNormalizedEmailAsync(normalizedEmail, includeDetails, cancellationToken);
        }

        public Task<IdentityUser> FindByNormalizedUserNameAsync(string normalizedUserName, bool includeDetails = true, CancellationToken cancellationToken = default)
        {
            return base.FindByNormalizedUserNameAsync(normalizedUserName, includeDetails, cancellationToken);
        }

        public Task<IdentityUser> FindByTenantIdAndUserNameAsync(string userName, Guid? tenantId, bool includeDetails = true, CancellationToken cancellationToken = default)
        {
            return base.FindByTenantIdAndUserNameAsync(userName, tenantId, includeDetails, cancellationToken);
        }

        public Task<IdentityUser> GetAsync(Guid id, bool includeDetails = true, CancellationToken cancellationToken = default)
        {
            return base.GetAsync(id, includeDetails, cancellationToken);
        }

        public Task<long> GetCountAsync(string filter = null, Guid? roleId = null, Guid? organizationUnitId = null, string userName = null, string phoneNumber = null, string emailAddress = null, string name = null, string surname = null, bool? isLockedOut = null, bool? notActive = null, bool? emailConfirmed = null, bool? isExternal = null, DateTime? maxCreationTime = null, DateTime? minCreationTime = null, DateTime? maxModifitionTime = null, DateTime? minModifitionTime = null, CancellationToken cancellationToken = default)
        {
            return base.GetCountAsync(filter, roleId, organizationUnitId, userName, phoneNumber, emailAddress, name, surname, isLockedOut, notActive, emailConfirmed, isExternal, maxCreationTime, minCreationTime, maxModifitionTime, minModifitionTime, cancellationToken);
        }

        public Task<long> GetCountAsync(CancellationToken cancellationToken = default)
        {
            return base.GetCountAsync(cancellationToken);
        }

        public Task<List<IdentityUser>> GetListAsync(string sorting = null, int maxResultCount = int.MaxValue, int skipCount = 0, string filter = null, bool includeDetails = false, Guid? roleId = null, Guid? organizationUnitId = null, string userName = null, string phoneNumber = null, string emailAddress = null, string name = null, string surname = null, bool? isLockedOut = null, bool? notActive = null, bool? emailConfirmed = null, bool? isExternal = null, DateTime? maxCreationTime = null, DateTime? minCreationTime = null, DateTime? maxModifitionTime = null, DateTime? minModifitionTime = null, CancellationToken cancellationToken = default)
        {
            return base.GetListAsync(sorting, maxResultCount, skipCount, filter, includeDetails, roleId, organizationUnitId, userName, phoneNumber, emailAddress, name, surname, isLockedOut, notActive, emailConfirmed, isExternal, maxCreationTime, minCreationTime, maxModifitionTime, minModifitionTime, cancellationToken);
        }

        public Task<List<IdentityUser>> GetListAsync(bool includeDetails = false, CancellationToken cancellationToken = default)
        {
            return base.GetListAsync(includeDetails, cancellationToken);
        }

        public Task<List<IdentityUser>> GetListByClaimAsync(Claim claim, bool includeDetails = false, CancellationToken cancellationToken = default)
        {
            return base.GetListByClaimAsync(claim, includeDetails, cancellationToken);
        }

        public Task<List<IdentityUser>> GetListByIdsAsync(IEnumerable<Guid> ids, bool includeDetails = false, CancellationToken cancellationToken = default)
        {
            return base.GetListByIdsAsync(ids, includeDetails, cancellationToken);
        }

        public Task<List<IdentityUser>> GetListByNormalizedRoleNameAsync(string normalizedRoleName, bool includeDetails = false, CancellationToken cancellationToken = default)
        {
            return base.GetListByNormalizedRoleNameAsync(normalizedRoleName, includeDetails, cancellationToken);
        }

        public Task<List<OrganizationUnit>> GetOrganizationUnitsAsync(Guid id, bool includeDetails = false, CancellationToken cancellationToken = default)
        {
            return base.GetOrganizationUnitsAsync(id, includeDetails, cancellationToken);
        }

        public Task<List<IdentityUser>> GetPagedListAsync(int skipCount, int maxResultCount, string sorting, bool includeDetails = false, CancellationToken cancellationToken = default)
        {
            return base.GetPagedListAsync(skipCount, maxResultCount, sorting, includeDetails, cancellationToken);
        }

        public Task<List<string>> GetRoleNamesAsync(Guid id, CancellationToken cancellationToken = default)
        {
            return base.GetRoleNamesAsync(id, cancellationToken);
        }

        public Task<List<string>> GetRoleNamesInOrganizationUnitAsync(Guid id, CancellationToken cancellationToken = default)
        {
            return base.GetRoleNamesInOrganizationUnitAsync(id, cancellationToken);
        }

        public Task<List<IdentityRole>> GetRolesAsync(Guid id, bool includeDetails = false, CancellationToken cancellationToken = default)
        {
            return base.GetRolesAsync(id, includeDetails, cancellationToken);
        }

        public Task<List<IdentityUser>> GetUsersInOrganizationsListAsync(List<Guid> organizationUnitIds, CancellationToken cancellationToken = default)
        {
            return base.GetUsersInOrganizationsListAsync(organizationUnitIds, cancellationToken);
        }

        public Task<List<IdentityUser>> GetUsersInOrganizationUnitAsync(Guid organizationUnitId, CancellationToken cancellationToken = default)
        {
            return base.GetUsersInOrganizationUnitAsync(organizationUnitId, cancellationToken);
        }

        public Task<List<IdentityUser>> GetUsersInOrganizationUnitWithChildrenAsync(string code, CancellationToken cancellationToken = default)
        {
            return base.GetUsersInOrganizationUnitWithChildrenAsync(code, cancellationToken);
        }

        public Task<IdentityUser> InsertAsync(IdentityUser entity, bool autoSave = false, CancellationToken cancellationToken = default)
        {
            return base.InsertAsync(entity, autoSave, cancellationToken);
        }

        public Task InsertManyAsync(IEnumerable<IdentityUser> entities, bool autoSave = false, CancellationToken cancellationToken = default)
        {
            return base.InsertManyAsync(entities, autoSave, cancellationToken);
        }

        public Task<IdentityUser> UpdateAsync(IdentityUser entity, bool autoSave = false, CancellationToken cancellationToken = default)
        {
            return base.UpdateAsync(entity, autoSave, cancellationToken);
        }

        public Task UpdateManyAsync(IEnumerable<IdentityUser> entities, bool autoSave = false, CancellationToken cancellationToken = default)
        {
            return base.UpdateManyAsync(entities, autoSave, cancellationToken);
        }
    }

}
