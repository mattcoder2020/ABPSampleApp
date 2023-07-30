using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Identity;

namespace AbpSampleApp.AccessManagment.EntityFrameworkCore.Repository
{
    public interface IMyIdentityUserRepository:IIdentityUserRepository
    {
        public Task<List<IdentityUser>> FindByCreationDateRange(string email);
    }
}
