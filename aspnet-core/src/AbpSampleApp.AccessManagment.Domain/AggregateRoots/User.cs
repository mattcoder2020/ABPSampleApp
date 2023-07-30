using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace AbpSampleApp.AccessManagment.AggregateRoots
{
    public class User: AuditedAggregateRoot<User>
    {
        public string WechatOpenId { get;  set; }
        public string Alias { get; set; }
    }


}
