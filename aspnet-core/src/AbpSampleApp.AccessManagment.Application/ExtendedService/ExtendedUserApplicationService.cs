using Abp;
using AbpSampleApp.AccessManagment.AggregateRoots;
using AbpSampleApp.AccessManagment.EntityFrameworkCore.Repository;
using AutoMapper.Internal.Mappers;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Repositories;
using Volo.Abp.Identity;
using Volo.Abp.Users;

namespace AbpSampleApp.AccessManagment.ExtendedService
{

    [Dependency(ReplaceServices = true)]
    [ExposeServices(typeof(IIdentityUserAppService), typeof(IdentityUserAppService), typeof(MyIdentityUserAppService))]
    public class MyIdentityUserAppService : IdentityUserAppService
    {
      
        public MyIdentityUserAppService(
            IdentityUserManager userManager,
            IMyIdentityUserRepository userRepository,
            IIdentityRoleRepository roleRepository
        ) : base(
            userManager,
            userRepository,
            roleRepository,
            null)
            
        {
            UserRepository = userRepository;
        }

        public IMyIdentityUserRepository UserRepository { get; private set; }

        public async Task<List<IdentityUser>> FindByDateRange(DateTime from, DateTime to)
        {
            List<IdentityUser> users =  await UserRepository.FindByCreationDateRange(from, to );
            return users;
        }

       

    }

}
