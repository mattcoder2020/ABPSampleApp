using System;

namespace AbpSampleApp.AccessManagment.Dto
{
    public class StoreQueryDTO
    {
        public Guid? Id { get; set; }
        public string? Name { get; set; }
        public DateTime? CreationDate { get; set; }
    }
}
