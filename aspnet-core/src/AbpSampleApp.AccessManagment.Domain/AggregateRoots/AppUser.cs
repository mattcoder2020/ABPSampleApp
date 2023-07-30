using Abp.Authorization.Users;
using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbpSampleApp.AccessManagment.AggregateRoots
{
    public class UserEntity : Entity<Guid>
    {
        // Properties representing your user entity
        public string UserName { get; set; }
        public string Email { get; set; }
        // Add other properties as needed

        public UserEntity()
        {
            // YourUserEntity constructor logic, if any
        }
    }
}
